using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DeployTest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://iptc.org/std/nar/2006-10-01/", IsNullable = false)]
    public partial class newsItem
    {

        private newsItemCatalogRef[] catalogRefField;

        private newsItemRightsInfo rightsInfoField;

        private newsItemItemMeta itemMetaField;

        private newsItemContentMeta contentMetaField;

        private newsItemContentSet contentSetField;

        private string guidField;

        private byte versionField;

        private string standardField;

        private decimal standardversionField;

        private string conformanceField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("catalogRef")]
        public newsItemCatalogRef[] catalogRef
        {
            get
            {
                return this.catalogRefField;
            }
            set
            {
                this.catalogRefField = value;
            }
        }

        /// <remarks/>
        public newsItemRightsInfo rightsInfo
        {
            get
            {
                return this.rightsInfoField;
            }
            set
            {
                this.rightsInfoField = value;
            }
        }

        /// <remarks/>
        public newsItemItemMeta itemMeta
        {
            get
            {
                return this.itemMetaField;
            }
            set
            {
                this.itemMetaField = value;
            }
        }

        /// <remarks/>
        public newsItemContentMeta contentMeta
        {
            get
            {
                return this.contentMetaField;
            }
            set
            {
                this.contentMetaField = value;
            }
        }

        /// <remarks/>
        public newsItemContentSet contentSet
        {
            get
            {
                return this.contentSetField;
            }
            set
            {
                this.contentSetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string guid
        {
            get
            {
                return this.guidField;
            }
            set
            {
                this.guidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string standard
        {
            get
            {
                return this.standardField;
            }
            set
            {
                this.standardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal standardversion
        {
            get
            {
                return this.standardversionField;
            }
            set
            {
                this.standardversionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string conformance
        {
            get
            {
                return this.conformanceField;
            }
            set
            {
                this.conformanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemCatalogRef
    {

        private string hrefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemRightsInfo
    {

        private newsItemRightsInfoCopyrightHolder copyrightHolderField;

        private string copyrightNoticeField;

        private string usageTermsField;

        /// <remarks/>
        public newsItemRightsInfoCopyrightHolder copyrightHolder
        {
            get
            {
                return this.copyrightHolderField;
            }
            set
            {
                this.copyrightHolderField = value;
            }
        }

        /// <remarks/>
        public string copyrightNotice
        {
            get
            {
                return this.copyrightNoticeField;
            }
            set
            {
                this.copyrightNoticeField = value;
            }
        }

        /// <remarks/>
        public string usageTerms
        {
            get
            {
                return this.usageTermsField;
            }
            set
            {
                this.usageTermsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemRightsInfoCopyrightHolder
    {

        private string nameField;

        private string uriField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemItemMeta
    {

        private newsItemItemMetaItemClass itemClassField;

        private newsItemItemMetaProvider providerField;

        private System.DateTime versionCreatedField;

        private System.DateTime firstCreatedField;

        private System.DateTime embargoedField;

        private newsItemItemMetaPubStatus pubStatusField;

        private newsItemItemMetaService serviceField;

        private string edNoteField;

        private newsItemItemMetaSignal signalField;

        private newsItemItemMetaLink linkField;

        /// <remarks/>
        public newsItemItemMetaItemClass itemClass
        {
            get
            {
                return this.itemClassField;
            }
            set
            {
                this.itemClassField = value;
            }
        }

        /// <remarks/>
        public newsItemItemMetaProvider provider
        {
            get
            {
                return this.providerField;
            }
            set
            {
                this.providerField = value;
            }
        }

        /// <remarks/>
        public System.DateTime versionCreated
        {
            get
            {
                return this.versionCreatedField;
            }
            set
            {
                this.versionCreatedField = value;
            }
        }

        /// <remarks/>
        public System.DateTime firstCreated
        {
            get
            {
                return this.firstCreatedField;
            }
            set
            {
                this.firstCreatedField = value;
            }
        }

        /// <remarks/>
        public System.DateTime embargoed
        {
            get
            {
                return this.embargoedField;
            }
            set
            {
                this.embargoedField = value;
            }
        }

        /// <remarks/>
        public newsItemItemMetaPubStatus pubStatus
        {
            get
            {
                return this.pubStatusField;
            }
            set
            {
                this.pubStatusField = value;
            }
        }

        /// <remarks/>
        public newsItemItemMetaService service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        public string edNote
        {
            get
            {
                return this.edNoteField;
            }
            set
            {
                this.edNoteField = value;
            }
        }

        /// <remarks/>
        public newsItemItemMetaSignal signal
        {
            get
            {
                return this.signalField;
            }
            set
            {
                this.signalField = value;
            }
        }

        /// <remarks/>
        public newsItemItemMetaLink link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemItemMetaItemClass
    {

        private string qcodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string qcode
        {
            get
            {
                return this.qcodeField;
            }
            set
            {
                this.qcodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemItemMetaProvider
    {

        private string qcodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string qcode
        {
            get
            {
                return this.qcodeField;
            }
            set
            {
                this.qcodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemItemMetaPubStatus
    {

        private string qcodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string qcode
        {
            get
            {
                return this.qcodeField;
            }
            set
            {
                this.qcodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemItemMetaService
    {

        private string nameField;

        private string qcodeField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string qcode
        {
            get
            {
                return this.qcodeField;
            }
            set
            {
                this.qcodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemItemMetaSignal
    {

        private string qcodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string qcode
        {
            get
            {
                return this.qcodeField;
            }
            set
            {
                this.qcodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemItemMetaLink
    {

        private string relField;

        private string hrefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rel
        {
            get
            {
                return this.relField;
            }
            set
            {
                this.relField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemContentMeta
    {

        private System.DateTime contentCreatedField;

        private System.DateTime contentModifiedField;

        private newsItemContentMetaLocated locatedField;

        private newsItemContentMetaCreator creatorField;

        private newsItemContentMetaInfoSource infoSourceField;

        private newsItemContentMetaSubject[] subjectField;

        private newsItemContentMetaGenre genreField;

        private string sluglineField;

        private string headlineField;

        /// <remarks/>
        public System.DateTime contentCreated
        {
            get
            {
                return this.contentCreatedField;
            }
            set
            {
                this.contentCreatedField = value;
            }
        }

        /// <remarks/>
        public System.DateTime contentModified
        {
            get
            {
                return this.contentModifiedField;
            }
            set
            {
                this.contentModifiedField = value;
            }
        }

        /// <remarks/>
        public newsItemContentMetaLocated located
        {
            get
            {
                return this.locatedField;
            }
            set
            {
                this.locatedField = value;
            }
        }

        /// <remarks/>
        public newsItemContentMetaCreator creator
        {
            get
            {
                return this.creatorField;
            }
            set
            {
                this.creatorField = value;
            }
        }

        /// <remarks/>
        public newsItemContentMetaInfoSource infoSource
        {
            get
            {
                return this.infoSourceField;
            }
            set
            {
                this.infoSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subject")]
        public newsItemContentMetaSubject[] subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        /// <remarks/>
        public newsItemContentMetaGenre genre
        {
            get
            {
                return this.genreField;
            }
            set
            {
                this.genreField = value;
            }
        }

        /// <remarks/>
        public string slugline
        {
            get
            {
                return this.sluglineField;
            }
            set
            {
                this.sluglineField = value;
            }
        }

        /// <remarks/>
        public string headline
        {
            get
            {
                return this.headlineField;
            }
            set
            {
                this.headlineField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemContentMetaLocated
    {

        private string nameField;

        private newsItemContentMetaLocatedBroader[] broaderField;

        private string typeField;

        private string qcodeField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("broader")]
        public newsItemContentMetaLocatedBroader[] broader
        {
            get
            {
                return this.broaderField;
            }
            set
            {
                this.broaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string qcode
        {
            get
            {
                return this.qcodeField;
            }
            set
            {
                this.qcodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemContentMetaLocatedBroader
    {

        private string nameField;

        private string typeField;

        private string qcodeField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string qcode
        {
            get
            {
                return this.qcodeField;
            }
            set
            {
                this.qcodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemContentMetaCreator
    {

        private string nameField;

        private string uriField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemContentMetaInfoSource
    {

        private string uriField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemContentMetaSubject
    {

        private newsItemContentMetaSubjectName[] nameField;

        private newsItemContentMetaSubjectBroader broaderField;

        private string typeField;

        private string qcodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public newsItemContentMetaSubjectName[] name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public newsItemContentMetaSubjectBroader broader
        {
            get
            {
                return this.broaderField;
            }
            set
            {
                this.broaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string qcode
        {
            get
            {
                return this.qcodeField;
            }
            set
            {
                this.qcodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemContentMetaSubjectName
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemContentMetaSubjectBroader
    {

        private string qcodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string qcode
        {
            get
            {
                return this.qcodeField;
            }
            set
            {
                this.qcodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemContentMetaGenre
    {

        private newsItemContentMetaGenreName nameField;

        private string qcodeField;

        /// <remarks/>
        public newsItemContentMetaGenreName name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string qcode
        {
            get
            {
                return this.qcodeField;
            }
            set
            {
                this.qcodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemContentMetaGenreName
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemContentSet
    {

        private newsItemContentSetInlineXML inlineXMLField;

        /// <remarks/>
        public newsItemContentSetInlineXML inlineXML
        {
            get
            {
                return this.inlineXMLField;
            }
            set
            {
                this.inlineXMLField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://iptc.org/std/nar/2006-10-01/")]
    public partial class newsItemContentSetInlineXML
    {

        private string contenttypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contenttype
        {
            get
            {
                return this.contenttypeField;
            }
            set
            {
                this.contenttypeField = value;
            }
        }
    }


}
