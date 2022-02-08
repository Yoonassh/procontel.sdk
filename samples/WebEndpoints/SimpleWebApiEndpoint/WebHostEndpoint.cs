﻿using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;
using ProconTel.Sdk.Builders;
using ProconTel.Sdk.Communications.Middlewares;
using ProconTel.Sdk.Services;

namespace SimpleWebApiEndpoint
{
  public abstract class WebHostEndpoint<TStartup> : IEndpointLifeTimeCycle where TStartup : class
  {
    protected IWebHost _host;
    private readonly string[] _defaultUrls = new[] { "http://*:5000" };
    public string[] Urls { get; protected set; }

    protected ILogger Logger { get; private set; }
    protected IRuntimeContext RuntimeContext { get; private set; }
    private readonly Func<ILogger> _loggerFactory;
    private readonly Func<IRuntimeContext> _runtimeContextFactory;


    public WebHostEndpoint(
      Func<ILogger> loggerFactory,
      Func<IRuntimeContext> runtimeContextFactory)
    {
      _loggerFactory = loggerFactory;
      _runtimeContextFactory = runtimeContextFactory;
      Logger = loggerFactory();
      RuntimeContext = runtimeContextFactory();
    }

    public Task InitializeAsync(IMiddlewareBuilder builder)
    {
      var urls = Urls ?? _defaultUrls;
      Logger.Information($"Start initialize web host, urls = { string.Join(", ", urls.ToArray()) } ");
      _host = Microsoft.AspNetCore.WebHost
        .CreateDefaultBuilder()
        .UseContentRoot(Path.GetDirectoryName(typeof(WebHostEndpoint<>).Assembly.Location))
        .ConfigureServices(ioc =>
        {
          ConfigureServices(ioc);
        })
        .UseKestrel(options =>
        {
          SetKestrelOptions(options);
        })
        .UseStartup<TStartup>()
        .UseUrls(urls)
        .Build();

      return _host.StartAsync();
    }

    protected virtual void ConfigureServices(IServiceCollection ioc)
    {
      ioc.AddTransient(ctx => _loggerFactory());
      ioc.AddTransient(ctx => _runtimeContextFactory());
    }

    protected virtual void SetKestrelOptions(KestrelServerOptions options)
    {
    }

    public Task TerminateAsync()
    {
      Logger.Information($"Start terminating web host");
      if (_host != null)
      {
        return _host.StopAsync();
      }
      return Task.CompletedTask;
    }
  }
}
