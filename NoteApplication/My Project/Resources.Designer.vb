﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Этот код был создан программным средством.
'
'     Изменения в этом файле могут привести к неправильному поведению и будут утрачены, если
'     код создается повторно.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My.Resources

    'Этот класс был автоматически создан при помощи StronglyTypedResourceBuilder
    'класс с  помощью таких средств, как ResGen или Visual Studio.
    'Чтобы добавить или удалить элемент, отредактируйте ResX-файл, а затем повторно запустите программу ResGen
    'с параметром /str или заново постройте ваш проект VS.
    '<summary>
    '  Класс ресурса со строгой типизацией для поиска локализованных строк и т. п.
    '</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"), _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()> _
    Friend Module Resources

        Private resourceMan As Global.System.Resources.ResourceManager

        Private resourceCulture As Global.System.Globalization.CultureInfo

        '<summary>
        '  Возврат кэшированного экземпляра ResourceManager, используемого этим классом.
        '</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("NoteApplication.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        '<summary>
        '  Переопределяет свойство CurrentUICulture текущего потока для всех
        '  подстановок ресурсов с помощью этого класса ресурса со строгой типизацией.
        '</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set(ByVal value As Global.System.Globalization.CultureInfo)
                resourceCulture = value
            End Set
        End Property
    End Module
End Namespace
