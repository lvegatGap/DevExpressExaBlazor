using System.Collections.Generic;
using System.Linq;

namespace LabelControlBlazor.Models
{
    /// <summary>
    /// Modelo que representa un SuperTip completo (equivalente a DevExpress.Utils.SuperToolTip)
    /// </summary>
    public class SuperTip
    {
        public List<SuperTipItem> Items { get; set; } = new List<SuperTipItem>();

        public bool AllowHtmlText { get; set; } = false;
        public int MaxWidth { get; set; } = 300;
        public string? CssClass { get; set; }

        public SuperTip()
        {
        }

        public SuperTip(string simpleText)
        {
            Items.Add(new SuperTipContentItem(simpleText));
        }

        /// <summary>
        /// Agrega un item de título
        /// </summary>
        public SuperTip AddTitle(string text)
        {
            Items.Add(new SuperTipTitleItem(text));
            return this;
        }

        /// <summary>
        /// Agrega un item de contenido
        /// </summary>
        public SuperTip AddContent(string text, string? iconPath = null)
        {
            Items.Add(new SuperTipContentItem(text, iconPath));
            return this;
        }

        /// <summary>
        /// Agrega un separador
        /// </summary>
        public SuperTip AddSeparator()
        {
            Items.Add(new SuperTipSeparatorItem());
            return this;
        }

        /// <summary>
        /// Verifica si el SuperTip tiene contenido
        /// </summary>
        public bool HasContent => Items.Any();
    }
}
