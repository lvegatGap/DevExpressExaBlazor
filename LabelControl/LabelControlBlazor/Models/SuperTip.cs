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

        /// <summary>
        /// Convierte el SuperTip a texto plano para uso en atributo title de HTML
        /// </summary>
        public override string ToString()
        {
            if (!HasContent) return string.Empty;

            var parts = new List<string>();
            foreach (var item in Items)
            {
                if (item.Type == SuperTipItemType.Title)
                {
                    parts.Add($"** {item.Text} **");
                }
                else if (item.Type == SuperTipItemType.Content)
                {
                    parts.Add(item.Text);
                }
                else if (item.Type == SuperTipItemType.Separator)
                {
                    parts.Add("---");
                }
            }
            return string.Join("\n", parts);
        }
    }
}
