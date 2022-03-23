Imports DevExpress.XtraGrid.Localization
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraPrinting.Localization

Public Class SpanishGrid
    Inherits GridLocalizer

    Public Overrides ReadOnly Property Language() As String
        Get
            Return "Spanish"
        End Get
    End Property


    Public Overrides Function GetLocalizedString(ByVal id As DevExpress.XtraGrid.Localization.GridStringId) As String
        Select Case id
            Case GridStringId.FileIsNotFoundError : Return "Archivo {0} no encontrado"
            Case GridStringId.ColumnViewExceptionMessage : Return "¿Desea corregir el valor?"
            Case GridStringId.ColumnViewExceptionMessage : Return "¿Desea corregir el valor?"
            Case GridStringId.CustomizationCaption : Return "Personalizar"
            Case GridStringId.CustomizationCaption : Return "Personalizar"
            Case GridStringId.CustomizationColumns : Return "Columnas"
            Case GridStringId.CustomizationColumns : Return "Columnas"
            Case GridStringId.CustomizationBands : Return "Cabeceras"
            Case GridStringId.CustomizationBands : Return "Cabeceras"
            Case GridStringId.PopupFilterAll : Return "(Todos)"
            Case GridStringId.PopupFilterAll : Return "(Todos)"
            Case GridStringId.PopupFilterCustom : Return "(Personalizado)"
            Case GridStringId.PopupFilterCustom : Return "(Personalizado)"
            Case GridStringId.PopupFilterBlanks : Return "(Nulos)"
            Case GridStringId.PopupFilterBlanks : Return "(Nulos)"
            Case GridStringId.PopupFilterNonBlanks : Return "(No nulos)"
            Case GridStringId.PopupFilterNonBlanks : Return "(No nulos)"
            Case GridStringId.CustomFilterDialogFormCaption : Return "AutoFiltro personalizado"
            Case GridStringId.CustomFilterDialogFormCaption : Return "AutoFiltro personalizado"
            Case GridStringId.CustomFilterDialogCaption : Return "Mostrar filas donde:"
            Case GridStringId.CustomFilterDialogCaption : Return "Mostrar filas donde:"
            Case GridStringId.CustomFilterDialogRadioAnd : Return "&Y"
            Case GridStringId.CustomFilterDialogRadioAnd : Return "&Y"
            Case GridStringId.CustomFilterDialogRadioOr : Return "&O"
            Case GridStringId.CustomFilterDialogRadioOr : Return "&O"
            Case GridStringId.CustomFilterDialogOkButton : Return "&Aceptar"
            Case GridStringId.CustomFilterDialogOkButton : Return "&Aceptar"
            Case GridStringId.CustomFilterDialogClearFilter : Return "Quitar Fi&ltro"
            Case GridStringId.CustomFilterDialogClearFilter : Return "Quitar Fi&ltro"
            Case GridStringId.CustomFilterDialogCancelButton : Return "&Cancelar"
            Case GridStringId.CustomFilterDialogCancelButton : Return "&Cancelar"
            Case GridStringId.CustomFilterDialog2FieldCheck : Return "Campo"
            Case GridStringId.CustomFilterDialog2FieldCheck : Return "Campo"
            Case GridStringId.MenuFooterSum : Return "Suma"
            Case GridStringId.MenuFooterSum : Return "Suma"
            Case GridStringId.MenuFooterMin : Return "Mín"
            Case GridStringId.MenuFooterMin : Return "Mín"
            Case GridStringId.MenuFooterMax : Return "Máx"
            Case GridStringId.MenuFooterMax : Return "Máx"
            Case GridStringId.MenuFooterCount : Return "Recuento"
            Case GridStringId.MenuFooterCount : Return "Recuento"
            Case GridStringId.MenuFooterAverage : Return "Promedio"
            Case GridStringId.MenuFooterAverage : Return "Promedio"
            Case GridStringId.MenuFooterNone : Return "Ninguno"
            Case GridStringId.MenuFooterNone : Return "Ninguno"
            Case GridStringId.MenuFooterSumFormat : Return "SUM={0:#.##}"
            Case GridStringId.MenuFooterSumFormat : Return "SUM={0:#.##}"
            Case GridStringId.MenuFooterMinFormat : Return "MÍN={0}"
            Case GridStringId.MenuFooterMinFormat : Return "MÍN={0}"
            Case GridStringId.MenuFooterMaxFormat : Return "MÁX={0}"
            Case GridStringId.MenuFooterMaxFormat : Return "MÁX={0}"
            Case GridStringId.MenuFooterCountFormat : Return "{0}"
            Case GridStringId.MenuFooterCountFormat : Return "{0}"
            Case GridStringId.MenuFooterCountGroupFormat : Return "Recuento={0}"
            Case GridStringId.MenuFooterCountGroupFormat : Return "Recuento={0}"
            Case GridStringId.MenuFooterAverageFormat : Return "PRO={0:#.##}"
            Case GridStringId.MenuFooterAverageFormat : Return "PRO={0:#.##}"
            Case GridStringId.MenuFooterCustomFormat : Return "Personalizado={0}"
            Case GridStringId.MenuFooterCustomFormat : Return "Personalizado={0}"
            Case GridStringId.MenuColumnSortAscending : Return "Orden ascendente"
            Case GridStringId.MenuColumnSortAscending : Return "Orden ascendente"
            Case GridStringId.MenuColumnSortDescending : Return "Orden descendente"
            Case GridStringId.MenuColumnSortDescending : Return "Orden descendente"
            Case GridStringId.MenuColumnClearSorting : Return "Quitar orden"
            Case GridStringId.MenuColumnClearSorting : Return "Quitar orden"
            Case GridStringId.MenuColumnGroup : Return "Agrupar por esta columna"
            Case GridStringId.MenuColumnGroup : Return "Agrupar por esta columna"
            Case GridStringId.FilterPanelCustomizeButton : Return "Editar filtro"
            Case GridStringId.FilterPanelCustomizeButton : Return "Editar filtro"
            Case GridStringId.MenuColumnUnGroup : Return "Quitar grupos"
            Case GridStringId.MenuColumnUnGroup : Return "Quitar grupos"
            Case GridStringId.MenuColumnColumnCustomization : Return "Selector de columnas"
            Case GridStringId.MenuColumnColumnCustomization : Return "Selector de columnas"
            Case GridStringId.MenuColumnBestFit : Return "Ajuste perfecto"
            Case GridStringId.MenuColumnBestFit : Return "Ajuste perfecto"
            Case GridStringId.MenuColumnFilter : Return "Puede filtrar"
            Case GridStringId.MenuColumnFilter : Return "Puede filtrar"
            Case GridStringId.MenuColumnFilterEditor : Return "Editor de filtros"
            Case GridStringId.MenuColumnFilterEditor : Return "Editor de filtros"
            Case GridStringId.MenuColumnClearFilter : Return "Quitar filtro"
            Case GridStringId.MenuColumnClearFilter : Return "Quitar filtro"
            Case GridStringId.MenuColumnBestFitAllColumns : Return "Ajuste perfecto (todas las columnas)"
            Case GridStringId.MenuColumnBestFitAllColumns : Return "Ajuste perfecto (todas las columnas)"
            Case GridStringId.MenuGroupPanelFullExpand : Return "Expandir todos"
            Case GridStringId.MenuGroupPanelFullExpand : Return "Expandir todos"
            Case GridStringId.MenuGroupPanelFullCollapse : Return "Contraer todos"
            Case GridStringId.MenuGroupPanelFullCollapse : Return "Contraer todos"
            Case GridStringId.MenuGroupPanelClearGrouping : Return "Quitar grupos"
            Case GridStringId.MenuGroupPanelClearGrouping : Return "Quitar grupos"
            Case GridStringId.PrintDesignerBandedView : Return "Configurar impresión (vista rejilla con cabeceras)"
            Case GridStringId.PrintDesignerBandedView : Return "Configurar impresión (vista rejilla con cabeceras)"
            Case GridStringId.PrintDesignerGridView : Return "Configurar impresión (vista rejilla)"
            Case GridStringId.PrintDesignerGridView : Return "Configurar impresión (vista rejilla)"
            Case GridStringId.PrintDesignerCardView : Return "Configurar impresión (vista fichas)"
            Case GridStringId.PrintDesignerCardView : Return "Configurar impresión (vista fichas)"
            Case GridStringId.PrintDesignerBandHeader : Return "BandHeader"
            Case GridStringId.PrintDesignerBandHeader : Return "BandHeader"
            Case GridStringId.PrintDesignerDescription : Return "Configurar varias opciones de impresión de la vista actual."
            Case GridStringId.PrintDesignerDescription : Return "Configurar varias opciones de impresión de la vista actual."
            Case GridStringId.MenuColumnGroupBox : Return "Cuadro Agrupar por"
            Case GridStringId.MenuColumnGroupBox : Return "Cuadro Agrupar por"
            Case GridStringId.CardViewNewCard : Return "Nueva ficha"
            Case GridStringId.CardViewNewCard : Return "Nueva ficha"
            Case GridStringId.CardViewQuickCustomizationButton : Return "Personalizar"
            Case GridStringId.CardViewQuickCustomizationButton : Return "Personalizar"
            Case GridStringId.CardViewQuickCustomizationButtonFilter : Return "Filtro"
            Case GridStringId.CardViewQuickCustomizationButtonFilter : Return "Filtro"
            Case GridStringId.CardViewQuickCustomizationButtonSort : Return "Orden:"
            Case GridStringId.CardViewQuickCustomizationButtonSort : Return "Orden:"
            Case GridStringId.GridGroupPanelText : Return "Arrastre una columna aquí para agrupar por dicha columna"
            Case GridStringId.GridGroupPanelText : Return "Arrastre una columna aquí para agrupar por dicha columna"
            Case GridStringId.GridNewRowText : Return "Haga clic aquí para agregar una nueva línea"
            Case GridStringId.GridNewRowText : Return "Haga clic aquí para agregar una nueva línea"
            Case GridStringId.FilterBuilderOkButton : Return "&Aceptar"
            Case GridStringId.FilterBuilderOkButton : Return "&Aceptar"
            Case GridStringId.FilterBuilderCancelButton : Return "&Cancelar"
            Case GridStringId.FilterBuilderCancelButton : Return "&Cancelar"
            Case GridStringId.FilterBuilderApplyButton : Return "&Aplicar"
            Case GridStringId.FilterBuilderApplyButton : Return "&Aplicar"
            Case GridStringId.FilterBuilderCaption : Return "Editor de filtros"
            Case GridStringId.FilterBuilderCaption : Return "Editor de filtros"
            Case GridStringId.GridOutlookIntervals : Return "Antigüos;Mes pasado;Hace tres semanas;Hace dos semanas;Semana pasada;;;;;;;;Ayer;Hoy;Mañana;;;;;;;;Próxima semana;Próximas 2 semanas;Próximas 3 semanas;Mes que viene;Futuros;"
            Case GridStringId.GridOutlookIntervals : Return "Antigüos;Mes pasado;Hace tres semanas;Hace dos semanas;Semana pasada;;;;;;;;Ayer;Hoy;Mañana;;;;;;;;Próxima semana;Próximas 2 semanas;Próximas 3 semanas;Mes que viene;Futuros;"
            Case GridStringId.CustomizationFormColumnHint : Return "Arrastre columnas aquí para personalizar el diseño"
            Case GridStringId.CustomizationFormColumnHint : Return "Arrastre columnas aquí para personalizar el diseño"
            Case GridStringId.CustomizationFormBandHint : Return "Arrastre bandas aquí para personalizar el diseño"
            Case GridStringId.CustomizationFormBandHint : Return "Arrastre bandas aquí para personalizar el diseño"
            Case GridStringId.LayoutViewCloseZoomBtnHintClose : Return "Restaurar vista"
            Case GridStringId.LayoutViewCloseZoomBtnHintClose : Return "Restaurar vista"
            Case GridStringId.LayoutViewCloseZoomBtnHintZoom : Return "Maximizar detalle"
            Case GridStringId.LayoutViewCloseZoomBtnHintZoom : Return "Maximizar detalle"
            Case GridStringId.LayoutViewColumnModeBtnHint : Return "Una columna"
            Case GridStringId.LayoutViewColumnModeBtnHint : Return "Una columna"
            Case GridStringId.LayoutViewMultiColumnModeBtnHint : Return "Varias columnas"
            Case GridStringId.LayoutViewMultiColumnModeBtnHint : Return "Varias columnas"
            Case GridStringId.LayoutViewMultiRowModeBtnHint : Return "Varias filas"
            Case GridStringId.LayoutViewMultiRowModeBtnHint : Return "Varias filas"
            Case GridStringId.LayoutViewPanBtnHint : Return "Panning"
            Case GridStringId.LayoutViewPanBtnHint : Return "Panning"
            Case GridStringId.LayoutViewRowModeBtnHint : Return "Una fila"
            Case GridStringId.LayoutViewRowModeBtnHint : Return "Una fila"
            Case GridStringId.LayoutViewSingleModeBtnHint : Return "Una tarjeta"
            Case GridStringId.LayoutViewSingleModeBtnHint : Return "Una tarjeta"

        End Select
        Return MyBase.GetLocalizedString(id)
    End Function
