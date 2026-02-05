using System;

namespace LabelControlBlazor.Models
{
    /// <summary>
    /// Tipos de items que puede contener un SuperTip
    /// </summary>
    public enum SuperTipItemType
    {
        Title,
        Content,
        Separator
    }

    /// <summary>
    /// Modelo base para items del SuperTip
    /// </summary>
    public class SuperTipItem
    {
        public SuperTipItemType Type { get; set; }
        public string Text { get; set; } = string.Empty;
        public string? IconPath { get; set; }
        public string? IconBase64 { get; set; }
        public string? CssClass { get; set; }
    }

    /// <summary>
    /// Item de título para el SuperTip
    /// </summary>
    public class SuperTipTitleItem : SuperTipItem
    {
        public SuperTipTitleItem()
        {
            Type = SuperTipItemType.Title;
        }

        public SuperTipTitleItem(string text)
        {
            Type = SuperTipItemType.Title;
            Text = text;
        }
    }

    /// <summary>
    /// Item de contenido para el SuperTip
    /// </summary>
    public class SuperTipContentItem : SuperTipItem
    {
        public SuperTipContentItem()
        {
            Type = SuperTipItemType.Content;
        }

        public SuperTipContentItem(string text, string? iconPath = null)
        {
            Type = SuperTipItemType.Content;
            Text = text;
            IconPath = iconPath;
        }
    }

    /// <summary>
    /// Item separador para el SuperTip
    /// </summary>
    public class SuperTipSeparatorItem : SuperTipItem
    {
        public SuperTipSeparatorItem()
        {
            Type = SuperTipItemType.Separator;
        }
    }
}
