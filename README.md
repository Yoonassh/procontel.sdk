# ProconTEL.Sdk
---------------

## Table of Contents

1. [Quick introduction](#id-quick-introduction)
2. [Feature Comparison](#id-feature-comparison)
3. [Builder blocks](#id-builder-blocks)
4. [Injected services](#id-injected-services)
5. [UI Components](#id-ui-components)
6. [Deployment](#id-deployment)

<div id='id-quick-introduction'/>

## 1. Quick introduction

`ProconTEL.Sdk` is a modern .Net Standard sdk for port your business logic in [ProconTEL](http://procontel.com/) environment. The modular design and middleware oriented architecture makes the endpoint highly customizable while providing sensible default for topology, communication and extensions. Documentation for version 1.x of the is currently found under [`/docs`](https://macrix.eu/).

<div id='id-feature-comparison'/>

## 2. Feature Comparison

| Feature         | x          | y | z |
| :-------------  |:-------------:|:---:|:------:|
| Backend         | redis         |redis| mongo  |
| Priorities      | ✓             |     |   ✓    |
| Concurrency     | ✓             |  ✓  |   ✓    |
| Delayed jobs    | ✓             |     |   ✓    |
| Global events   | ✓             |     |        |
| Rate Limiter    | ✓             |     |        |
| Pause/Resume    | ✓             |     |        |
| Sandboxed worker| ✓             |     |        |
| Repeatable jobs | ✓             |     |   ✓    |
| Atomic ops      | ✓             |  ✓  |        |
| Persistence     | ✓             |  ✓  |   ✓    |
| UI              | ✓             |     |   ✓    |
| REST API        |               |     |   ✓    |
| Optimized for   | Jobs / Messages | Messages | Jobs |

<div id='id-builder-blocks'/>

## 3. Builder blocks

### 3.1. ILifeTimeCycle
```csharp
 [EndpointMetadata(Name = "LifeTimeCycle", SupportedRoles = SupportedRoles.Both)]
  public class LifeTimeCycleEndpoint : IEndpointLifeTimeCycle
  {
    private readonly ILogger _logger;
    public LifeTimeCycleEndpoint(ILogger logger) => _logger = logger;

    public Task InitializeAsync()
    {
      _logger.Information("Initialize");
      return Task.CompletedTask;
    }

    public Task TerminateAsync()
    {
      _logger.Information("Terminate");
      return Task.CompletedTask;
    }
  }

```

### 3.2. IHandler
```csharp

```

<div id='id-injected-services'/>

## 4.Injected services

### 4.1. ILogger
```csharp

```

### 4.2. ISender
```csharp

```

<div id='id-ui-components'/>

## 5. UI Components

We are able to bind and communicate user interface to hosted business logic. Supported fronted framework:
 - Angular
 - React
 - Wpf
 - WinForms
 
### 5.1. Configuration Dialog
```csharp

```

### 5.2. Status Control
```csharp

```

<div id='id-deployment'/>

## 6.Deployment

### Github
```csharp

```

### Gitlab
```csharp

```
