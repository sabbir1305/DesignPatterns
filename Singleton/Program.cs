using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Singleton;


HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);


builder.Services.AddSingleton<IConverter, PDFConverter>();


using IHost host = builder.Build();


TestPdfConverter(host.Services.GetRequiredService<IConverter>(), "1");
TestPdfConverter(host.Services.GetRequiredService<IConverter>(), "2");

await host.RunAsync();

static void TestPdfConverter(IConverter pdfConverter, string callerID)
{
    List<string> sessions = new List<string>();
    string documentPath1 = @"c://test.docx";
    pdfConverter.Convert(documentPath1);
    sessions.Add(pdfConverter.GetSessionInfo());

    foreach (var session in sessions)
    {
        Console.WriteLine($"Caller id: {callerID} \n Session id: {session}");
        Console.WriteLine(".................................................");
    }


}