End Class

Public Class SpanishEditor
    Inherits Localizer

    Public Overrides ReadOnly Property Language() As String
        Get
            Return "Spanish"
        End Get
    End Property

    Public Overrides Function GetLocalizedString(ByVal id As DevExpress.XtraEditors.Controls.StringId) As String
        Select Case id
            Case StringId.CaptionError : Return "Error"

            Case StringId.InvalidValueText : Return "Valor no válido"

            Case StringId.CheckChecked : Return "Seleccionado"

            Case StringId.CheckUnchecked : Return "Deseleccionado"

            Case StringId.CheckIndeterminate : Return "Indeterminado"

            Case StringId.DateEditToday : Return "Hoy"

            Case StringId.DateEditClear : Return "Vacía"

            Case StringId.OK : Return "&Aceptar"

            Case StringId.Cancel : Return "&Cancelar"

            Case StringId.NavigatorFirstButtonHint : Return "Primero"

            Case StringId.NavigatorPreviousButtonHint : Return "Anterior"

            Case StringId.NavigatorPreviousPageButtonHint : Return "Página anterior"

            Case StringId.NavigatorNextButtonHint : Return "Siguiente"

            Case StringId.NavigatorNextPageButtonHint : Return "Página siguiente"

            Case StringId.NavigatorLastButtonHint : Return "Último"

            Case StringId.NavigatorAppendButtonHint : Return "Agregar"

            Case StringId.NavigatorRemoveButtonHint : Return "Borrar"

            Case StringId.NavigatorEditButtonHint : Return "Editar"

            Case StringId.NavigatorEndEditButtonHint : Return "Finalizar edición"

            Case StringId.NavigatorCancelEditButtonHint : Return "Cancelar edición"

            Case StringId.NavigatorTextStringFormat : Return "Registro {0} de {1}"

            Case StringId.PictureEditMenuCut : Return "Cortar"

            Case StringId.PictureEditMenuCopy : Return "Copiar"

            Case StringId.PictureEditMenuPaste : Return "Pegar"

            Case StringId.PictureEditMenuDelete : Return "Borrar"

            Case StringId.PictureEditMenuLoad : Return "Abrir"

            Case StringId.PictureEditMenuSave : Return "Guardar"

            Case StringId.PictureEditOpenFileTitle : Return "Abrir"

            Case StringId.PictureEditSaveFileTitle : Return "Guardar como"

            Case StringId.PictureEditOpenFileError : Return "Formato de imagen erróneo"

            Case StringId.PictureEditOpenFileErrorCaption : Return "Error de apertura"

            Case StringId.LookUpEditValueIsNull : Return "[Vacío]"

            Case StringId.LookUpInvalidEditValueType : Return "Valor EditValue del LookUpEdit no es del tipo esperado."

            Case StringId.LookUpColumnDefaultName : Return "Nombre"

            Case StringId.PictureEditOpenFileFilter : Return "Archivos Bitmap (*.bmp)|*.bmp|Formato Graphics Interchange (*.gif)|*.gif|Formato JPEG File Interchange (*.jpg;*.jpeg)|*.jpg;*.jpeg|Ficheros de Íconos (*.ico)|*.ico|Ficheros de Imagenes |*.bmp;*.gif;*.jpg;*.jpeg;*.ico;*.png;*.tif|Todos los Ficheros |*.*"

            Case StringId.PictureEditSaveFileFilter : Return "Archivos Bitmap (*.bmp)|*.bmp|Formato Graphics Interchange (*.gif)|*.gif|Formato JPEG File Interchange (*.jpg)|*.jpg"

            Case StringId.UnknownPictureFormat : Return "Formato de imagen desconocido"

            Case StringId.DataEmpty : Return "Sin imagen"

            Case StringId.NotValidArrayLength : Return "No es una longitud de array válido."

            Case StringId.ImagePopupEmpty : Return "(Vacío)"

            Case StringId.ImagePopupPicture : Return "(Imagen)"

            Case StringId.ColorTabCustom : Return "Personalizado"

            Case StringId.ColorTabWeb : Return "Web"

            Case StringId.ColorTabSystem : Return "Sistema"

            Case StringId.CalcButtonMC : Return "MC"

            Case StringId.CalcButtonMR : Return "MR"

            Case StringId.CalcButtonMS : Return "MS"

            Case StringId.CalcButtonMx : Return "M+"

            Case StringId.CalcButtonSqrt : Return "raíz"

            Case StringId.CalcButtonBack : Return "Atrás"

            Case StringId.CalcButtonCE : Return "CE"

            Case StringId.CalcButtonC : Return "C"

            Case StringId.CalcError : Return "Error de cálculo"

            Case StringId.TabHeaderButtonPrev : Return "Desplazar a la izquierda"

            Case StringId.TabHeaderButtonNext : Return "Desplazar a la derecha"

            Case StringId.TabHeaderButtonClose : Return "Cerrar"

            Case StringId.XtraMessageBoxOkButtonText : Return "&Aceptar"

            Case StringId.XtraMessageBoxCancelButtonText : Return "&Cancelar"

            Case StringId.XtraMessageBoxYesButtonText : Return "&Sí"

            Case StringId.XtraMessageBoxNoButtonText : Return "&No"

            Case StringId.XtraMessageBoxAbortButtonText : Return "&Abortar"

            Case StringId.XtraMessageBoxRetryButtonText : Return "&Reintentar"

            Case StringId.XtraMessageBoxIgnoreButtonText : Return "&Ignorar"

            Case StringId.TextEditMenuUndo : Return "&Deshacer"

            Case StringId.TextEditMenuCut : Return "Cor&tar"

            Case StringId.TextEditMenuCopy : Return "&Copiar"

            Case StringId.TextEditMenuPaste : Return "&Pegar"

            Case StringId.TextEditMenuDelete : Return "&Eliminar"

            Case StringId.TextEditMenuSelectAll : Return "Seleccionar &todo"

            Case StringId.FilterGroupAnd : Return "Y"

            Case StringId.FilterGroupNotAnd : Return "Y no"

            Case StringId.FilterGroupNotOr : Return "O no"

            Case StringId.FilterGroupOr : Return "O"

            Case StringId.FilterClauseAnyOf : Return "Es cualquier"

            Case StringId.FilterClauseBeginsWith : Return "Comienza con"

            Case StringId.FilterClauseBetween : Return "Esta entre"

            Case StringId.FilterClauseBetweenAnd : Return "y"

            Case StringId.FilterClauseContains : Return "Contiene"

            Case StringId.FilterClauseEndsWith : Return "Acaba con"

            Case StringId.FilterClauseEquals : Return "Igual"

            Case StringId.FilterClauseGreater : Return "Es mayor que"

            Case StringId.FilterClauseGreaterOrEqual : Return "Es mayor o igual que"

            Case StringId.FilterClauseIsNotNull : Return "No está vacío"

            Case StringId.FilterClauseIsNull : Return "Vacío"

            Case StringId.FilterClauseLess : Return "Es menor que"

            Case StringId.FilterClauseLessOrEqual : Return "Es menor o igual que"

            Case StringId.FilterClauseLike : Return "Es como"

            Case StringId.FilterClauseNoneOf : Return "No es ninguno"

            Case StringId.FilterClauseNotBetween : Return "No está entre"

            Case StringId.FilterClauseDoesNotContain : Return "No contiene"

            Case StringId.FilterClauseDoesNotEqual : Return "No es igual"

            Case StringId.FilterClauseNotLike : Return "No es como"

            Case StringId.FilterEmptyEnter : Return "<introduzca un valor>"

            Case StringId.FilterEmptyValue : Return "<vacío>"

            Case StringId.FilterMenuConditionAdd : Return "Añadir condición"

            Case StringId.FilterMenuGroupAdd : Return "Añadir grupo"

            Case StringId.FilterMenuClearAll : Return "Quitar todos"

            Case StringId.FilterMenuRowRemove : Return "Quitar grupo"

            Case StringId.FilterToolTipNodeAdd : Return "Añade una nueva condición al grupo."

            Case StringId.FilterToolTipNodeRemove : Return "Quita la condición."

            Case StringId.FilterToolTipNodeAction : Return "Acciones."

            Case StringId.FilterToolTipValueType : Return "Compar un valor / valor de otro campo."

            Case StringId.FilterToolTipElementAdd : Return "Añadir un nuevo elemento a la lista."

            Case StringId.FilterToolTipKeysAdd : Return "(Use la tecla Insert o sumar)"

            Case StringId.FilterToolTipKeysRemove : Return "(Use la tecla Supr o restar)"

            Case StringId.ContainerAccessibleEditName : Return "Control de Edición"

            Case StringId.FilterCriteriaToStringGroupOperatorAnd : Return "Y"

            Case StringId.FilterCriteriaToStringGroupOperatorOr : Return "O"

            Case StringId.FilterCriteriaToStringUnaryOperatorBitwiseNot : Return "~"

            Case StringId.FilterCriteriaToStringUnaryOperatorIsNull : Return "Es Nulo"

            Case StringId.FilterCriteriaToStringUnaryOperatorMinus : Return "-"

            Case StringId.FilterCriteriaToStringUnaryOperatorNot : Return "No"

            Case StringId.FilterCriteriaToStringUnaryOperatorPlus : Return "+"

            Case StringId.FilterCriteriaToStringBinaryOperatorBitwiseAnd : Return "&"

            Case StringId.FilterCriteriaToStringBinaryOperatorBitwiseOr : Return "|"

            Case StringId.FilterCriteriaToStringBinaryOperatorBitwiseXor : Return "^"

            Case StringId.FilterCriteriaToStringBinaryOperatorDivide : Return "/"

            Case StringId.FilterCriteriaToStringBinaryOperatorEqual : Return "="

            Case StringId.FilterCriteriaToStringBinaryOperatorGreater : Return ">"

            Case StringId.FilterCriteriaToStringBinaryOperatorGreaterOrEqual : Return ">="

            Case StringId.FilterCriteriaToStringBinaryOperatorLess : Return "<"

            Case StringId.FilterCriteriaToStringBinaryOperatorLessOrEqual : Return "<="

            Case StringId.FilterCriteriaToStringBinaryOperatorLike : Return "Like"

            Case StringId.FilterCriteriaToStringBinaryOperatorMinus : Return "-"

            Case StringId.FilterCriteriaToStringBinaryOperatorModulo : Return "%"

            Case StringId.FilterCriteriaToStringBinaryOperatorMultiply : Return "*"

            Case StringId.FilterCriteriaToStringBinaryOperatorNotEqual : Return "<>"

            Case StringId.FilterCriteriaToStringBinaryOperatorPlus : Return "+"

            Case StringId.FilterCriteriaToStringBetween : Return "Entre"

            Case StringId.FilterCriteriaToStringIn : Return "En"

            Case StringId.FilterCriteriaToStringIsNotNull : Return "No Es Nulo"

            Case StringId.FilterCriteriaToStringNotLike : Return "No Contiene"

            Case StringId.FilterCriteriaToStringFunctionIif : Return "Si"

            Case StringId.FilterCriteriaToStringFunctionIsNull : Return "EsNulo"

            Case StringId.FilterCriteriaToStringFunctionLen : Return "Longitud"

            Case StringId.FilterCriteriaToStringFunctionLower : Return "Minúsculas"

            Case StringId.FilterCriteriaToStringFunctionNone : Return "Ninguno"

            Case StringId.FilterCriteriaToStringFunctionSubstring : Return "SubCadena"

            Case StringId.FilterCriteriaToStringFunctionTrim : Return "SinEspacios"

            Case StringId.FilterCriteriaToStringFunctionUpper : Return "Mayúsculas"

            Case StringId.FilterCriteriaToStringFunctionCustom : Return "Personalizado"

            Case StringId.Apply : Return "Aplicar"

            Case StringId.PreviewPanelText : Return "Vista previa:"

            Case StringId.PictureEditCopyImageError : Return "No se pudo copiar el imagen"

            Case StringId.TransparentBackColorNotSupported : Return "Éste control no tiene soporte para fondos transparentes"


        End Select

        Return MyBase.GetLocalizedString(id)
    End Function


