using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using SoapCore.Extensibility;

namespace WebSoap
{
    public class RequestContentHandler : IMessageInspector
    {
        public object AfterReceiveRequest(ref Message message)
        {
            string s = message.Headers.GetHeader<string>("user","");
            // Do something with user header.
            return null;
        }

        public void BeforeSendReply(ref Message reply, object correlationState)
        {
            // Add Header
            reply.Headers.Add(MessageHeader.CreateHeader("ack", "", "Header Working"));
        }
    }
}
