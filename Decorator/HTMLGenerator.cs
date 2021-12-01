using System;

namespace Design_Patterns_Assignment
{
    class HTMLGenerator
    {
        internal static string TagProcessor(string tagSelection, string textInput)
        {
            IHTML html = new RegularHTML(textInput);
            tagSelection = tagSelection.ToLower();
            var taglist = tagSelection.Split(' ');
            foreach (var tag in taglist)
            {
                if (tag=="bold")
                {
                    html  = new BoldHTML(html);
                }
                if (tag == "deleted")
                {
                    html = new DeletedHTML(html);
                }
                if (tag == "emphasized")
                {
                    html = new EmphasizedHTML(html);
                }
                if (tag == "important")
                {
                    html = new ImportantHTML(html);
                }
                if (tag == "inserted")
                {
                    html = new InsertedHTML(html);
                }
                if (tag == "italic")
                {
                    html = new ItalicHTML(html);
                }
                if (tag == "marked")
                {
                    html = new MarkedHTML(html);
                }
                if (tag == "smaller")
                {
                    html = new SmallerHTML(html);
                }
                if (tag == "subscript")
                {
                    html = new SubScriptHTML(html);
                }
                if (tag == "superscript")
                {
                    html = new SuperScriptHTML(html);
                }
            }
            return html.GetHTMLString();
        }
    }
}