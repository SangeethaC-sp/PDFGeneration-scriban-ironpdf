namespace GeneratePDF
{
    public static class GeneratePDFFile
    {
        public static void Generate(string html, string outputPath)
        {
            var renderer = new IronPdf.ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf(html);
            pdf.SaveAs(outputPath);
        }
    }
}
