using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Windows;
using System.Windows.Media;
using ICSharpCode.AvalonEdit.Highlighting;
using Microsoft.CodeAnalysis.Classification;
using RoslynPad.Editor;

namespace Xabbo.Scripter.Theme
{
    public class Dark2ClassificationHighlightColors : ClassificationHighlightColors
    {
        public static readonly Color DefaultColor = Color.FromRgb(220, 220, 220);
        public static readonly Color TypeColor = Color.FromRgb(78, 201, 176);
        public static readonly Color KeywordColor = Color.FromRgb(86, 156, 214);

        public Dark2ClassificationHighlightColors()
        {
            DefaultBrush = new HighlightingColor { Foreground = new SimpleHighlightingBrush(DefaultColor) };
            TypeBrush = new HighlightingColor { Foreground = new SimpleHighlightingBrush(TypeColor) };
            CommentBrush = new HighlightingColor { Foreground = new SimpleHighlightingBrush(Color.FromRgb(87, 166, 74)) };
            XmlCommentBrush = new HighlightingColor { Foreground = new SimpleHighlightingBrush(Color.FromRgb(87, 166, 74)) };
            KeywordBrush = new HighlightingColor { Foreground = new SimpleHighlightingBrush(KeywordColor) };
            PreprocessorKeywordBrush = new HighlightingColor { Foreground = new SimpleHighlightingBrush(Color.FromRgb(155, 155, 155)) };
            StringBrush = new HighlightingColor { Foreground = new SimpleHighlightingBrush(Color.FromRgb(214, 157, 133)) };
            MethodBrush = new HighlightingColor { Foreground = new SimpleHighlightingBrush(TypeColor) };
        }
    }
}