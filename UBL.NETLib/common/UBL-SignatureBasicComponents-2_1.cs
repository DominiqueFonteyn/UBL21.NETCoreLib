﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Deze code is gegenereerd met een hulpprogramma.
//     Runtime-versie:4.0.30319.42000
//
//     Als u wijzigingen aanbrengt in dit bestand, kan dit onjuist gedrag veroorzaken wanneer
//     de code wordt gegenereerd.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.7.3081.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ReferencedSignatureID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2", IsNullable=false)]
public partial class ReferencedSignatureIDType : IdentifierType1 {
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReferencedSignatureIDType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="IdentifierType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
public partial class IdentifierType1 : IdentifierType {
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentifierType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReferencedSignatureIDType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
public partial class IdentifierType {
    
    private string schemeIDField;
    
    private string schemeNameField;
    
    private string schemeAgencyIDField;
    
    private string schemeAgencyNameField;
    
    private string schemeVersionIDField;
    
    private string schemeDataURIField;
    
    private string schemeURIField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
    public string schemeID {
        get {
            return this.schemeIDField;
        }
        set {
            this.schemeIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string schemeName {
        get {
            return this.schemeNameField;
        }
        set {
            this.schemeNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
    public string schemeAgencyID {
        get {
            return this.schemeAgencyIDField;
        }
        set {
            this.schemeAgencyIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string schemeAgencyName {
        get {
            return this.schemeAgencyNameField;
        }
        set {
            this.schemeAgencyNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
    public string schemeVersionID {
        get {
            return this.schemeVersionIDField;
        }
        set {
            this.schemeVersionIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string schemeDataURI {
        get {
            return this.schemeDataURIField;
        }
        set {
            this.schemeDataURIField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string schemeURI {
        get {
            return this.schemeURIField;
        }
        set {
            this.schemeURIField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType="normalizedString")]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}
