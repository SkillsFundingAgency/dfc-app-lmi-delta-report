﻿using System.Net.Http;

namespace DFC.App.Lmi.Delta.Report.UnitTests.FakeHttpHandlers
{
    public interface IFakeHttpRequestSender
    {
        HttpResponseMessage Send(HttpRequestMessage request);
    }
}
