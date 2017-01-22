using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using HtmlAgilityPack;

/*
This TH was written by Francisco Rodriguez
Usage:
<html-extraction html-local-path="pathname" html-attribute="class" html-attribute-value="content-wrapper">
</html-extraction
*/

namespace AdminLTE.NETCore.TagHelpers
{
    /// <summary>
    /// TagHelper used to extract section of a local html file.
    /// </summary>
    [HtmlTargetElement("html-extraction")]
    public class HtmlExtractionTagHelper : TagHelper
    {
        /// <summary>
        /// Currently only looking at local html files.
        /// </summary>
        [HtmlAttributeName("html-local-path")]
        public string HtmlLocalPath { get; set; }

        /// <summary>
        /// Type of Attribute looking for example "class"
        /// </summary>
        [HtmlAttributeName("html-attribute")]
        public string HtmlAttribute { get; set; } = "class";

        /// <summary>
        /// Type of Attribute looking for example "content-wrapper"
        /// </summary>
        [HtmlAttributeName("html-attribute-value")]
        public string HtmlAttributeValue { get; set; } = "content-wrapper";

        /// <summary>
        /// String replacement format {,} where the first element is the value to look for 
        /// and the second is the value to replace with        
        /// </summary>
        [HtmlAttributeName("html-replacement")]
        public string HtmlReplacement { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //Clear the TagName as it is only used for calling this taghelper
            output.TagName = "";

            //Don't do anything if this value is not provided
            if (!String.IsNullOrEmpty(HtmlLocalPath)
                && !(String.IsNullOrEmpty(HtmlAttribute))
                && !(String.IsNullOrEmpty(HtmlAttributeValue)))
            {
                //Todo: Add caching
                try
                {
                    HtmlDocument document2 = new HtmlDocument();
                    document2.Load(new System.IO.MemoryStream(System.IO.File.ReadAllBytes(HtmlLocalPath)));
                    var root = document2.DocumentNode;
                    var p = root.Descendants()
                    .Where(n => n.GetAttributeValue(HtmlAttribute, "").Equals(HtmlAttributeValue))
                    .Single();

                    //Make this configurable.
                    var content = p.InnerHtml.Replace("dist/img/", "/lib/AdminLTE-2.3.11/dist/img/");
                  
                    if (!String.IsNullOrEmpty(HtmlReplacement))
                    {
                        try
                        {
                            //TODO: Need an elegant way to split {},{}... and split the contents with comma.
                            //Right now only handling one
                            var splititem = HtmlReplacement.Split('{', '}');
                            if (splititem != null && splititem.Length > 0)
                            {
                                var replacement = splititem[1].Split(',');
                                content = content.Replace(replacement[0], replacement[1]);
                            }
                        }
                        catch
                        {
                        }
                    }

                    output.Content.SetHtmlContent(content);

                }
                catch  //Possibly not found or other error
                { }
            }
        }
    }
}
