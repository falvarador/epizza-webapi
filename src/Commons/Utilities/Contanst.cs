namespace ePizza.WebApi.Common.Utility
{
    /// <summary>
    /// Description: Represents the sequence of constants for different types of content.
    /// Creation date: 07-06-2019
    /// </summary>
    public static class ContentTypes
    {
        public const string Json = "application/json";
        public const string Xml = "application/xml";
    }

    /// <summary>
    /// Description: Represents the sequence of constants for the different http response headers.
    /// Creation date: 04-04-2019
    /// </summary>
    public static class Headers
    {
        public const string Pagination = "X-Pagination";
    }

    /// <summary>
    /// Description: Represents the sequence of constants for the different database providers.
    /// Creation date: 29-01-2019
    /// </summary>
    public static class Connections
    {
        public const string DB2 = "DB2";
        public const string Access = "Access";
        public const string Default = "Default";
        public const string MySql = "MySql";
        public const string Firebird = "Firebird";
        public const string Informix = "Informix";
        public const string SQLite = "SQLite";
        public const string Oracle = "Oracle";
        public const string PostgreSql = "PostgreSql";
        public const string SqlAzure = "SqlAzure";
        public const string SqlCe = "SqlCe";
        public const string SqlServer = "SqlServer";
        public const string SapHana = "SapHana";
        public const string SybaseASE = "SybaseASE";
    }

    /// <summary>
    /// Description: Represents the sequence of constants for the different versions of the api.
    /// Creation date: 29-01-2019
    /// </summary>
    public class Versions
    {
        public const string v1 = "1";
        public const string v2 = "2";
        public const string v3 = "3";
        public const string v4 = "4";
        public const string v5 = "5";
        public const string v6 = "6";
        public const string v7 = "7";
        public const string v8 = "8";
        public const string v9 = "9";
    }

    /// <summary>
    /// Description: Represents the sequence of constants for compression methods.
    /// Creation date: 30-12-2019
    /// </summary>
    public class Compression 
    {
        public const string ContentEncodingHeader = "Content-Encoding";
        public const string ContentEncodingGzip = "gzip";
        public const string ContentEncodingDeflate = "deflate";
    }
}
