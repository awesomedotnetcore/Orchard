using System.Collections.Generic;
using Orchard.UI.Models;

namespace Orchard.Models.Driver {
    public class GetEditorsContext {
        public GetEditorsContext(IContent content) {
            ContentItem = content.ContentItem;
            Editors= new List<ModelTemplate>();
        }
        public ContentItem ContentItem { get; set; }
        public IList<ModelTemplate> Editors { get; set; }
    }
}