End Class

Public Class SpanishPrint
    Inherits PreviewLocalizer

    Public Overrides Function GetLocalizedString(ByVal id As DevExpress.XtraPrinting.Localization.PreviewStringId) As String
        Select Case id
            Case PreviewStringId.BarText_MainMenu : Return "Menú principal"
            Case PreviewStringId.BarText_StatusBar : Return "Barra de estado"
            Case PreviewStringId.BarText_Toolbar : Return "Barra de herramientas"
            Case PreviewStringId.Button_Apply : Return "Aplicar"
            Case PreviewStringId.Button_Cancel : Return "Cancelar"
            Case PreviewStringId.Button_Help : Return "Ayuda"
            Case PreviewStringId.Button_Ok : Return "Aceptar"
            Case PreviewStringId.EMail_From : Return "De"
            Case PreviewStringId.ExportOption_HtmlCharacterSet : Return "Juego de caracteres:"
            Case PreviewStringId.ExportOption_HtmlExportMode : Return "Modo exportación:"
            Case PreviewStringId.ExportOption_HtmlExportMode_DifferentFiles : Return "Archivos diferentes"
            Case PreviewStringId.ExportOption_HtmlExportMode_SingleFile : Return "Un archivo único"
            Case PreviewStringId.ExportOption_HtmlExportMode_SingleFilePageByPage : Return "Un archivo por página"
            Case PreviewStringId.ExportOption_HtmlPageBorderColor : Return "Color borde página:"
            Case PreviewStringId.ExportOption_HtmlPageBorderWidth : Return "Ancho borde página:"
            Case PreviewStringId.ExportOption_HtmlPageRange : Return "Rango de páginas:"
            Case PreviewStringId.ExportOption_HtmlRemoveSecondarySymbols : Return "Quitar saltos de línea"
            Case PreviewStringId.ExportOption_HtmlTitle : Return "Título:"
            Case PreviewStringId.ExportOption_ImageExportMode : Return "Modo exportación:"
            Case PreviewStringId.ExportOption_ImageExportMode_DifferentFiles : Return "Diferentes archivos"
            Case PreviewStringId.ExportOption_ImageExportMode_SingleFile : Return "Un solo archivo"
            Case PreviewStringId.ExportOption_ImageExportMode_SingleFilePageByPage : Return "Un solo archivo página a página"
            Case PreviewStringId.ExportOption_ImageFormat : Return "Formato imagen:"
            Case PreviewStringId.ExportOption_ImagePageBorderColor : Return "Color borde página:"
            Case PreviewStringId.ExportOption_ImagePageBorderWidth : Return "Ancho borde página:"
            Case PreviewStringId.ExportOption_ImagePageRange : Return "Rango páginas:"
            Case PreviewStringId.ExportOption_ImageResolution : Return "Resolución (dpi):"
            Case PreviewStringId.ExportOption_NativeFormatCompressed : Return "Comprimido"
            Case PreviewStringId.ExportOption_PdfCompressed : Return "Comprimida"
            Case PreviewStringId.ExportOption_PdfDocumentApplication : Return "Aplicación:"
            Case PreviewStringId.ExportOption_PdfDocumentAuthor : Return "Autor:"
            Case PreviewStringId.ExportOption_PdfDocumentKeywords : Return "Claves:"
            Case PreviewStringId.ExportOption_PdfDocumentSubject : Return "Tema:"
            Case PreviewStringId.ExportOption_PdfDocumentTitle : Return "Título:"
            Case PreviewStringId.ExportOption_PdfImageQuality : Return "Calidad de imagen:"
            Case PreviewStringId.ExportOption_PdfImageQuality_High : Return "Alta"
            Case PreviewStringId.ExportOption_PdfImageQuality_Highest : Return "Más alta"
            Case PreviewStringId.ExportOption_PdfImageQuality_Low : Return "Baja"
            Case PreviewStringId.ExportOption_PdfImageQuality_Lowest : Return "Más baja"
            Case PreviewStringId.ExportOption_PdfImageQuality_Medium : Return "Media"
            Case PreviewStringId.ExportOption_PdfNeverEmbeddedFonts : Return "No embeber las fuentes:"
            Case PreviewStringId.ExportOption_PdfPageRange : Return "Rango de páginas:"
            Case PreviewStringId.ExportOption_PdfShowPrintDialogOnOpen : Return "Mostrar diálogo de impresión al abrir"
            Case PreviewStringId.ExportOption_RtfExportMode : Return "Mode exportación:"
            Case PreviewStringId.ExportOption_RtfExportMode_SingleFile : Return "Una solo archivo"
            Case PreviewStringId.ExportOption_RtfExportMode_SingleFilePageByPage : Return "Un solo archivo página a página"
            Case PreviewStringId.ExportOption_RtfExportWatermarks : Return "Exportar marcas de agua"
            Case PreviewStringId.ExportOption_RtfPageRange : Return "Rango páginas:"
            Case PreviewStringId.ExportOption_TextEncoding : Return "Codificación:"
            Case PreviewStringId.ExportOption_TextQuoteStringsWithSeparators : Return "Encomillar cadenas con separadores"
            Case PreviewStringId.ExportOption_TextSeparator : Return "Separador de texto:"
            Case PreviewStringId.ExportOption_TextSeparator_TabAlias : Return "TAB"
            Case PreviewStringId.ExportOption_XlsSheetName : Return "Nombre de hoja:"
            Case PreviewStringId.ExportOption_XlsShowGridLines : Return "Mostrar líneas de rejilla"
            Case PreviewStringId.ExportOptionsForm_CaptionCsv : Return "Opciones de Exportación Csv"
            Case PreviewStringId.ExportOptionsForm_CaptionHtml : Return "Opciones de Exportación Html"
            Case PreviewStringId.ExportOptionsForm_CaptionImage : Return "Opciones de Exportación de Imagenes"
            Case PreviewStringId.ExportOptionsForm_CaptionMht : Return "Opciones de Exportación Mht"
            Case PreviewStringId.ExportOptionsForm_CaptionNativeOptions : Return "Opciones formato nativo"
            Case PreviewStringId.ExportOptionsForm_CaptionPdf : Return "Opciones de Exportación Pdf"
            Case PreviewStringId.ExportOptionsForm_CaptionRtf : Return "Opciones de Exportación Rtf"
            Case PreviewStringId.ExportOptionsForm_CaptionTxt : Return "Opciones de Exportación de Texto"
            Case PreviewStringId.ExportOptionsForm_CaptionXls : Return "Opciones de Exportación Xls"
            Case PreviewStringId.FolderBrowseDlg_ExportDirectory : Return "Seleccione una carpeta donde desea guardar el documento exportado:"
            Case PreviewStringId.Margin_BottomMargin : Return "Margen inferior"
            Case PreviewStringId.Margin_Inch : Return "Pulgada"
            Case PreviewStringId.Margin_LeftMargin : Return "Margen izquierdo"
            Case PreviewStringId.Margin_Millimeter : Return "mm"
            Case PreviewStringId.Margin_RightMargin : Return "Margen derecho"
            Case PreviewStringId.Margin_TopMargin : Return "Margen superior"
            Case PreviewStringId.MenuItem_BackgrColor : Return "&Color de página..."
            Case PreviewStringId.MenuItem_Background : Return "&Fondo de página"
            Case PreviewStringId.MenuItem_CsvDocument : Return "Documento CSV"
            Case PreviewStringId.MenuItem_Exit : Return "Sa&lir"
            Case PreviewStringId.MenuItem_Export : Return "&Exportar como"
            Case PreviewStringId.MenuItem_File : Return "&Archivo"
            Case PreviewStringId.MenuItem_GraphicDocument : Return "Documento gráfico"
            Case PreviewStringId.MenuItem_HtmDocument : Return "Documento HTML"
            Case PreviewStringId.MenuItem_MhtDocument : Return "Documento MHT"
            Case PreviewStringId.MenuItem_PageLayout : Return "Ver &página"
            Case PreviewStringId.MenuItem_PageSetup : Return "Configurar &página..."
            Case PreviewStringId.MenuItem_PdfDocument : Return "Documento PDF"
            Case PreviewStringId.MenuItem_Print : Return "&Imprimir..."
            Case PreviewStringId.MenuItem_PrintDirect : Return "I&mpresión rápida"
            Case PreviewStringId.MenuItem_RtfDocument : Return "Documento RTF"
            Case PreviewStringId.MenuItem_Send : Return "En&viar a"
            Case PreviewStringId.MenuItem_TxtDocument : Return "Documento de texto"
            Case PreviewStringId.MenuItem_View : Return "&Vista"
            Case PreviewStringId.MenuItem_ViewContinuous : Return "&Continuo"
            Case PreviewStringId.MenuItem_ViewFacing : Return "&Paralelo"
            Case PreviewStringId.MenuItem_ViewStatusbar : Return "&Barra de estado"
            Case PreviewStringId.MenuItem_ViewToolbar : Return "&Barra de herramientas"
            Case PreviewStringId.MenuItem_Watermark : Return "&Marca de agua..."
            Case PreviewStringId.MenuItem_XlsDocument : Return "Documento de Excel"
            Case PreviewStringId.MenuItem_ZoomPageWidth : Return "Ancho página"
            Case PreviewStringId.MenuItem_ZoomTextWidth : Return "Ancho texto"
            Case PreviewStringId.MenuItem_ZoomTwoPages : Return "Dos páginas"
            Case PreviewStringId.MenuItem_ZoomWholePage : Return "Página entera"
            Case PreviewStringId.MPForm_Lbl_Pages : Return "Páginas"
            Case PreviewStringId.Msg_BigBitmapToCreate : Return "El archivo de salido es demasiado grande. Por favor, intente reducir la resolución del imagen,o seleccione otro modo de exportación."
            Case PreviewStringId.Msg_BigFileToCreateJPEG : Return "El archivo de salida es muy grande para crear un archivo JPEG. Por favor, elija otro formato de imagen u otro modo de exportación"
            Case PreviewStringId.Msg_CannotAccessFile : Return "No se puede acceder al archivo \'{0}\' porque esta en uso por otro proceso."
            Case PreviewStringId.Msg_CantFitBarcodeToControlBounds : Return "El área del control es demasiado pequeña para el código de barras"
            Case PreviewStringId.Msg_CreatingDocument : Return "Creando el documento..."
            Case PreviewStringId.Msg_CustomDrawWarning : Return "¡Aviso!"
            Case PreviewStringId.Msg_EmptyDocument : Return "El documento no contiene ninguna página."
            Case PreviewStringId.Msg_FileDosntContainValidXml : Return "El archivo indicado no contiene datos XML válidos con el formato PRNX. Carga interrumpida."
            Case PreviewStringId.Msg_FileDosntHavePrnxExtention : Return "El archivo indicado no tiene la extensión PRNX. Aún así ¿desea continuar?"
            Case PreviewStringId.Msg_FileReadOnly : Return "Fichero '{0}' es de solo lectura, inténtelo de nuevo con otro fichero."
            Case PreviewStringId.Msg_FontInvalidNumber : Return "El tamaño de la fuente no debe ser cero ni negativo"
            Case PreviewStringId.Msg_IncorrectPageRange : Return "No es un rango de páginas válida"
            Case PreviewStringId.Msg_IncorrectZoomFactor : Return "El número debe ser entre {0} y {1}."
            Case PreviewStringId.Msg_InvalidBarcodeText : Return "Existen carácteres no válidos en el texto"
            Case PreviewStringId.Msg_InvalidBarcodeTextFormat : Return "Formato de texto no válido"
            Case PreviewStringId.Msg_InvalidMeasurement : Return "No es una medida válida."
            Case PreviewStringId.Msg_NeedPrinter : Return "No hay impresoras instaladas."
            Case PreviewStringId.Msg_NoDifferentFilesInStream : Return "A document can't be exported to a stream in the DifferentFiles mode. Use the SingleFile or SingleFilePageByPage mode instead."
            Case PreviewStringId.Msg_NotSupportedFont : Return "Ésta fuente no está soportada"
            Case PreviewStringId.Msg_OpenFileQuestion : Return "¿Desea abrir éste archivo?"
            Case PreviewStringId.Msg_OpenFileQuestionCaption : Return "Exportar"
            Case PreviewStringId.Msg_PageMarginsWarning : Return "Uno o más de los margenes está fuera del área imprimible. ¿Desea continuar?"
            Case PreviewStringId.Msg_SearchDialogFinishedSearching : Return "Ha finalizado la búsqueda en el documento"
            Case PreviewStringId.Msg_SearchDialogReady : Return "Listo"
            Case PreviewStringId.Msg_SearchDialogTotalFound : Return "Total encontrado: "
            Case PreviewStringId.Msg_UnavailableNetPrinter : Return "La impresora de red no está disponible."
            Case PreviewStringId.Msg_WrongPageSettings : Return "La impresora actual no soporta éste tamaño de papel.\nAún así ¿desea continuar?"
            Case PreviewStringId.Msg_WrongPrinter : Return "El nombre de la impresora no es válido. Por favor, compruebe la configuración de la impresora."
            Case PreviewStringId.Msg_WrongPrinting : Return "Ocurrió en error imprimiendo el documento."
            Case PreviewStringId.Msg_XlsMoreThanMaxColumns : Return "El fichero generado de XLS es demasiado grande para el formato XLS, porque contiene mas de 256 columnas.Por favor, intente reducir el número de columnas del informe y exportarlo de nuevo ."
            Case PreviewStringId.Msg_XlsMoreThanMaxRows : Return "El fichero generado de XLS es demasiado grande para el formato XLS, porque contiene mas de 65536 filas. Por favor, intente reducir el número de filas del informe y exportarlo de nuevo ."
            Case PreviewStringId.OpenFileDialog_Filter : Return "Archivos Vista Preliminar (*{0})|*{0}|All Files (*.*)|*.*"
            Case PreviewStringId.OpenFileDialog_Title : Return "Abrir"
            Case PreviewStringId.PageInfo_PageDate : Return "[Date Printed]"
            Case PreviewStringId.PageInfo_PageNumber : Return "[Page #]"
            Case PreviewStringId.PageInfo_PageNumberOfTotal : Return "[Page # of Pages #]"
            Case PreviewStringId.PageInfo_PageTime : Return "[Time Printed]"
            Case PreviewStringId.PageInfo_PageUserName : Return "[User Name]"
            Case PreviewStringId.PreviewForm_Caption : Return "Vista preliminar"
            Case PreviewStringId.RibbonPreview_ClosePreview_Caption : Return "Cerrar vista preliminar"
            Case PreviewStringId.RibbonPreview_ClosePreview_STipContent : Return "Cerrar la vista preliminar del documento."
            Case PreviewStringId.RibbonPreview_ClosePreview_STipTitle : Return "Cerrar vista preliminar"
            Case PreviewStringId.RibbonPreview_Customize_Caption : Return "Opciones"
            Case PreviewStringId.RibbonPreview_Customize_STipContent : Return "Abre el Editor de Impresión de Componentes, donde puede cambiar algunas opciones de la impresión."
            Case PreviewStringId.RibbonPreview_Customize_STipTitle : Return "Opciones"
            Case PreviewStringId.RibbonPreview_DocumentMap_Caption : Return "Mapa del documento"
            Case PreviewStringId.RibbonPreview_DocumentMap_STipContent : Return "Abre el mapa del documento, permitiendo la navegación a través del documento por su estructura."
            Case PreviewStringId.RibbonPreview_DocumentMap_STipTitle : Return "Mapa del documento"
            Case PreviewStringId.RibbonPreview_EditPageHF_Caption : Return "Cabecera y pie"
            Case PreviewStringId.RibbonPreview_EditPageHF_STipContent : Return "Editar la cabecera y el pie del documento."
            Case PreviewStringId.RibbonPreview_EditPageHF_STipTitle : Return "Cabecera y pie"
            Case PreviewStringId.RibbonPreview_ExportCsv_Caption : Return "Archivo CSV"
            Case PreviewStringId.RibbonPreview_ExportCsv_Description : Return "Texto separado por comas"
            Case PreviewStringId.RibbonPreview_ExportCsv_STipContent : Return "Exportar el documento en formato CSV y guardarlo en disco."
            Case PreviewStringId.RibbonPreview_ExportCsv_STipTitle : Return "Exportar a CSV"
            Case PreviewStringId.RibbonPreview_ExportFile_Caption : Return "Exportar como"
            Case PreviewStringId.RibbonPreview_ExportFile_STipContent : Return "Exportar el documeto actual a uno de los formatos soportados y guardar en disco."
            Case PreviewStringId.RibbonPreview_ExportFile_STipTitle : Return "Exportar como"
            Case PreviewStringId.RibbonPreview_ExportGraphic_Caption : Return "Archivo de Imagen"
            Case PreviewStringId.RibbonPreview_ExportGraphic_Description : Return "BMP, GIF, JPEG, PNG, TIFF, EMF, WMF"
            Case PreviewStringId.RibbonPreview_ExportGraphic_STipContent : Return "Exportar el documento en formato de imagen y guardarlo en disco."
            Case PreviewStringId.RibbonPreview_ExportGraphic_STipTitle : Return "Exportar Imagen"
            Case PreviewStringId.RibbonPreview_ExportHtm_Caption : Return "Archivo HTML"
            Case PreviewStringId.RibbonPreview_ExportHtm_Description : Return "Página web"
            Case PreviewStringId.RibbonPreview_ExportHtm_STipContent : Return "Exportar el documento en formato HTML y guardarlo en disco."
            Case PreviewStringId.RibbonPreview_ExportHtm_STipTitle : Return "Exportar a HTML"
            Case PreviewStringId.RibbonPreview_ExportMht_Caption : Return "Archivo MHT"
            Case PreviewStringId.RibbonPreview_ExportMht_Description : Return "Página web simple"
            Case PreviewStringId.RibbonPreview_ExportMht_STipContent : Return "Exportar el documento en formato MHT y guardarlo en disco."
            Case PreviewStringId.RibbonPreview_ExportMht_STipTitle : Return "Exportar a MHT"
            Case PreviewStringId.RibbonPreview_ExportPdf_Caption : Return "Archivo PDF"
            Case PreviewStringId.RibbonPreview_ExportPdf_Description : Return "Adobe Portable Document Format"
            Case PreviewStringId.RibbonPreview_ExportPdf_STipContent : Return "Exportar el documento en formato PDF y guardarlo en disco."
            Case PreviewStringId.RibbonPreview_ExportPdf_STipTitle : Return "Exportar a PDF"
            Case PreviewStringId.RibbonPreview_ExportRtf_Caption : Return "Archivo RTF"
            Case PreviewStringId.RibbonPreview_ExportRtf_Description : Return "Texto con formato enriquecido"
            Case PreviewStringId.RibbonPreview_ExportRtf_STipContent : Return "Exportar el documento en formato RTF y guardarlo en disco."
            Case PreviewStringId.RibbonPreview_ExportRtf_STipTitle : Return "Exportar a RTF"
            Case PreviewStringId.RibbonPreview_ExportTxt_Caption : Return "Archivo de Texto"
            Case PreviewStringId.RibbonPreview_ExportTxt_Description : Return "Texto"
            Case PreviewStringId.RibbonPreview_ExportTxt_STipContent : Return "Exportar el documento en formato de texto y guardarlo en disco."
            Case PreviewStringId.RibbonPreview_ExportTxt_STipTitle : Return "Exportar a Texto"
            Case PreviewStringId.RibbonPreview_ExportXls_Caption : Return "Archivo Excel"
            Case PreviewStringId.RibbonPreview_ExportXls_Description : Return "Libro Microsoft Excel"
            Case PreviewStringId.RibbonPreview_ExportXls_STipContent : Return "Exportar el documento en formato XLS y guardarlo en disco."
            Case PreviewStringId.RibbonPreview_ExportXls_STipTitle : Return "Exportar a XLS"
            Case PreviewStringId.RibbonPreview_FillBackground_Caption : Return "Color de página"
            Case PreviewStringId.RibbonPreview_FillBackground_STipContent : Return "Escoge el color para usar como fondo de página."
            Case PreviewStringId.RibbonPreview_FillBackground_STipTitle : Return "Color de página"
            Case PreviewStringId.RibbonPreview_Find_Caption : Return "Buscar"
            Case PreviewStringId.RibbonPreview_Find_STipContent : Return "Muestra el diálogo para buscar texto en el documento."
            Case PreviewStringId.RibbonPreview_Find_STipTitle : Return "Buscar"
            Case PreviewStringId.RibbonPreview_GalleryItem_PageMargins_Description : Return "Superior:                {0}		Inferior:		   {1}      Izquierdo		 {2}		Derecho:		   {3}"
            Case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsModerate_Caption : Return "Moderado"
            Case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsModerate_Description : Return "Moderado"
            Case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsNarrow_Caption : Return "Estrecho"
            Case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsNarrow_Description : Return "Estrecho"
            Case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsNormal_Caption : Return "Normal"
            Case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsNormal_Description : Return "Normal"
            Case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsWide_Caption : Return "Ancho"
            Case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsWide_Description : Return "Ancho"
            Case PreviewStringId.RibbonPreview_GalleryItem_PageOrientationLandscape_Caption : Return "Horizontal"
            Case PreviewStringId.RibbonPreview_GalleryItem_PageOrientationLandscape_Description : Return " "
            Case PreviewStringId.RibbonPreview_GalleryItem_PageOrientationPortrait_Caption : Return "Vertical"
            Case PreviewStringId.RibbonPreview_GalleryItem_PageOrientationPortrait_Description : Return " "
            Case PreviewStringId.RibbonPreview_GalleryItem_PaperSize_Description : Return "{0} x {1}"
            Case PreviewStringId.RibbonPreview_HandTool_Caption : Return "Herramienta nano"
            Case PreviewStringId.RibbonPreview_HandTool_STipContent : Return "Invoca la herramienta Mano para desplazarse por el documento de forma manual."
            Case PreviewStringId.RibbonPreview_HandTool_STipTitle : Return "Herramienta mano"
            Case PreviewStringId.RibbonPreview_Magnifier_Caption : Return "Lupa"
            Case PreviewStringId.RibbonPreview_Magnifier_STipContent : Return "Invoca la herramienta Lupa. Haciendo clic una vez en el documento amplia la vista para visualizar una sola página, si lo vuelve a hacer amplia la vista al 100% de su tamaño original."
            Case PreviewStringId.RibbonPreview_Magnifier_STipTitle : Return "Lupa"
            Case PreviewStringId.RibbonPreview_MultiplePages_Caption : Return "Varias páginas"
            Case PreviewStringId.RibbonPreview_MultiplePages_STipContent : Return "Escoge la distribución de las páginas a mostrar en la vista preliminar."
            Case PreviewStringId.RibbonPreview_MultiplePages_STipTitle : Return "Ver varias páginas"
            Case PreviewStringId.RibbonPreview_Open_Caption : Return "Abrir"
            Case PreviewStringId.RibbonPreview_Open_STipContent : Return "Abrir un documento"
            Case PreviewStringId.RibbonPreview_Open_STipTitle : Return "Abrir (Ctrl + O)"
            Case PreviewStringId.RibbonPreview_PageGroup_Background : Return "Fondo de página"
            Case PreviewStringId.RibbonPreview_PageGroup_Document : Return "Documento"
            Case PreviewStringId.RibbonPreview_PageGroup_Export : Return "Exportar"
            Case PreviewStringId.RibbonPreview_PageGroup_Navigation : Return "Navegación"
            Case PreviewStringId.RibbonPreview_PageGroup_PageSetup : Return "Configurar página"
            Case PreviewStringId.RibbonPreview_PageGroup_PageSetup_STipContent : Return "Mostrar el diálogo de Configuración de Página."
            Case PreviewStringId.RibbonPreview_PageGroup_PageSetup_STipTitle : Return "Configurar página"
            Case PreviewStringId.RibbonPreview_PageGroup_Print : Return "Imprimir"
            Case PreviewStringId.RibbonPreview_PageGroup_Zoom : Return "Zoom"
            Case PreviewStringId.RibbonPreview_PageMargins_Caption : Return "Márgenes"
            Case PreviewStringId.RibbonPreview_PageMargins_STipContent : Return "Selecciona los tamaños de los márgenes para todo el documento. Para aplicar un tamaño personalizado, haga clic en Márgenes personalizados."
            Case PreviewStringId.RibbonPreview_PageMargins_STipTitle : Return "Márgenes de página"
            Case PreviewStringId.RibbonPreview_PageOrientation_Caption : Return "Orientación"
            Case PreviewStringId.RibbonPreview_PageOrientation_STipContent : Return "Cambia la orientación entre vertical y horizontal."
            Case PreviewStringId.RibbonPreview_PageOrientation_STipTitle : Return "Orientación de página"
            Case PreviewStringId.RibbonPreview_PageSetup_Caption : Return "Márgenes personalizados..."
            Case PreviewStringId.RibbonPreview_PageSetup_STipContent : Return "Mostrar el diálogo de Configuración de página."
            Case PreviewStringId.RibbonPreview_PageSetup_STipTitle : Return "Configurar página"
            Case PreviewStringId.RibbonPreview_PageText : Return "Vista preliminar"
            Case PreviewStringId.RibbonPreview_PaperSize_Caption : Return "Tamaño"
            Case PreviewStringId.RibbonPreview_PaperSize_STipContent : Return "Escoge un tamaño de papel"
            Case PreviewStringId.RibbonPreview_PaperSize_STipTitle : Return "Tamaño de página"
            Case PreviewStringId.RibbonPreview_Parameters_Caption : Return "Parámetros"
            Case PreviewStringId.RibbonPreview_Parameters_STipContent : Return "Abrir el panel de Parámetros, permitiendo la edición de los mismos."
            Case PreviewStringId.RibbonPreview_Parameters_STipTitle : Return "Parámetros"
            Case PreviewStringId.RibbonPreview_Pointer_Caption : Return "Puntero"
            Case PreviewStringId.RibbonPreview_Pointer_STipContent : Return "Mostrar el puntero del ratón."
            Case PreviewStringId.RibbonPreview_Pointer_STipTitle : Return "Puntero de ratón"
            Case PreviewStringId.RibbonPreview_Print_Caption : Return "Imprimir"
            Case PreviewStringId.RibbonPreview_Print_STipContent : Return "Selecciona una impresora, número de copias y otras opciones de impresión antes de imprimir."
            Case PreviewStringId.RibbonPreview_Print_STipTitle : Return "Imprimir (Ctrl+P)"
            Case PreviewStringId.RibbonPreview_PrintDirect_Caption : Return "Impresión rápida"
            Case PreviewStringId.RibbonPreview_PrintDirect_STipContent : Return "Envia el documento directamente a la impresora por defecto sin cambios."
            Case PreviewStringId.RibbonPreview_PrintDirect_STipTitle : Return "Impresión rápida"
            Case PreviewStringId.RibbonPreview_Save_Caption : Return "Guardar"
            Case PreviewStringId.RibbonPreview_Save_STipContent : Return "Guardar el documento"
            Case PreviewStringId.RibbonPreview_Save_STipTitle : Return "Guardar (Ctrl + S)"
            Case PreviewStringId.RibbonPreview_Scale_Caption : Return "Escala"
            Case PreviewStringId.RibbonPreview_Scale_STipContent : Return "Aumentar o disminuir la página impresa en un porcentaje de su tamaño original."
            Case PreviewStringId.RibbonPreview_Scale_STipTitle : Return "Escala"
            Case PreviewStringId.RibbonPreview_SendCsv_Caption : Return "Archivo CSV"
            Case PreviewStringId.RibbonPreview_SendCsv_Description : Return "Texto separado por comas"
            Case PreviewStringId.RibbonPreview_SendCsv_STipContent : Return "Exportar el documento a CSV y enviarlo como un adjunto."
            Case PreviewStringId.RibbonPreview_SendCsv_STipTitle : Return "E-Mail Como CSV"
            Case PreviewStringId.RibbonPreview_SendFile_Caption : Return "Enviar correo electrónico"
            Case PreviewStringId.RibbonPreview_SendFile_STipContent : Return "Exportar el documento actual a uno de los formatos soportados y enviarlo como un adjunto por correo electrónico."
            Case PreviewStringId.RibbonPreview_SendFile_STipTitle : Return "Enviar correo electrónico"
            Case PreviewStringId.RibbonPreview_SendGraphic_Caption : Return "Archivo de Imagen"
            Case PreviewStringId.RibbonPreview_SendGraphic_Description : Return "BMP, GIF, JPEG, PNG, TIFF, EMF, WMF"
            Case PreviewStringId.RibbonPreview_SendGraphic_STipContent : Return "Exportar el documento a una imagen y enviarlo como un adjunto."
            Case PreviewStringId.RibbonPreview_SendGraphic_STipTitle : Return "E-Mail Como Imagen"
            Case PreviewStringId.RibbonPreview_SendMht_Caption : Return "Archivo MHT"
            Case PreviewStringId.RibbonPreview_SendMht_Description : Return "Página web simple"
            Case PreviewStringId.RibbonPreview_SendMht_STipContent : Return "Exportar el documento a MHT y enviarlo como un adjunto."
            Case PreviewStringId.RibbonPreview_SendMht_STipTitle : Return "E-Mail Como MHT"
            Case PreviewStringId.RibbonPreview_SendPdf_Caption : Return "Archivo PDF"
            Case PreviewStringId.RibbonPreview_SendPdf_Description : Return "Adobe Portable Document Format"
            Case PreviewStringId.RibbonPreview_SendPdf_STipContent : Return "Exportar el documento a PDF y enviarlo como un adjunto."
            Case PreviewStringId.RibbonPreview_SendPdf_STipTitle : Return "E-Mail Como PDF"
            Case PreviewStringId.RibbonPreview_SendRtf_Caption : Return "Archivo RTF"
            Case PreviewStringId.RibbonPreview_SendRtf_Description : Return "Texto con formato enriquecido"
            Case PreviewStringId.RibbonPreview_SendRtf_STipContent : Return "Exportar el documento a RTF y enviarlo como un adjunto."
            Case PreviewStringId.RibbonPreview_SendRtf_STipTitle : Return "E-Mail Como RTF"
            Case PreviewStringId.RibbonPreview_SendTxt_Caption : Return "Archivo de Texto"
            Case PreviewStringId.RibbonPreview_SendTxt_Description : Return "Texto"
            Case PreviewStringId.RibbonPreview_SendTxt_STipContent : Return "Exportar el documento a texto y enviarlo por correo electrónico."
            Case PreviewStringId.RibbonPreview_SendTxt_STipTitle : Return "E-Mail Como Texto"
            Case PreviewStringId.RibbonPreview_SendXls_Caption : Return "Archivo Excel"
            Case PreviewStringId.RibbonPreview_SendXls_Description : Return "Libro Microsoft Excel"
            Case PreviewStringId.RibbonPreview_SendXls_STipContent : Return "Exportar el documento a XLS y enviarlo como un adjunto."
            Case PreviewStringId.RibbonPreview_SendXls_STipTitle : Return "E-Mail Como XLS"
            Case PreviewStringId.RibbonPreview_ShowFirstPage_Caption : Return "Primera página "
            Case PreviewStringId.RibbonPreview_ShowFirstPage_STipContent : Return "Desplazarse a la primera página del documento."
            Case PreviewStringId.RibbonPreview_ShowFirstPage_STipTitle : Return "Primera página (Ctrl+Inicio)"
            Case PreviewStringId.RibbonPreview_ShowLastPage_Caption : Return "Última página "
            Case PreviewStringId.RibbonPreview_ShowLastPage_STipContent : Return "Desplazarse a la última página del documento."
            Case PreviewStringId.RibbonPreview_ShowLastPage_STipTitle : Return "Última página (Ctrl+Fin)"
            Case PreviewStringId.RibbonPreview_ShowNextPage_Caption : Return "Página siguiente"
            Case PreviewStringId.RibbonPreview_ShowNextPage_STipContent : Return "Desplazarse a la página siguiente del documento."
            Case PreviewStringId.RibbonPreview_ShowNextPage_STipTitle : Return "Página siguiente (AvPág)"
            Case PreviewStringId.RibbonPreview_ShowPrevPage_Caption : Return "Página anterior "
            Case PreviewStringId.RibbonPreview_ShowPrevPage_STipContent : Return "Desplazarse a la página anterior del documento."
            Case PreviewStringId.RibbonPreview_ShowPrevPage_STipTitle : Return "Página anterior (RePág)"
            Case PreviewStringId.RibbonPreview_Watermark_Caption : Return "Marca de agua"
            Case PreviewStringId.RibbonPreview_Watermark_STipContent : Return "Insertar una imagen o texto fantasma detrás del contenido de la página. A menudo se emplea para indicar que el documento debe recibir un trato especial."
            Case PreviewStringId.RibbonPreview_Watermark_STipTitle : Return "Marca de agua"
            Case PreviewStringId.RibbonPreview_Zoom_Caption : Return "Zoom"
            Case PreviewStringId.RibbonPreview_Zoom_STipContent : Return "Cambia el nivel de zoom de la vista preliminar del documento."
            Case PreviewStringId.RibbonPreview_Zoom_STipTitle : Return "Zoom"
            Case PreviewStringId.RibbonPreview_ZoomExact_Caption : Return "Exacto:"
            Case PreviewStringId.RibbonPreview_ZoomIn_Caption : Return "Acercar"
            Case PreviewStringId.RibbonPreview_ZoomIn_STipContent : Return "Acercarse para tener una vista mas cercana del documento."
            Case PreviewStringId.RibbonPreview_ZoomIn_STipTitle : Return "Acercar"
            Case PreviewStringId.RibbonPreview_ZoomOut_Caption : Return "Alejar"
            Case PreviewStringId.RibbonPreview_ZoomOut_STipContent : Return "Alejarse para ver mas páginas a tamaño reducido."
            Case PreviewStringId.RibbonPreview_ZoomOut_STipTitle : Return "Alejar"
            Case PreviewStringId.SaveDlg_FilterBmp : Return "BMP Formato Mapa de Bits"
            Case PreviewStringId.SaveDlg_FilterCsv : Return "Documento CSV"
            Case PreviewStringId.SaveDlg_FilterEmf : Return "EMF Archivo de Metadata de Windows Ampliado"
            Case PreviewStringId.SaveDlg_FilterGif : Return "GIF Formato Gráfico de Intercambio"
            Case PreviewStringId.SaveDlg_FilterHtm : Return "Documento HTML"
            Case PreviewStringId.SaveDlg_FilterJpeg : Return "JPEG Formato Archivo de Intercambio"
            Case PreviewStringId.SaveDlg_FilterMht : Return "Documento MHT"
            Case PreviewStringId.SaveDlg_FilterNativeFormat : Return "Formato nativo"
            Case PreviewStringId.SaveDlg_FilterPdf : Return "Documento PDF"
            Case PreviewStringId.SaveDlg_FilterPng : Return "PNG Formato Gráfico Portable de Red"
            Case PreviewStringId.SaveDlg_FilterRtf : Return "Documento RTF"
            Case PreviewStringId.SaveDlg_FilterTiff : Return "TIFF Formato Archivo de Imágen Tag"
            Case PreviewStringId.SaveDlg_FilterTxt : Return "Documento de texto"
            Case PreviewStringId.SaveDlg_FilterWmf : Return "WMF Archivo de Metadata de Windows"
            Case PreviewStringId.SaveDlg_FilterXls : Return "Documento de Excel"
            Case PreviewStringId.SaveDlg_Title : Return "Guardar como"
            Case PreviewStringId.SB_PageOfPages : Return "Página:"
            Case PreviewStringId.SB_PageInfo : Return "{0} de {1}"
            Case PreviewStringId.SB_PageNone : Return "Ninguna"
            Case PreviewStringId.SB_PageOfPages : Return "Total páginas:"
            Case PreviewStringId.SB_ZoomFactor : Return "Nivel de zoom:"
            Case PreviewStringId.ScalePopup_AdjustTo : Return "Ajustar a:"
            Case PreviewStringId.ScalePopup_FitTo : Return "Ajustar a"
            Case PreviewStringId.ScalePopup_GroupText : Return "Escala"
            Case PreviewStringId.ScalePopup_NormalSize : Return "% tamaño normal"
            Case PreviewStringId.ScalePopup_PagesWide : Return "páginas de ancho"
            Case PreviewStringId.ScrollingInfo_Page : Return "Página"
            Case PreviewStringId.TB_TTip_Backgr : Return "Color de página"
            Case PreviewStringId.TB_TTip_Close : Return "Cerrar vista preliminar"
            Case PreviewStringId.TB_TTip_Customize : Return "Personalizar"
            Case PreviewStringId.TB_TTip_EditPageHF : Return "Editar cabecera y pie"
            Case PreviewStringId.TB_TTip_Export : Return "Exportar el documento a varios formatos"
            Case PreviewStringId.TB_TTip_FirstPage : Return "Primera página"
            Case PreviewStringId.TB_TTip_HandTool : Return "Herramienta de mano"
            Case PreviewStringId.TB_TTip_LastPage : Return "Última página"
            Case PreviewStringId.TB_TTip_Magnifier : Return "Aumentar"
            Case PreviewStringId.TB_TTip_Map : Return "Abrir mapa del documento"
            Case PreviewStringId.TB_TTip_MultiplePages : Return "Varias páginas"
            Case PreviewStringId.TB_TTip_NextPage : Return "Página siguiente"
            Case PreviewStringId.TB_TTip_Open : Return "Abrir un documento"
            Case PreviewStringId.TB_TTip_PageSetup : Return "Configurar página"
            Case PreviewStringId.TB_TTip_Parameters : Return "Parámetros"
            Case PreviewStringId.TB_TTip_PreviousPage : Return "Página anterior"
            Case PreviewStringId.TB_TTip_Print : Return "Imprimir"
            Case PreviewStringId.TB_TTip_PrintDirect : Return "Impresión rápida"
            Case PreviewStringId.TB_TTip_Save : Return "Guardar el documento"
            Case PreviewStringId.TB_TTip_Scale : Return "Escala"
            Case PreviewStringId.TB_TTip_Search : Return "Buscar texto"
            Case PreviewStringId.TB_TTip_Send : Return "Enviar el documento por correo elctrónico"
            Case PreviewStringId.TB_TTip_Watermark : Return "Marca de agua"
            Case PreviewStringId.TB_TTip_Zoom : Return "Zoom"
            Case PreviewStringId.TB_TTip_ZoomIn : Return "Acercar"
            Case PreviewStringId.TB_TTip_ZoomOut : Return "Alejar"
            Case PreviewStringId.WMForm_Direction_BackwardDiagonal : Return "Diagonal hacia abajo"
            Case PreviewStringId.WMForm_Direction_ForwardDiagonal : Return "Diagonal hacia arriba"
            Case PreviewStringId.WMForm_Direction_Horizontal : Return "Horizontal"
            Case PreviewStringId.WMForm_Direction_Vertical : Return "Vertical"
            Case PreviewStringId.WMForm_HorzAlign_Center : Return "Centro"
            Case PreviewStringId.WMForm_HorzAlign_Left : Return "Izquierda"
            Case PreviewStringId.WMForm_HorzAlign_Right : Return "Derecha"
            Case PreviewStringId.WMForm_ImageClip : Return "Recortar"
            Case PreviewStringId.WMForm_ImageStretch : Return "Estirar"
            Case PreviewStringId.WMForm_ImageZoom : Return "Zoom"
            Case PreviewStringId.WMForm_PageRangeRgrItem_All : Return "&Todas"
            Case PreviewStringId.WMForm_PageRangeRgrItem_Pages : Return "&Páginas:"
            Case PreviewStringId.WMForm_PictureDlg_Title : Return "Seleccione una imagen"
            Case PreviewStringId.WMForm_VertAlign_Bottom : Return "Abajo"
            Case PreviewStringId.WMForm_VertAlign_Middle : Return "Centro"
            Case PreviewStringId.WMForm_VertAlign_Top : Return "Arriba"
            Case PreviewStringId.WMForm_Watermark_Asap : Return "ASAP"
            Case PreviewStringId.WMForm_Watermark_Confidential : Return "CONFIDENCIAL"
            Case PreviewStringId.WMForm_Watermark_Copy : Return "COPIA"
            Case PreviewStringId.WMForm_Watermark_DoNotCopy : Return "NO COPIAR"
            Case PreviewStringId.WMForm_Watermark_Draft : Return "BORRADOR"
            Case PreviewStringId.WMForm_Watermark_Evaluation : Return "EVALUACION"
            Case PreviewStringId.WMForm_Watermark_Original : Return "ORIGINAL"
            Case PreviewStringId.WMForm_Watermark_Personal : Return "PERSONAL"
            Case PreviewStringId.WMForm_Watermark_Sample : Return "EJEMPLO"
            Case PreviewStringId.WMForm_Watermark_TopSecret : Return "MÁXIMO SECRETO"
            Case PreviewStringId.WMForm_Watermark_Urgent : Return "URGENTE"
            Case PreviewStringId.WMForm_ZOrderRgrItem_Behind : Return "&Detrás"
            Case PreviewStringId.WMForm_ZOrderRgrItem_InFront : Return "&Enfrente"

        End Select

        Return MyBase.GetLocalizedString(id)

    End Function
End Class
