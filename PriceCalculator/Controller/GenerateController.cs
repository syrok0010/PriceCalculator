using System;
using System.Linq;
using PriceCalculator.Model;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace PriceCalculator.Controller
{
    public class GenerateController
    {
        private readonly Generator _generator;
        public int FinalPrice { get; private set; }
        public int ChildPrice { get; private set; }
        public GenerateController(Generator generator)
        {
            _generator = generator ?? throw new ArgumentNullException();
        }

        public void Generate()
        {
             FinalPrice = (int) (_generator.Price * (1 - _generator.Comission / 100) / _generator.People * _generator.Nights +
                                 _generator.Expences);
            if (_generator.ChildPlace) ChildPrice = FinalPrice - 500;
        }

        public void Save()
        {
            using (var document = DocX.Create(@"table.docx"))
            {
                document.PageLayout.Orientation = Orientation.Landscape;
                var table = document.AddTable(1, 2);
                table.Rows[0].Cells[0].Paragraphs.First().Append(FinalPrice.ToString());
                table.Rows[0].Cells[1].Paragraphs.First().Append(ChildPrice.ToString());
                document.InsertTable(table);
                document.Save();
            }

        }
    }
}
