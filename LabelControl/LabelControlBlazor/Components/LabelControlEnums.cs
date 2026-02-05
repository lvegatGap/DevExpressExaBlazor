namespace LabelControlBlazor.Components
{
    /// <summary>
    /// Modo de auto-sizing del label (equivalente a DevExpress.XtraEditors.LabelAutoSizeMode)
    /// </summary>
    public enum LabelAutoSizeMode
    {
        /// <summary>
        /// Tamaño por defecto
        /// </summary>
        Default,

        /// <summary>
        /// El label se ajusta horizontalmente al contenido
        /// </summary>
        Horizontal,

        /// <summary>
        /// El label se ajusta verticalmente al contenido
        /// </summary>
        Vertical,

        /// <summary>
        /// El tamaño no se ajusta automáticamente
        /// </summary>
        None
    }

    /// <summary>
    /// Estilo del borde (equivalente a DevExpress.XtraEditors.Controls.BorderStyles)
    /// </summary>
    public enum BorderStyle
    {
        None,
        Simple,
        Flat,
        Office2003
    }

    /// <summary>
    /// Alineación horizontal (equivalente a DevExpress.Utils.HorzAlignment)
    /// </summary>
    public enum HorizontalAlignment
    {
        Left,
        Center,
        Right
    }

    /// <summary>
    /// Tipo de recorte de texto (equivalente a DevExpress.Utils.Trimming)
    /// </summary>
    public enum TextTrimming
    {
        None,
        Character,
        EllipsisCharacter,
        EllipsisWord
    }

    /// <summary>
    /// Alineación de la imagen con respecto al texto (equivalente a DevExpress.XtraEditors.ImageAlignToText)
    /// </summary>
    public enum ImageAlignToText
    {
        LeftTop,
        LeftCenter,
        LeftBottom,
        RightTop,
        RightCenter,
        RightBottom
    }
}
