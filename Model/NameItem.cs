using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsmaulHusna.Model
{
    public class NameItem
    {
        public string original { get; set; }
        public string latin { get; set; }
        public string meaning { get; set; }
        public string explanation { get; set; }
    }

    public class PageModel
    {
        public PageItem[] PageItems { get; set; }
    }

    public class ClickedItem
    {
        public int Index { get; set; }
        public Side Side { get; set; }
    }

    public enum Side
    {
        Source,
        Destination
    }

    public class PageItem
    {
        public NameItem NameItem { get; set; }
        public bool Found { get; set; }
        public int Index { get; set; }
        public int TargetIndex { get; set; }
    }
}
