//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProconTel.shortbasic {
    
    
    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlRoot("Telegram")]
    [System.Serializable()]
    public partial class ShortTelegram {
        
        private static string _headerXsbtDefinition = "<?xml version='1.0' encoding='utf-16'?><Telegram name='HeaderType' ID='' bytes='8' IsHeaderType='True' ContainsHeaderType='True'><element name='TelegramId' type='int' length='4' offset='0' HeaderHint='ID' comment='header plus data' /><element name='TelegramLength' type='int' length='4' offset='4' HeaderHint='Length' comment='Message Id' /></Telegram>";
        
        private static string _telegramXsbtDefinition = "<?xml version='1.0' encoding='utf-16'?><Telegram name='ShortTelegram' ID='111' bytes='263' ContainsHeaderType='True'><element name='HEAD' type='HeaderType' length='8' offset='0' count='1' comment='Header'><element name='TelegramId' type='int' length='4' offset='0' count='1' comment='header plus data' /><element name='TelegramLength' type='int' length='4' offset='4' count='1' comment='Message Id' /></element><element name='Message' type='string' length='255' offset='8' count='1' comment='x,y,z,speed [#]' /></Telegram>";
        
        private static string _typeDefinitions = "<typeMapping><typeDefinition name='dateTime' xmlType='dateTime'><typeInterpretation><stringFormat pattern='yyyy-MM-dd HH:mm:ss.fff' /></typeInterpretation></typeDefinition><typeDefinition name='date' xmlType='dateTime'><typeInterpretation><stringFormat pattern='yyyy-MM-dd HH:mm:ss.fff' /></typeInterpretation></typeDefinition><typeDefinition name='time_stamp' xmlType='dateTime'><typeInterpretation><stringFormat pattern='yyyy-MM-dd HH:mm:ss.fff' /></typeInterpretation></typeDefinition><typeDefinition name='s7char' xmlType='string'><typeInterpretation><s7charParts><s7charPart name='MaximumLength' offset='0' /><s7charPart name='RealLength' offset='1' /></s7charParts></typeInterpretation></typeDefinition><typeDefinition name='flag' xmlType='boolean' /><typeDefinition name='char' xmlType='string' /><typeDefinition name='string' xmlType='string' /><typeDefinition name='int' xmlType='integer' /><typeDefinition name='integer' xmlType='integer' /><typeDefinition name='short' xmlType='short' /><typeDefinition name='float' xmlType='float' /><typeDefinition name='Long' xmlType='long' /><typeDefinition name='number' xmlType='float' /><typeDefinition name='dint' xmlType='integer' /><typeDefinition name='real' xmlType='float' /><typeDefinition name='ushort' xmlType='unsignedShort' /><typeDefinition name='uint' xmlType='unsignedInt' /><typeDefinition name='ulong' xmlType='unsignedLong' /><typeDefinition name='PrimoString' xmlType='string' /><typeDefinition name='pcsstring' xmlType='string' /><typeDefinition name='opcstring' xmlType='string' /><typeDefinition name='Word' xmlType='string' /><typeDefinition name='binary' xmlType='base64Binary' /></typeMapping>";
        
        private HeaderType _hEAD = new HeaderType();
        
        private string _message = "";
        
        private const int @__MessageMaxLen_GnV9wpZa = 255;
        
        private static string _name = "ShortTelegram";
        
        private static string _iD = "111";
        
        /// <summary>
        /// Defines the fullname of telegram including namespace.
        /// </summary>
        public const string TelegramFullname = "ProconTel.shortbasic.ShortTelegram";
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ShortTelegram"/> class.
        /// </summary>
        public ShortTelegram() : 
                this(true) {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ShortTelegram"/> class.
        /// </summary>
        /// <param name="initWithDefaultValues">Determines whether the telegram should be initialized with default values.</param>
        public ShortTelegram(bool initWithDefaultValues) {
            this.HEAD = new HeaderType();
            this.HEAD.TelegramId = 111;
            this.HEAD.TelegramLength = 263;
            if (initWithDefaultValues) {
                Message = "";
            }
        }
        
        /// <summary>
        /// Gets Header xml definition.
        /// </summary>
        public static string HeaderXsbtDefinition {
            get {
                return ShortTelegram._headerXsbtDefinition;
            }
        }
        
        /// <summary>
        /// Gets Telegram xml definition.
        /// </summary>
        public static string TelegramXsbtDefinition {
            get {
                return ShortTelegram._telegramXsbtDefinition;
            }
        }
        
        /// <summary>
        /// Gets TypeDefinitions xml definition.
        /// </summary>
        public static string TypeDefinitions {
            get {
                return ShortTelegram._typeDefinitions;
            }
        }
        
        /// <summary>
        /// Gets or sets the Header.
        /// </summary>
        /// <value>The HEAD.</value>
        [System.Xml.Serialization.XmlElement("HEAD", IsNullable=true)]
        public HeaderType HEAD {
            get {
                return this._hEAD;
            }
            set {
                this._hEAD = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the x,y,z,speed. Unit: #.
        /// </summary>
        /// <value>The Message.</value>
        [System.Xml.Serialization.XmlElement("Message", IsNullable=true)]
        public string Message {
            get {
                return this._message;
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    this._message = "";
                }
                else {
                    this._message = value.Substring(0, System.Math.Min(value.Length, @__MessageMaxLen_GnV9wpZa));
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the array of key column values.
        /// </summary>
        /// <value>The arrays of key column values.</value>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public object[] Keys {
            get {
                object[] keys = new object[20];
                return keys;
            }
            set {
                if (((value == null) 
                            || (value.Length < 0))) {
                    throw new System.ArgumentException();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the telegram Name.
        /// </summary>
        /// <value>The Name.</value>
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name {
            get {
                return ShortTelegram._name;
            }
            set {
                if (value != null && !value.Equals("ShortTelegram")) {
throw new System.ArgumentException($"Name: '{value}' is not valid for telegram 'ShortTelegram'");
                }
                ShortTelegram._name = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the telegram ID.
        /// </summary>
        /// <value>The ID.</value>
        [System.Xml.Serialization.XmlAttributeAttribute("ID")]
        public string ID {
            get {
                return ShortTelegram._iD;
            }
            set {
                if ((value != "111")) {
throw new System.ArgumentException($"ID: '{value}' is not valid for telegram 'ShortTelegram'");
                }
                ShortTelegram._iD = value;
            }
        }
        
        /// <summary>
        /// Gets the default id of this telegram.
        /// </summary>
        /// <value>The XML table name.</value>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public static string Id {
            get {
                return "111";
            }
        }
        
        /// <summary>
        /// Gets the fullname of telegram including namespace.
        /// </summary>
        /// <value>The fullname of telegram including namespace.</value>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public string Fullname {
            get {
                return TelegramFullname;
            }
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ShortTelegram"/> class.
        /// Deserializes specified XML.
        /// </summary>
        /// <param name="xml">The XML.</param>
        /// <returns>Deserialized instance of the <see cref="ShortTelegram"/> class.</returns>
        public static ShortTelegram Create(string xml) {
            System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(ShortTelegram));
            return (ShortTelegram)xs.Deserialize(new System.IO.StringReader(xml));
        }
        
        /// <summary>
        /// Serializes this instance of the <see cref="ShortTelegram"/> class and returns this xml as string.
        /// </summary>
        /// <returns>Serialized instance of this <see cref="ShortTelegram"/> class.</returns>
        public string GetXml() {
            System.IO.StringWriter wr = new System.IO.StringWriter();
            new System.Xml.Serialization.XmlSerializer(typeof(ShortTelegram)).Serialize(wr, this);
            return wr.ToString();
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ShortTelegram"/> class.
        /// Deserializes specified bytes array.
        /// </summary>
        /// <param name="bytes">The bytes array.</param>
        /// <returns>Deserialized instance of the <see cref="ShortTelegram"/> class.</returns>
        public static ShortTelegram Create(byte[] bytes) {
            if (string.IsNullOrEmpty(_telegramXsbtDefinition)) throw new System.NotSupportedException();
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            if (!string.IsNullOrEmpty(_typeDefinitions)) doc.LoadXml(_typeDefinitions);
            var typeMapping = new ProconTel.Mapping.TypeMapping(doc);
            var telegramHeader = ProconTel.Mapping.XsbtHeaderReader.ReadXml(_headerXsbtDefinition, typeMapping);
            var xsbtRegistry = new ProconTel.Mapping.BinaryXmlTranslator.XsbtRegistry(telegramHeader);
            xsbtRegistry.AddSchema(_telegramXsbtDefinition);
            var settings = ProconTel.Mapping.BinaryXmlTranslator.BinarySettings.Default;
            var translator = new ProconTel.Mapping.BinaryXmlTranslator.Translator(xsbtRegistry, typeMapping, new ProconTel.Mapping.BinaryXmlTranslator.BinaryBufferConverter { SwapBytes = settings.SwapBytes, InfinityValuesAccepted = settings.InfinityValuesAccepted }) { Settings = settings };
            ShortTelegram telegram = new ShortTelegram();
            var validationResults = new System.Collections.Generic.List<ProconTel.Mapping.ValidationResult>();
            string telegramDetailsLog;
            translator.ConvertBufferToTelegramObject(translator.FindTelegramIdInBinaryData(bytes), telegram, bytes, out telegramDetailsLog, out validationResults);
            return (ShortTelegram)telegram;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ShortTelegram"/> class.
        /// Deserializes specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>Deserialized instance of the <see cref="ShortTelegram"/> class.</returns>
        public static ShortTelegram Create(object obj) {
            if(obj is string) return Create(obj.ToString());
            if(obj is byte[]) return Create((byte[])obj);
            return Create(obj.ToString());
        }
        
        /// <summary>
        /// Serializes this instance of the <see cref="ShortTelegram"/> class and returns bytes array.
        /// </summary>
        /// <returns>Serialized instance of this <see cref="ShortTelegram"/> class.</returns>
        public byte[] GetBytes() {
            if(string.IsNullOrEmpty(_telegramXsbtDefinition)) throw new System.NotSupportedException();
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            if (!string.IsNullOrEmpty(_typeDefinitions)) doc.LoadXml(_typeDefinitions);
            var typeMapping = new ProconTel.Mapping.TypeMapping(doc);
            var telegramHeader = ProconTel.Mapping.XsbtHeaderReader.ReadXml(_headerXsbtDefinition, typeMapping);
            var xsbtRegistry = new ProconTel.Mapping.BinaryXmlTranslator.XsbtRegistry(telegramHeader);
            var settings = ProconTel.Mapping.BinaryXmlTranslator.BinarySettings.Default;
            xsbtRegistry.AddSchema(_telegramXsbtDefinition);
            var translator = new ProconTel.Mapping.BinaryXmlTranslator.Translator(xsbtRegistry, typeMapping, new ProconTel.Mapping.BinaryXmlTranslator.BinaryBufferConverter { SwapBytes = settings.SwapBytes, InfinityValuesAccepted = settings.InfinityValuesAccepted }) { Settings = settings };
            var validationResult = new System.Collections.Generic.List<ProconTel.Mapping.ValidationResult>();
            return translator.ConvertTelegramObjectToBuffer(this, out validationResult);
        }
    }
}