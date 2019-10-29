using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Wox.Plugin.TodoPlus
{
    
    class QueryWriter : StreamWriter
    {
        protected internal const int DefaultBufferSize = 32 * 1024;
        public QueryWriter(Stream stream, Encoding encoding, bool leaveOpen) : base(stream, encoding, DefaultBufferSize, leaveOpen) { }
        public override void Write(string val)
        {
            var keywords = val.Split();

        }

        public override void WriteLine(string val)
        {
            // todo
        }
        

    }
}
