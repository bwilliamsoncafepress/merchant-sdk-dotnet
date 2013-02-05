/**
  * Stub objects for PayPalAPIInterfaceService 
  * AUTO_GENERATED_CODE 
  */
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using PayPal.Util;

namespace PayPal.PayPalAPIInterfaceService.Model
{

	public static class EnumUtils
	{
		public static string GetDescription(Enum value)
		{
			string description = "";
			DescriptionAttribute[] attributes = (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
			{
				description= attributes[0].Description;
			}
			return description;
		}
		
		public static object GetValue(string value,Type enumType)
		{
			string[] names = Enum.GetNames(enumType);
			foreach(string name in names)
            {
            	if (GetDescription((Enum)Enum.Parse(enumType, name)).Equals(value))
            	{
					return Enum.Parse(enumType, name);
				}
			}
			return null;
		}
	}

	public class DeserializationUtils
	{
		public static bool isWhiteSpaceNode(XmlNode n)
		{
			if (n.NodeType == XmlNodeType.Text)
			{
				string val = n.InnerText;
				return (val.Trim().Length == 0);
			}
			else if (n.NodeType == XmlNodeType.Element)
			{
				return (n.ChildNodes.Count == 0);
			}
			else
			{
				return false;
			}
		}
		
		public static string escapeInvalidXmlCharsRegex(string textContent)
        {
            string response = null;
            if (textContent != null && textContent.Length > 0)
            {
                response = Regex.Replace(
                                Regex.Replace(
                                    Regex.Replace(
                                        Regex.Replace(
                                            Regex.Replace(textContent, "&(?!(amp;|lt;|gt;|quot;|apos;))", "&amp;"), 
                                        "<", "&lt;"), 
                                    ">", "&gt;"), 
                                "\"", "&quot;"), 
                           "'", "&apos;");
            }
            return response;
        }
        
        public static string escapeInvalidXmlCharsRegex(int? intContent)
        {
            string response = null;
            if (intContent != null)
            {
                string textContent = intContent.ToString();
                response = escapeInvalidXmlCharsRegex(textContent);
            }
            return response;
        }

        public static string escapeInvalidXmlCharsRegex(decimal? decimalContent)
        {
            string response = null;
            if (decimalContent != null)
            {
                string textContent = decimalContent.ToString();
                response = escapeInvalidXmlCharsRegex(textContent);
            }
            return response;
        }

        public static string escapeInvalidXmlCharsRegex(bool? boolContent)
        {
            string response = null;
            if (boolContent != null)
            {
                string textContent = boolContent.ToString();
                response = escapeInvalidXmlCharsRegex(textContent);
            }
            return response;
        }
	}


	/**
      *On requests, you must set the currencyID attribute to one of
      *the three-character currency codes for any of the supported
      *PayPal currencies. Limitations: Must not exceed $10,000 USD
      *in any currency. No currency symbol. Decimal separator must
      *be a period (.), and the thousands separator must be a comma
      *(,).
      */
	public partial class BasicAmountType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:CoreComponentTypes";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "cc";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private CurrencyCodeType? currencyIDField;
		public CurrencyCodeType? currencyID
		{
			get
			{
				return this.currencyIDField;
			}
			set
			{
				this.currencyIDField = value;
			}
		}
		

		/**
          *
		  */
		private string valueField;
		public string value
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
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public BasicAmountType(CurrencyCodeType? currencyID, string value)
	 	{
			this.currencyID = currencyID;
			this.value = value;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public BasicAmountType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if (prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name);
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name);
				}
			sb.Append(GetAttributeAsXml());
			sb.Append(">");
			}
			if(value != null)
			{
				sb.Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.value));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		
		private string GetAttributeAsXml()
		{
			StringBuilder sb = new StringBuilder();
		if(currencyID != null)
		{
			sb.Append(" currencyID=\"").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.currencyID))).Append("\"");	
		}
			
			return sb.ToString();
		}
		public BasicAmountType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("@*[local-name() = 'currencyID']");
			if (ChildNode != null)
			{
				this.currencyID = (CurrencyCodeType)EnumUtils.GetValue(ChildNode.Value, typeof(CurrencyCodeType));	
			}
			this.value = xmlNode.InnerText;
	
		}
	}




	/**
      *
      */
	public partial class MeasureType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:CoreComponentTypes";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "cc";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string unitField;
		public string unit
		{
			get
			{
				return this.unitField;
			}
			set
			{
				this.unitField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? valueField;
		public decimal? value
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
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public MeasureType(string unit, decimal? value)
	 	{
			this.unit = unit;
			this.value = value;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public MeasureType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if (prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name);
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name);
				}
			sb.Append(GetAttributeAsXml());
			sb.Append(">");
			}
			if(value != null)
			{
				sb.Append(DeserializationUtils.escapeInvalidXmlCharsRegex(Convert.ToString(this.value, DefaultCulture)));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		
		private string GetAttributeAsXml()
		{
			StringBuilder sb = new StringBuilder();
		if(unit != null)
		{
			sb.Append(" unit =\"").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.unit)).Append("\"");
		}
			
			return sb.ToString();
		}
		public MeasureType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'unit']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.unit = ChildNode.InnerText;
			}
			this.value = System.Convert.ToDecimal(xmlNode.InnerText);
	
		}
	}




	/**
      * AckCodeType
      *    This code identifies the acknowledgement code types that
      *
      *    could be used to communicate the status of processing a 
      *    (request) message to an application. This code would be
      *used 
      *    as part of a response message that contains an
      *application 
      *    level acknowledgement element.
      * 
      */
    [Serializable]
	public enum AckCodeType {
		[Description("Success")]SUCCESS,	
		[Description("Failure")]FAILURE,	
		[Description("Warning")]WARNING,	
		[Description("SuccessWithWarning")]SUCCESSWITHWARNING,	
		[Description("FailureWithWarning")]FAILUREWITHWARNING,	
		[Description("PartialSuccess")]PARTIALSUCCESS,	
		[Description("CustomCode")]CUSTOMCODE	
	}




	/**
      * AddressOwnerCodeType
      *    This code identifies the AddressOwner code types which
      *indicates
      *    who owns the user'a address.
      * 
      */
    [Serializable]
	public enum AddressOwnerCodeType {
		[Description("PayPal")]PAYPAL,	
		[Description("eBay")]EBAY,	
		[Description("CustomCode")]CUSTOMCODE	
	}




	/**
      * CountryCodeType
      *   This code list module defines the enumerated types
      *    of standard 2-letter ISO 3166 country codes. This
      *codelist
      *    contains some additional country code not defined in
      *    the ISO 3166 country code set. 
      * 
      */
    [Serializable]
	public enum CountryCodeType {
		[Description("AF")]AF,	
		[Description("AL")]AL,	
		[Description("DZ")]DZ,	
		[Description("AS")]AS,	
		[Description("AD")]AD,	
		[Description("AO")]AO,	
		[Description("AI")]AI,	
		[Description("AQ")]AQ,	
		[Description("AG")]AG,	
		[Description("AR")]AR,	
		[Description("AM")]AM,	
		[Description("AW")]AW,	
		[Description("AU")]AU,	
		[Description("AT")]AT,	
		[Description("AZ")]AZ,	
		[Description("BS")]BS,	
		[Description("BH")]BH,	
		[Description("BD")]BD,	
		[Description("BB")]BB,	
		[Description("BY")]BY,	
		[Description("BE")]BE,	
		[Description("BZ")]BZ,	
		[Description("BJ")]BJ,	
		[Description("BM")]BM,	
		[Description("BT")]BT,	
		[Description("BO")]BO,	
		[Description("BA")]BA,	
		[Description("BW")]BW,	
		[Description("BV")]BV,	
		[Description("BR")]BR,	
		[Description("IO")]IO,	
		[Description("BN")]BN,	
		[Description("BG")]BG,	
		[Description("BF")]BF,	
		[Description("BI")]BI,	
		[Description("KH")]KH,	
		[Description("CM")]CM,	
		[Description("CA")]CA,	
		[Description("CV")]CV,	
		[Description("KY")]KY,	
		[Description("CF")]CF,	
		[Description("TD")]TD,	
		[Description("CL")]CL,	
		[Description("C2")]C,	
		[Description("CN")]CN,	
		[Description("CX")]CX,	
		[Description("CC")]CC,	
		[Description("CO")]CO,	
		[Description("KM")]KM,	
		[Description("CG")]CG,	
		[Description("CD")]CD,	
		[Description("CK")]CK,	
		[Description("CR")]CR,	
		[Description("CI")]CI,	
		[Description("HR")]HR,	
		[Description("CU")]CU,	
		[Description("CY")]CY,	
		[Description("CZ")]CZ,	
		[Description("DK")]DK,	
		[Description("DJ")]DJ,	
		[Description("DM")]DM,	
		[Description("DO")]DO,	
		[Description("TP")]TP,	
		[Description("EC")]EC,	
		[Description("EG")]EG,	
		[Description("SV")]SV,	
		[Description("GQ")]GQ,	
		[Description("ER")]ER,	
		[Description("EE")]EE,	
		[Description("ET")]ET,	
		[Description("FK")]FK,	
		[Description("FO")]FO,	
		[Description("FJ")]FJ,	
		[Description("FI")]FI,	
		[Description("FR")]FR,	
		[Description("GF")]GF,	
		[Description("PF")]PF,	
		[Description("TF")]TF,	
		[Description("GA")]GA,	
		[Description("GM")]GM,	
		[Description("GE")]GE,	
		[Description("DE")]DE,	
		[Description("GH")]GH,	
		[Description("GI")]GI,	
		[Description("GR")]GR,	
		[Description("GL")]GL,	
		[Description("GD")]GD,	
		[Description("GP")]GP,	
		[Description("GU")]GU,	
		[Description("GT")]GT,	
		[Description("GN")]GN,	
		[Description("GW")]GW,	
		[Description("GY")]GY,	
		[Description("HT")]HT,	
		[Description("HM")]HM,	
		[Description("VA")]VA,	
		[Description("HN")]HN,	
		[Description("HK")]HK,	
		[Description("HU")]HU,	
		[Description("IS")]IS,	
		[Description("IN")]IN,	
		[Description("ID")]ID,	
		[Description("IR")]IR,	
		[Description("IQ")]IQ,	
		[Description("IE")]IE,	
		[Description("IL")]IL,	
		[Description("IT")]IT,	
		[Description("JM")]JM,	
		[Description("JP")]JP,	
		[Description("JO")]JO,	
		[Description("KZ")]KZ,	
		[Description("KE")]KE,	
		[Description("KI")]KI,	
		[Description("KP")]KP,	
		[Description("KR")]KR,	
		[Description("KW")]KW,	
		[Description("KG")]KG,	
		[Description("LA")]LA,	
		[Description("LV")]LV,	
		[Description("LB")]LB,	
		[Description("LS")]LS,	
		[Description("LR")]LR,	
		[Description("LY")]LY,	
		[Description("LI")]LI,	
		[Description("LT")]LT,	
		[Description("LU")]LU,	
		[Description("MO")]MO,	
		[Description("MK")]MK,	
		[Description("MG")]MG,	
		[Description("MW")]MW,	
		[Description("MY")]MY,	
		[Description("MV")]MV,	
		[Description("ML")]ML,	
		[Description("MT")]MT,	
		[Description("MH")]MH,	
		[Description("MQ")]MQ,	
		[Description("MR")]MR,	
		[Description("MU")]MU,	
		[Description("YT")]YT,	
		[Description("MX")]MX,	
		[Description("FM")]FM,	
		[Description("MD")]MD,	
		[Description("MC")]MC,	
		[Description("MN")]MN,	
		[Description("MS")]MS,	
		[Description("MA")]MA,	
		[Description("MZ")]MZ,	
		[Description("MM")]MM,	
		[Description("NA")]NA,	
		[Description("NR")]NR,	
		[Description("NP")]NP,	
		[Description("NL")]NL,	
		[Description("AN")]AN,	
		[Description("NC")]NC,	
		[Description("NZ")]NZ,	
		[Description("NI")]NI,	
		[Description("NE")]NE,	
		[Description("NG")]NG,	
		[Description("NU")]NU,	
		[Description("NF")]NF,	
		[Description("MP")]MP,	
		[Description("NO")]NO,	
		[Description("OM")]OM,	
		[Description("PK")]PK,	
		[Description("PW")]PW,	
		[Description("PS")]PS,	
		[Description("PA")]PA,	
		[Description("PG")]PG,	
		[Description("PY")]PY,	
		[Description("PE")]PE,	
		[Description("PH")]PH,	
		[Description("PN")]PN,	
		[Description("PL")]PL,	
		[Description("PT")]PT,	
		[Description("PR")]PR,	
		[Description("QA")]QA,	
		[Description("RE")]RE,	
		[Description("RO")]RO,	
		[Description("RU")]RU,	
		[Description("RW")]RW,	
		[Description("SH")]SH,	
		[Description("KN")]KN,	
		[Description("LC")]LC,	
		[Description("PM")]PM,	
		[Description("VC")]VC,	
		[Description("WS")]WS,	
		[Description("SM")]SM,	
		[Description("ST")]ST,	
		[Description("SA")]SA,	
		[Description("SN")]SN,	
		[Description("SC")]SC,	
		[Description("SL")]SL,	
		[Description("SG")]SG,	
		[Description("SK")]SK,	
		[Description("SI")]SI,	
		[Description("SB")]SB,	
		[Description("SO")]SO,	
		[Description("ZA")]ZA,	
		[Description("GS")]GS,	
		[Description("ES")]ES,	
		[Description("LK")]LK,	
		[Description("SD")]SD,	
		[Description("SR")]SR,	
		[Description("SJ")]SJ,	
		[Description("SZ")]SZ,	
		[Description("SE")]SE,	
		[Description("CH")]CH,	
		[Description("SY")]SY,	
		[Description("TW")]TW,	
		[Description("TJ")]TJ,	
		[Description("TZ")]TZ,	
		[Description("TH")]TH,	
		[Description("TG")]TG,	
		[Description("TK")]TK,	
		[Description("TO")]TO,	
		[Description("TT")]TT,	
		[Description("TN")]TN,	
		[Description("TR")]TR,	
		[Description("TM")]TM,	
		[Description("TC")]TC,	
		[Description("TV")]TV,	
		[Description("UG")]UG,	
		[Description("UA")]UA,	
		[Description("AE")]AE,	
		[Description("GB")]GB,	
		[Description("US")]US,	
		[Description("UM")]UM,	
		[Description("UY")]UY,	
		[Description("UZ")]UZ,	
		[Description("VU")]VU,	
		[Description("VE")]VE,	
		[Description("VN")]VN,	
		[Description("VG")]VG,	
		[Description("VI")]VI,	
		[Description("WF")]WF,	
		[Description("EH")]EH,	
		[Description("YE")]YE,	
		[Description("YU")]YU,	
		[Description("ZM")]ZM,	
		[Description("ZW")]ZW,	
		[Description("AA")]AA,	
		[Description("QM")]QM,	
		[Description("QN")]QN,	
		[Description("QO")]QO,	
		[Description("QP")]QP,	
		[Description("CS")]CS,	
		[Description("CustomCode")]CUSTOMCODE,	
		[Description("GG")]GG,	
		[Description("IM")]IM,	
		[Description("JE")]JE,	
		[Description("TL")]TL	
	}




	/**
      * ISO 4217 standard 3-letter currency code. 
      *
      * 
      *The following currencies are supported by PayPal.
      *
      * Code
      * CurrencyMaximum Transaction Amount
      * 
      * AUD
      * Australian Dollar 
      * 12,500 AUD
      * 
      * 
      * CAD
      * Canadian Dollar12,500 CAD
      * 
      * 
      * EUR
      * Euro
      *  8,000 EUR
      * 
      * 
      * GBP
      * Pound Sterling
      *   5,500 GBP
      * 
      * 
      * JPY
      * Japanese Yen
      * 1,000,000 JPY
      * 
      * 
      * USD
      *  U.S. Dollar
      * 10,000 USD
      * 
      * 
      * CHF
      *  Czech Koruna
      * 70,000 CHF
      * 
      * 
      * SEK
      *  Swedish Krona
      * 3,50,000 SEK
      * 
      * 
      * NOK
      *  Norwegian Krone
      * 4,00,000 NOK
      * 
      * 
      * DKK
      *  Danish Krone
      * 3,00,000 DKK
      * 
      * 
      * PLN
      *  Poland Zloty
      * 1,60,000 PLN
      * 
      * 
      * HUF
      *  Hungary Forint
      * 110,00,000 HUF
      * 
      * 
      * SGD
      *  Singapore Dollar
      * 80,000 SGD
      * 
      * 
      * HKD
      *  HongKong Dollar
      * 3,80,000 HKD
      * 
      * 
      * NZD
      *  New Zealand Dollar
      * 77,000 NZD
      * 
      * 
      * CZK
      *  Czech Koruna
      * 1,20,000 CZK
      * 
      * 
      * 
      */
    [Serializable]
	public enum CurrencyCodeType {
		[Description("AFA")]AFA,	
		[Description("ALL")]ALL,	
		[Description("DZD")]DZD,	
		[Description("ADP")]ADP,	
		[Description("AOA")]AOA,	
		[Description("ARS")]ARS,	
		[Description("AMD")]AMD,	
		[Description("AWG")]AWG,	
		[Description("AZM")]AZM,	
		[Description("BSD")]BSD,	
		[Description("BHD")]BHD,	
		[Description("BDT")]BDT,	
		[Description("BBD")]BBD,	
		[Description("BYR")]BYR,	
		[Description("BZD")]BZD,	
		[Description("BMD")]BMD,	
		[Description("BTN")]BTN,	
		[Description("INR")]INR,	
		[Description("BOV")]BOV,	
		[Description("BOB")]BOB,	
		[Description("BAM")]BAM,	
		[Description("BWP")]BWP,	
		[Description("BRL")]BRL,	
		[Description("BND")]BND,	
		[Description("BGL")]BGL,	
		[Description("BGN")]BGN,	
		[Description("BIF")]BIF,	
		[Description("KHR")]KHR,	
		[Description("CAD")]CAD,	
		[Description("CVE")]CVE,	
		[Description("KYD")]KYD,	
		[Description("XAF")]XAF,	
		[Description("CLF")]CLF,	
		[Description("CLP")]CLP,	
		[Description("CNY")]CNY,	
		[Description("COP")]COP,	
		[Description("KMF")]KMF,	
		[Description("CDF")]CDF,	
		[Description("CRC")]CRC,	
		[Description("HRK")]HRK,	
		[Description("CUP")]CUP,	
		[Description("CYP")]CYP,	
		[Description("CZK")]CZK,	
		[Description("DKK")]DKK,	
		[Description("DJF")]DJF,	
		[Description("DOP")]DOP,	
		[Description("TPE")]TPE,	
		[Description("ECV")]ECV,	
		[Description("ECS")]ECS,	
		[Description("EGP")]EGP,	
		[Description("SVC")]SVC,	
		[Description("ERN")]ERN,	
		[Description("EEK")]EEK,	
		[Description("ETB")]ETB,	
		[Description("FKP")]FKP,	
		[Description("FJD")]FJD,	
		[Description("GMD")]GMD,	
		[Description("GEL")]GEL,	
		[Description("GHC")]GHC,	
		[Description("GIP")]GIP,	
		[Description("GTQ")]GTQ,	
		[Description("GNF")]GNF,	
		[Description("GWP")]GWP,	
		[Description("GYD")]GYD,	
		[Description("HTG")]HTG,	
		[Description("HNL")]HNL,	
		[Description("HKD")]HKD,	
		[Description("HUF")]HUF,	
		[Description("ISK")]ISK,	
		[Description("IDR")]IDR,	
		[Description("IRR")]IRR,	
		[Description("IQD")]IQD,	
		[Description("ILS")]ILS,	
		[Description("JMD")]JMD,	
		[Description("JPY")]JPY,	
		[Description("JOD")]JOD,	
		[Description("KZT")]KZT,	
		[Description("KES")]KES,	
		[Description("AUD")]AUD,	
		[Description("KPW")]KPW,	
		[Description("KRW")]KRW,	
		[Description("KWD")]KWD,	
		[Description("KGS")]KGS,	
		[Description("LAK")]LAK,	
		[Description("LVL")]LVL,	
		[Description("LBP")]LBP,	
		[Description("LSL")]LSL,	
		[Description("LRD")]LRD,	
		[Description("LYD")]LYD,	
		[Description("CHF")]CHF,	
		[Description("LTL")]LTL,	
		[Description("MOP")]MOP,	
		[Description("MKD")]MKD,	
		[Description("MGF")]MGF,	
		[Description("MWK")]MWK,	
		[Description("MYR")]MYR,	
		[Description("MVR")]MVR,	
		[Description("MTL")]MTL,	
		[Description("EUR")]EUR,	
		[Description("MRO")]MRO,	
		[Description("MUR")]MUR,	
		[Description("MXN")]MXN,	
		[Description("MXV")]MXV,	
		[Description("MDL")]MDL,	
		[Description("MNT")]MNT,	
		[Description("XCD")]XCD,	
		[Description("MZM")]MZM,	
		[Description("MMK")]MMK,	
		[Description("ZAR")]ZAR,	
		[Description("NAD")]NAD,	
		[Description("NPR")]NPR,	
		[Description("ANG")]ANG,	
		[Description("XPF")]XPF,	
		[Description("NZD")]NZD,	
		[Description("NIO")]NIO,	
		[Description("NGN")]NGN,	
		[Description("NOK")]NOK,	
		[Description("OMR")]OMR,	
		[Description("PKR")]PKR,	
		[Description("PAB")]PAB,	
		[Description("PGK")]PGK,	
		[Description("PYG")]PYG,	
		[Description("PEN")]PEN,	
		[Description("PHP")]PHP,	
		[Description("PLN")]PLN,	
		[Description("USD")]USD,	
		[Description("QAR")]QAR,	
		[Description("ROL")]ROL,	
		[Description("RUB")]RUB,	
		[Description("RUR")]RUR,	
		[Description("RWF")]RWF,	
		[Description("SHP")]SHP,	
		[Description("WST")]WST,	
		[Description("STD")]STD,	
		[Description("SAR")]SAR,	
		[Description("SCR")]SCR,	
		[Description("SLL")]SLL,	
		[Description("SGD")]SGD,	
		[Description("SKK")]SKK,	
		[Description("SIT")]SIT,	
		[Description("SBD")]SBD,	
		[Description("SOS")]SOS,	
		[Description("LKR")]LKR,	
		[Description("SDD")]SDD,	
		[Description("SRG")]SRG,	
		[Description("SZL")]SZL,	
		[Description("SEK")]SEK,	
		[Description("SYP")]SYP,	
		[Description("TWD")]TWD,	
		[Description("TJS")]TJS,	
		[Description("TZS")]TZS,	
		[Description("THB")]THB,	
		[Description("XOF")]XOF,	
		[Description("TOP")]TOP,	
		[Description("TTD")]TTD,	
		[Description("TND")]TND,	
		[Description("TRY")]TRY,	
		[Description("TMM")]TMM,	
		[Description("UGX")]UGX,	
		[Description("UAH")]UAH,	
		[Description("AED")]AED,	
		[Description("GBP")]GBP,	
		[Description("USS")]USS,	
		[Description("USN")]USN,	
		[Description("UYU")]UYU,	
		[Description("UZS")]UZS,	
		[Description("VUV")]VUV,	
		[Description("VEB")]VEB,	
		[Description("VND")]VND,	
		[Description("MAD")]MAD,	
		[Description("YER")]YER,	
		[Description("YUM")]YUM,	
		[Description("ZMK")]ZMK,	
		[Description("ZWD")]ZWD,	
		[Description("CustomCode")]CUSTOMCODE	
	}




	/**
      * DetailLevelCodeType   
      * 
      */
    [Serializable]
	public enum DetailLevelCodeType {
		[Description("ReturnAll")]RETURNALL,	
		[Description("ItemReturnDescription")]ITEMRETURNDESCRIPTION,	
		[Description("ItemReturnAttributes")]ITEMRETURNATTRIBUTES	
	}




	/**
      * This defines if the incentive is applied on Ebay or PayPal.
      *            
      */
    [Serializable]
	public enum IncentiveSiteAppliedOnType {
		[Description("INCENTIVE-SITE-APPLIED-ON-UNKNOWN")]INCENTIVESITEAPPLIEDONUNKNOWN,	
		[Description("INCENTIVE-SITE-APPLIED-ON-MERCHANT")]INCENTIVESITEAPPLIEDONMERCHANT,	
		[Description("INCENTIVE-SITE-APPLIED-ON-PAYPAL")]INCENTIVESITEAPPLIEDONPAYPAL	
	}




	/**
      * This defines if the incentive is applied successfully or
      *not.
      *            
      */
    [Serializable]
	public enum IncentiveAppliedStatusType {
		[Description("INCENTIVE-APPLIED-STATUS-SUCCESS")]INCENTIVEAPPLIEDSTATUSSUCCESS,	
		[Description("INCENTIVE-APPLIED-STATUS-ERROR")]INCENTIVEAPPLIEDSTATUSERROR	
	}




	/**
      * PaymentReasonType
      * This is the Payment Reason type (used by DoRT and SetEC for
      *Refund of PI transaction, eBay return shipment, external
      *dispute)
      * 
      */
    [Serializable]
	public enum PaymentReasonType {
		[Description("None")]NONE,	
		[Description("Refund")]REFUND,	
		[Description("ReturnShipment")]RETURNSHIPMENT	
	}




	/**
      * SeverityCodeType
      *    This code identifies the Severity code types in terms of
      *whether
      *    there is an API-level error or warning that needs to be
      *communicated
      *    to the client.
      * 
      */
    [Serializable]
	public enum SeverityCodeType {
		[Description("Warning")]WARNING,	
		[Description("Error")]ERROR,	
		[Description("PartialSuccess")]PARTIALSUCCESS,	
		[Description("CustomCode")]CUSTOMCODE	
	}




	/**
      * ShippingServiceCodeType
      *      These are the possible codes to describe insurance
      *option as part of shipping
      *      service.
      * 
      */
    [Serializable]
	public enum ShippingServiceCodeType {
		[Description("UPSGround")]UPSGROUND,	
		[Description("UPS3rdDay")]UPSRDDAY,	
		[Description("UPS2ndDay")]UPSNDDAY,	
		[Description("UPSNextDay")]UPSNEXTDAY,	
		[Description("USPSPriority")]USPSPRIORITY,	
		[Description("USPSParcel")]USPSPARCEL,	
		[Description("USPSMedia")]USPSMEDIA,	
		[Description("USPSFirstClass")]USPSFIRSTCLASS,	
		[Description("ShippingMethodStandard")]SHIPPINGMETHODSTANDARD,	
		[Description("ShippingMethodExpress")]SHIPPINGMETHODEXPRESS,	
		[Description("ShippingMethodNextDay")]SHIPPINGMETHODNEXTDAY,	
		[Description("USPSExpressMail")]USPSEXPRESSMAIL,	
		[Description("USPSGround")]USPSGROUND,	
		[Description("Download")]DOWNLOAD,	
		[Description("WillCall_Or_Pickup")]WILLCALLORPICKUP,	
		[Description("CustomCode")]CUSTOMCODE	
	}




	/**
      * Type declaration to be used by other schemas.
      * This is the credit card type
      * 
      */
    [Serializable]
	public enum CreditCardTypeType {
		[Description("Visa")]VISA,	
		[Description("MasterCard")]MASTERCARD,	
		[Description("Discover")]DISCOVER,	
		[Description("Amex")]AMEX,	
		[Description("Switch")]SWITCH,	
		[Description("Solo")]SOLO,	
		[Description("Maestro")]MAESTRO	
	}




	/**
      * RefundType - Type declaration to be used by other 
      * schema. This code identifies the types of refund
      *transactions 
      * supported.
      * 
      */
    [Serializable]
	public enum RefundType {
		[Description("Other")]OTHER,	
		[Description("Full")]FULL,	
		[Description("Partial")]PARTIAL,	
		[Description("ExternalDispute")]EXTERNALDISPUTE	
	}




	/**
      * Based on NRF-ARTS Specification for Units of Measure
      * 
      */
    [Serializable]
	public enum UnitOfMeasure {
		[Description("EA")]EA,	
		[Description("Hours")]HOURS,	
		[Description("Days")]DAYS,	
		[Description("Seconds")]SECONDS,	
		[Description("CrateOf12")]CRATEOF,	
		[Description("6Pack")]PACK,	
		[Description("GLI")]GLI,	
		[Description("GLL")]GLL,	
		[Description("LTR")]LTR,	
		[Description("INH")]INH,	
		[Description("FOT")]FOT,	
		[Description("MMT")]MMT,	
		[Description("CMQ")]CMQ,	
		[Description("MTR")]MTR,	
		[Description("MTK")]MTK,	
		[Description("MTQ")]MTQ,	
		[Description("GRM")]GRM,	
		[Description("KGM")]KGM,	
		[Description("KG")]KG,	
		[Description("LBR")]LBR,	
		[Description("ANN")]ANN,	
		[Description("CEL")]CEL,	
		[Description("FAH")]FAH,	
		[Description("RESERVED")]RESERVED	
	}




	/**
      *
      */
    [Serializable]
	public enum RedeemedOfferType {
		[Description("MERCHANT_COUPON")]MERCHANTCOUPON,	
		[Description("LOYALTY_CARD")]LOYALTYCARD,	
		[Description("MANUFACTURER_COUPON")]MANUFACTURERCOUPON,	
		[Description("RESERVED")]RESERVED	
	}




	/**
      *Supported API Types for DoCancel operation
      */
    [Serializable]
	public enum APIType {
		[Description("CHECKOUT_AUTHORIZATION")]CHECKOUTAUTHORIZATION,	
		[Description("CHECKOUT_SALE")]CHECKOUTSALE	
	}




	/**
      * IncentiveRequestType 
      * This identifies the type of request for the API call. The
      *type of request may be used to determine whether the request
      *is for evaluating incentives in pre-checkout or in-checkout
      *phase.
      * 
      */
    [Serializable]
	public enum IncentiveRequestCodeType {
		[Description("InCheckout")]INCHECKOUT,	
		[Description("PreCheckout")]PRECHECKOUT	
	}




	/**
      * IncentiveRequestDetailLevelType 
      * This identifies the granularity of information requested by
      *the client application. This information will be used to
      *define the contents and details of the response.
      * 
      */
    [Serializable]
	public enum IncentiveRequestDetailLevelCodeType {
		[Description("Aggregated")]AGGREGATED,	
		[Description("Detail")]DETAIL	
	}




	/**
      * IncentiveType 
      * This identifies the type of INCENTIVE for the redemption
      *code.
      * 
      */
    [Serializable]
	public enum IncentiveTypeCodeType {
		[Description("Coupon")]COUPON,	
		[Description("eBayGiftCertificate")]EBAYGIFTCERTIFICATE,	
		[Description("eBayGiftCard")]EBAYGIFTCARD,	
		[Description("PayPalRewardVoucher")]PAYPALREWARDVOUCHER,	
		[Description("MerchantGiftCertificate")]MERCHANTGIFTCERTIFICATE,	
		[Description("eBayRewardVoucher")]EBAYREWARDVOUCHER	
	}




	/**
      * PaymentTransactionCodeType 
      * This is the type of a PayPal of which matches the output
      *from IPN
      * 
      */
    [Serializable]
	public enum PaymentTransactionCodeType {
		[Description("none")]NONE,	
		[Description("web-accept")]WEBACCEPT,	
		[Description("cart")]CART,	
		[Description("send-money")]SENDMONEY,	
		[Description("subscr-failed")]SUBSCRFAILED,	
		[Description("subscr-cancel")]SUBSCRCANCEL,	
		[Description("subscr-payment")]SUBSCRPAYMENT,	
		[Description("subscr-signup")]SUBSCRSIGNUP,	
		[Description("subscr-eot")]SUBSCREOT,	
		[Description("subscr-modify")]SUBSCRMODIFY,	
		[Description("mercht-pmt")]MERCHTPMT,	
		[Description("mass-pay")]MASSPAY,	
		[Description("virtual-terminal")]VIRTUALTERMINAL,	
		[Description("integral-evolution")]INTEGRALEVOLUTION,	
		[Description("express-checkout")]EXPRESSCHECKOUT,	
		[Description("pro-hosted")]PROHOSTED,	
		[Description("pro-api")]PROAPI,	
		[Description("credit")]CREDIT	
	}




	/**
      * PaymentStatusCodeType 
      * This is the status of a PayPal Payment which matches the
      *output from IPN
      * 
      */
    [Serializable]
	public enum PaymentStatusCodeType {
		[Description("None")]NONE,	
		[Description("Completed")]COMPLETED,	
		[Description("Failed")]FAILED,	
		[Description("Pending")]PENDING,	
		[Description("Denied")]DENIED,	
		[Description("Refunded")]REFUNDED,	
		[Description("Reversed")]REVERSED,	
		[Description("Canceled-Reversal")]CANCELEDREVERSAL,	
		[Description("Processed")]PROCESSED,	
		[Description("Partially-Refunded")]PARTIALLYREFUNDED,	
		[Description("Voided")]VOIDED,	
		[Description("Expired")]EXPIRED,	
		[Description("In-Progress")]INPROGRESS,	
		[Description("Created")]CREATED,	
		[Description("Completed-Funds-Held")]COMPLETEDFUNDSHELD,	
		[Description("Instant")]INSTANT,	
		[Description("Delayed")]DELAYED	
	}




	/**
      * AddressStatusCodeType 
      * This is the PayPal address status
      * 
      */
    [Serializable]
	public enum AddressStatusCodeType {
		[Description("None")]NONE,	
		[Description("Confirmed")]CONFIRMED,	
		[Description("Unconfirmed")]UNCONFIRMED	
	}




	/**
      * Normalization Status of the Address
      * 
      */
    [Serializable]
	public enum AddressNormalizationStatusCodeType {
		[Description("None")]NONE,	
		[Description("Normalized")]NORMALIZED,	
		[Description("Unnormalized")]UNNORMALIZED	
	}




	/**
      * PaymentDetailsCodeType 
      * This is the PayPal payment details type (used by DCC and
      *Express Checkout)
      * 
      */
    [Serializable]
	public enum PaymentActionCodeType {
		[Description("None")]NONE,	
		[Description("Authorization")]AUTHORIZATION,	
		[Description("Sale")]SALE,	
		[Description("Order")]ORDER	
	}




	/**
      * This is various actions that a merchant can take on a FMF
      *Pending Transaction.
      * 
      */
    [Serializable]
	public enum FMFPendingTransactionActionType {
		[Description("Accept")]ACCEPT,	
		[Description("Deny")]DENY	
	}




	/**
      * ChannelType - Type declaration to be used by other schemas.
      * This is the PayPal Channel type (used by Express Checkout)
      * 
      */
    [Serializable]
	public enum ChannelType {
		[Description("Merchant")]MERCHANT,	
		[Description("eBayItem")]EBAYITEM	
	}




	/**
      * TotalType - Type declaration for the label to be displayed
      * in MiniCart for UX.
      * 
      */
    [Serializable]
	public enum TotalType {
		[Description("Total")]TOTAL,	
		[Description("EstimatedTotal")]ESTIMATEDTOTAL	
	}




	/**
      * SolutionTypeType 
      * This is the PayPal payment Solution details type (used by
      *Express Checkout)
      * 
      */
    [Serializable]
	public enum SolutionTypeType {
		[Description("Mark")]MARK,	
		[Description("Sole")]SOLE	
	}




	/**
      * AllowedPaymentMethodType
      * This is the payment Solution merchant needs to specify for
      *Autopay (used by Express Checkout)
      * Optional
      * Default indicates that its merchant supports all funding
      *source
      * InstantPaymentOnly indicates that its merchant only
      *supports instant payment
      * AnyFundingSource allow all funding methods to be chosen by
      *the buyer irrespective of merchant's profile setting
      * InstantFundingSource allow only instant funding methods,
      *block echeck, meft, elevecheck. This will override any
      *merchant profile setting
      * 
      */
    [Serializable]
	public enum AllowedPaymentMethodType {
		[Description("Default")]DEFAULT,	
		[Description("InstantPaymentOnly")]INSTANTPAYMENTONLY,	
		[Description("AnyFundingSource")]ANYFUNDINGSOURCE,	
		[Description("InstantFundingSource")]INSTANTFUNDINGSOURCE	
	}




	/**
      * LandingPageType 
      * This is the PayPal payment Landing Page details type (used
      *by Express Checkout)
      * 
      */
    [Serializable]
	public enum LandingPageType {
		[Description("None")]NONE,	
		[Description("Login")]LOGIN,	
		[Description("Billing")]BILLING	
	}




	/**
      * 
      */
    [Serializable]
	public enum BillingCodeType {
		[Description("None")]NONE,	
		[Description("MerchantInitiatedBilling")]MERCHANTINITIATEDBILLING,	
		[Description("RecurringPayments")]RECURRINGPAYMENTS,	
		[Description("MerchantInitiatedBillingSingleAgreement")]MERCHANTINITIATEDBILLINGSINGLEAGREEMENT,	
		[Description("ChannelInitiatedBilling")]CHANNELINITIATEDBILLING	
	}




	/**
      * 
      */
    [Serializable]
	public enum ApprovalTypeType {
		[Description("BillingAgreement")]BILLINGAGREEMENT,	
		[Description("Profile")]PROFILE	
	}




	/**
      * 
      */
    [Serializable]
	public enum ApprovalSubTypeType {
		[Description("None")]NONE,	
		[Description("MerchantInitiatedBilling")]MERCHANTINITIATEDBILLING,	
		[Description("MerchantInitiatedBillingSingleAgreement")]MERCHANTINITIATEDBILLINGSINGLEAGREEMENT,	
		[Description("ChannelInitiatedBilling")]CHANNELINITIATEDBILLING	
	}




	/**
      * PendingStatusCodeType 
      * The pending status for a PayPal Payment transaction which
      *matches the output from IPN
      * 
      */
    [Serializable]
	public enum PendingStatusCodeType {
		[Description("none")]NONE,	
		[Description("echeck")]ECHECK,	
		[Description("intl")]INTL,	
		[Description("verify")]VERIFY,	
		[Description("address")]ADDRESS,	
		[Description("unilateral")]UNILATERAL,	
		[Description("other")]OTHER,	
		[Description("upgrade")]UPGRADE,	
		[Description("multi-currency")]MULTICURRENCY,	
		[Description("authorization")]AUTHORIZATION,	
		[Description("order")]ORDER,	
		[Description("payment-review")]PAYMENTREVIEW,	
		[Description("regulatory-review")]REGULATORYREVIEW	
	}




	/**
      * ReceiverInfoCodeType 
      * Payee identifier type for MassPay API
      * 
      */
    [Serializable]
	public enum ReceiverInfoCodeType {
		[Description("EmailAddress")]EMAILADDRESS,	
		[Description("UserID")]USERID,	
		[Description("PhoneNumber")]PHONENUMBER	
	}




	/**
      * ReversalReasonCodeType 
      * Reason for a reversal on a PayPal transaction which matches
      *the output from IPN
      * 
      */
    [Serializable]
	public enum ReversalReasonCodeType {
		[Description("none")]NONE,	
		[Description("chargeback")]CHARGEBACK,	
		[Description("guarantee")]GUARANTEE,	
		[Description("buyer-complaint")]BUYERCOMPLAINT,	
		[Description("refund")]REFUND,	
		[Description("other")]OTHER	
	}




	/**
      * POSTransactionCodeType
      * POS Transaction Code Type. F for Forced Post Transaction
      *and S for Single Call Checkout
      * 
      */
    [Serializable]
	public enum POSTransactionCodeType {
		[Description("F")]F,	
		[Description("S")]S	
	}




	/**
      * PaymentCodeType 
      * This is the type of PayPal payment which matches the output
      *from IPN.
      * 
      */
    [Serializable]
	public enum PaymentCodeType {
		[Description("none")]NONE,	
		[Description("echeck")]ECHECK,	
		[Description("instant")]INSTANT	
	}




	/**
      * RefundSourceCodeType
      * This is the type of PayPal funding source that can be used
      *for auto refund.
      * any - Means Merchant doesn't have any preference. PayPal
      *can use any available funding source (Balance or eCheck)
      * default - Means merchant's preferred funding source as
      *configured in his profile. (Balance or eCheck)
      * instant - Only Balance
      * echeck - Merchant prefers echeck. If PayPal balance can
      *cover the refund amount, we will use PayPal balance.
      *(balance or eCheck)
      * 
      */
    [Serializable]
	public enum RefundSourceCodeType {
		[Description("any")]ANY,	
		[Description("default")]DEFAULT,	
		[Description("instant")]INSTANT,	
		[Description("echeck")]ECHECK	
	}




	/**
      * PayPalUserStatusCodeType 
      * PayPal status of a user Address
      * 
      */
    [Serializable]
	public enum PayPalUserStatusCodeType {
		[Description("verified")]VERIFIED,	
		[Description("unverified")]UNVERIFIED	
	}




	/**
      * MerchantPullPaymentCodeType 
      * Type of Payment to be initiated by the merchant
      * 
      */
    [Serializable]
	public enum MerchantPullPaymentCodeType {
		[Description("Any")]ANY,	
		[Description("InstantOnly")]INSTANTONLY,	
		[Description("EcheckOnly")]ECHECKONLY	
	}




	/**
      * MerchantPullStatusCodeType 
      * Status of the merchant pull
      * 
      */
    [Serializable]
	public enum MerchantPullStatusCodeType {
		[Description("Active")]ACTIVE,	
		[Description("Canceled")]CANCELED	
	}




	/**
      * PaymentTransactionStatusCodeType 
      * The status of the PayPal payment.
      * 
      */
    [Serializable]
	public enum PaymentTransactionStatusCodeType {
		[Description("Pending")]PENDING,	
		[Description("Processing")]PROCESSING,	
		[Description("Success")]SUCCESS,	
		[Description("Denied")]DENIED,	
		[Description("Reversed")]REVERSED	
	}




	/**
      * PaymentTransactionClassCodeType 
      * The Type of PayPal payment.
      * 
      */
    [Serializable]
	public enum PaymentTransactionClassCodeType {
		[Description("All")]ALL,	
		[Description("Sent")]SENT,	
		[Description("Received")]RECEIVED,	
		[Description("MassPay")]MASSPAY,	
		[Description("MoneyRequest")]MONEYREQUEST,	
		[Description("FundsAdded")]FUNDSADDED,	
		[Description("FundsWithdrawn")]FUNDSWITHDRAWN,	
		[Description("PayPalDebitCard")]PAYPALDEBITCARD,	
		[Description("Referral")]REFERRAL,	
		[Description("Fee")]FEE,	
		[Description("Subscription")]SUBSCRIPTION,	
		[Description("Dividend")]DIVIDEND,	
		[Description("Billpay")]BILLPAY,	
		[Description("Refund")]REFUND,	
		[Description("CurrencyConversions")]CURRENCYCONVERSIONS,	
		[Description("BalanceTransfer")]BALANCETRANSFER,	
		[Description("Reversal")]REVERSAL,	
		[Description("Shipping")]SHIPPING,	
		[Description("BalanceAffecting")]BALANCEAFFECTING,	
		[Description("ECheck")]ECHECK,	
		[Description("ForcedPostTransaction")]FORCEDPOSTTRANSACTION,	
		[Description("NonReferencedRefunds")]NONREFERENCEDREFUNDS	
	}




	/**
      * MatchStatusCodeType 
      * This is the PayPal (street/zip) match code
      * 
      */
    [Serializable]
	public enum MatchStatusCodeType {
		[Description("None")]NONE,	
		[Description("Matched")]MATCHED,	
		[Description("Unmatched")]UNMATCHED	
	}




	/**
      * CompleteCodeType 
      * This is the PayPal DoCapture CompleteType code
      * 
      */
    [Serializable]
	public enum CompleteCodeType {
		[Description("NotComplete")]NOTCOMPLETE,	
		[Description("Complete")]COMPLETE	
	}




	/**
      * TransactionEntityType 
      * This is the PayPal DoAuthorization TransactionEntityType
      *code
      * 
      */
    [Serializable]
	public enum TransactionEntityType {
		[Description("None")]NONE,	
		[Description("Auth")]AUTH,	
		[Description("Reauth")]REAUTH,	
		[Description("Order")]ORDER,	
		[Description("Payment")]PAYMENT	
	}




	/**
      * MobileRecipientCodeType 
      * These are the accepted types of recipients for
      *mobile-originated transactions
      * 
      */
    [Serializable]
	public enum MobileRecipientCodeType {
		[Description("PhoneNumber")]PHONENUMBER,	
		[Description("EmailAddress")]EMAILADDRESS	
	}




	/**
      * MobilePaymentCodeType 
      * These are the accepted types of mobile payments
      * 
      */
    [Serializable]
	public enum MobilePaymentCodeType {
		[Description("P2P")]PP,	
		[Description("HardGoods")]HARDGOODS,	
		[Description("Donation")]DONATION,	
		[Description("TopUp")]TOPUP	
	}




	/**
      * MarketingCategoryType 
      * 
      */
    [Serializable]
	public enum MarketingCategoryType {
		[Description("Marketing-Category-Default")]MARKETINGCATEGORYDEFAULT,	
		[Description("Marketing-Category1")]MARKETINGCATEGORY1,	
		[Description("Marketing-Category2")]MARKETINGCATEGORY2,	
		[Description("Marketing-Category3")]MARKETINGCATEGORY3,	
		[Description("Marketing-Category4")]MARKETINGCATEGORY4,	
		[Description("Marketing-Category5")]MARKETINGCATEGORY5,	
		[Description("Marketing-Category6")]MARKETINGCATEGORY6,	
		[Description("Marketing-Category7")]MARKETINGCATEGORY7,	
		[Description("Marketing-Category8")]MARKETINGCATEGORY8,	
		[Description("Marketing-Category9")]MARKETINGCATEGORY9,	
		[Description("Marketing-Category10")]MARKETINGCATEGORY10,	
		[Description("Marketing-Category11")]MARKETINGCATEGORY11,	
		[Description("Marketing-Category12")]MARKETINGCATEGORY12,	
		[Description("Marketing-Category13")]MARKETINGCATEGORY13,	
		[Description("Marketing-Category14")]MARKETINGCATEGORY14,	
		[Description("Marketing-Category15")]MARKETINGCATEGORY15,	
		[Description("Marketing-Category16")]MARKETINGCATEGORY16,	
		[Description("Marketing-Category17")]MARKETINGCATEGORY17,	
		[Description("Marketing-Category18")]MARKETINGCATEGORY18,	
		[Description("Marketing-Category19")]MARKETINGCATEGORY19,	
		[Description("Marketing-Category20")]MARKETINGCATEGORY20	
	}




	/**
      * BusinessTypeType
      * 
      */
    [Serializable]
	public enum BusinessTypeType {
		[Description("Unknown")]UNKNOWN,	
		[Description("Individual")]INDIVIDUAL,	
		[Description("Proprietorship")]PROPRIETORSHIP,	
		[Description("Partnership")]PARTNERSHIP,	
		[Description("Corporation")]CORPORATION,	
		[Description("Nonprofit")]NONPROFIT,	
		[Description("Government")]GOVERNMENT	
	}




	/**
      * BusinessCategoryType 
      * 
      */
    [Serializable]
	public enum BusinessCategoryType {
		[Description("Category-Unspecified")]CATEGORYUNSPECIFIED,	
		[Description("Antiques")]ANTIQUES,	
		[Description("Arts")]ARTS,	
		[Description("Automotive")]AUTOMOTIVE,	
		[Description("Beauty")]BEAUTY,	
		[Description("Books")]BOOKS,	
		[Description("Business")]BUSINESS,	
		[Description("Cameras-and-Photography")]CAMERASANDPHOTOGRAPHY,	
		[Description("Clothing")]CLOTHING,	
		[Description("Collectibles")]COLLECTIBLES,	
		[Description("Computer-Hardware-and-Software")]COMPUTERHARDWAREANDSOFTWARE,	
		[Description("Culture-and-Religion")]CULTUREANDRELIGION,	
		[Description("Electronics-and-Telecom")]ELECTRONICSANDTELECOM,	
		[Description("Entertainment")]ENTERTAINMENT,	
		[Description("Entertainment-Memorabilia")]ENTERTAINMENTMEMORABILIA,	
		[Description("Food-Drink-and-Nutrition")]FOODDRINKANDNUTRITION,	
		[Description("Gifts-and-Flowers")]GIFTSANDFLOWERS,	
		[Description("Hobbies-Toys-and-Games")]HOBBIESTOYSANDGAMES,	
		[Description("Home-and-Garden")]HOMEANDGARDEN,	
		[Description("Internet-and-Network-Services")]INTERNETANDNETWORKSERVICES,	
		[Description("Media-and-Entertainment")]MEDIAANDENTERTAINMENT,	
		[Description("Medical-and-Pharmaceutical")]MEDICALANDPHARMACEUTICAL,	
		[Description("Money-Service-Businesses")]MONEYSERVICEBUSINESSES,	
		[Description("Non-Profit-Political-and-Religion")]NONPROFITPOLITICALANDRELIGION,	
		[Description("Not-Elsewhere-Classified")]NOTELSEWHERECLASSIFIED,	
		[Description("Pets-and-Animals")]PETSANDANIMALS,	
		[Description("Real-Estate")]REALESTATE,	
		[Description("Services")]SERVICES,	
		[Description("Sports-and-Recreation")]SPORTSANDRECREATION,	
		[Description("Travel")]TRAVEL,	
		[Description("Other-Categories")]OTHERCATEGORIES	
	}




	/**
      * BusinessSubCategoryType 
      * 
      */
    [Serializable]
	public enum BusinessSubCategoryType {
		[Description("SubCategory-Unspecified")]SUBCATEGORYUNSPECIFIED,	
		[Description("ANTIQUES-General")]ANTIQUESGENERAL,	
		[Description("ANTIQUES-Antiquities")]ANTIQUESANTIQUITIES,	
		[Description("ANTIQUES-Decorative")]ANTIQUESDECORATIVE,	
		[Description("ANTIQUES-Books-Manuscripts")]ANTIQUESBOOKSMANUSCRIPTS,	
		[Description("ANTIQUES-Furniture")]ANTIQUESFURNITURE,	
		[Description("ANTIQUES-Glass")]ANTIQUESGLASS,	
		[Description("ANTIQUES-RugsCarpets")]ANTIQUESRUGSCARPETS,	
		[Description("ANTIQUES-Pottery")]ANTIQUESPOTTERY,	
		[Description("ANTIQUES-Cultural")]ANTIQUESCULTURAL,	
		[Description("ANTIQUES-Artifacts-Grave-related-and-Native-American-Crafts")]ANTIQUESARTIFACTSGRAVERELATEDANDNATIVEAMERICANCRAFTS,	
		[Description("ARTSANDCRAFTS-General")]ARTSANDCRAFTSGENERAL,	
		[Description("ARTSANDCRAFTS-Art-Dealer-and-Galleries")]ARTSANDCRAFTSARTDEALERANDGALLERIES,	
		[Description("ARTSANDCRAFTS-Prints")]ARTSANDCRAFTSPRINTS,	
		[Description("ARTSANDCRAFTS-Painting")]ARTSANDCRAFTSPAINTING,	
		[Description("ARTSANDCRAFTS-Photography")]ARTSANDCRAFTSPHOTOGRAPHY,	
		[Description("ARTSANDCRAFTS-Reproductions")]ARTSANDCRAFTSREPRODUCTIONS,	
		[Description("ARTSANDCRAFTS-Sculptures")]ARTSANDCRAFTSSCULPTURES,	
		[Description("ARTSANDCRAFTS-Woodworking")]ARTSANDCRAFTSWOODWORKING,	
		[Description("ARTSANDCRAFTS-Art-and-Craft-Supplies")]ARTSANDCRAFTSARTANDCRAFTSUPPLIES,	
		[Description("ARTSANDCRAFTS-Fabrics-and-Sewing")]ARTSANDCRAFTSFABRICSANDSEWING,	
		[Description("ARTSANDCRAFTS-Quilting")]ARTSANDCRAFTSQUILTING,	
		[Description("ARTSANDCRAFTS-Scrapbooking")]ARTSANDCRAFTSSCRAPBOOKING,	
		[Description("AUTOMOTIVE-General")]AUTOMOTIVEGENERAL,	
		[Description("AUTOMOTIVE-Autos")]AUTOMOTIVEAUTOS,	
		[Description("AUTOMOTIVE-Aviation")]AUTOMOTIVEAVIATION,	
		[Description("AUTOMOTIVE-Motorcycles")]AUTOMOTIVEMOTORCYCLES,	
		[Description("AUTOMOTIVE-Parts-and-Supplies")]AUTOMOTIVEPARTSANDSUPPLIES,	
		[Description("AUTOMOTIVE-Services")]AUTOMOTIVESERVICES,	
		[Description("AUTOMOTIVE-Vintage-and-Collectible-Vehicles")]AUTOMOTIVEVINTAGEANDCOLLECTIBLEVEHICLES,	
		[Description("BEAUTY-General")]BEAUTYGENERAL,	
		[Description("BEAUTY-Body-Care-Personal-Hygiene")]BEAUTYBODYCAREPERSONALHYGIENE,	
		[Description("BEAUTY-Fragrances-and-Perfumes")]BEAUTYFRAGRANCESANDPERFUMES,	
		[Description("BEAUTY-Makeup")]BEAUTYMAKEUP,	
		[Description("BOOKS-General")]BOOKSGENERAL,	
		[Description("BOOKS-Audio-Books")]BOOKSAUDIOBOOKS,	
		[Description("BOOKS-Children-Books")]BOOKSCHILDRENBOOKS,	
		[Description("BOOKS-Computer-Books")]BOOKSCOMPUTERBOOKS,	
		[Description("BOOKS-Educational-and-Textbooks")]BOOKSEDUCATIONALANDTEXTBOOKS,	
		[Description("BOOKS-Magazines")]BOOKSMAGAZINES,	
		[Description("BOOKS-Fiction-and-Literature")]BOOKSFICTIONANDLITERATURE,	
		[Description("BOOKS-NonFiction")]BOOKSNONFICTION,	
		[Description("BOOKS-Vintage-and-Collectibles")]BOOKSVINTAGEANDCOLLECTIBLES,	
		[Description("BUSINESS-General")]BUSINESSGENERAL,	
		[Description("BUSINESS-Agricultural")]BUSINESSAGRICULTURAL,	
		[Description("BUSINESS-Construction")]BUSINESSCONSTRUCTION,	
		[Description("BUSINESS-Educational")]BUSINESSEDUCATIONAL,	
		[Description("BUSINESS-Industrial")]BUSINESSINDUSTRIAL,	
		[Description("BUSINESS-Office-Supplies-and-Equipment")]BUSINESSOFFICESUPPLIESANDEQUIPMENT,	
		[Description("BUSINESS-GeneralServices")]BUSINESSGENERALSERVICES,	
		[Description("BUSINESS-Advertising")]BUSINESSADVERTISING,	
		[Description("BUSINESS-Employment")]BUSINESSEMPLOYMENT,	
		[Description("BUSINESS-Marketing")]BUSINESSMARKETING,	
		[Description("BUSINESS-Meeting-Planners")]BUSINESSMEETINGPLANNERS,	
		[Description("BUSINESS-Messaging-and-Paging-Services")]BUSINESSMESSAGINGANDPAGINGSERVICES,	
		[Description("BUSINESS-Seminars")]BUSINESSSEMINARS,	
		[Description("BUSINESS-Publishing")]BUSINESSPUBLISHING,	
		[Description("BUSINESS-Shipping-and-Packaging")]BUSINESSSHIPPINGANDPACKAGING,	
		[Description("BUSINESS-Wholesale")]BUSINESSWHOLESALE,	
		[Description("BUSINESS-Industrial-Solvents")]BUSINESSINDUSTRIALSOLVENTS,	
		[Description("CAMERASANDPHOTOGRAPHY-General")]CAMERASANDPHOTOGRAPHYGENERAL,	
		[Description("CAMERASANDPHOTOGRAPHY-Accessories")]CAMERASANDPHOTOGRAPHYACCESSORIES,	
		[Description("CAMERASANDPHOTOGRAPHY-Cameras")]CAMERASANDPHOTOGRAPHYCAMERAS,	
		[Description("CAMERASANDPHOTOGRAPHY-Video-Equipment")]CAMERASANDPHOTOGRAPHYVIDEOEQUIPMENT,	
		[Description("CAMERASANDPHOTOGRAPHY-Film")]CAMERASANDPHOTOGRAPHYFILM,	
		[Description("CAMERASANDPHOTOGRAPHY-Supplies")]CAMERASANDPHOTOGRAPHYSUPPLIES,	
		[Description("CLOTHING-Accessories")]CLOTHINGACCESSORIES,	
		[Description("CLOTHING-Babies-Clothing-and-Supplies")]CLOTHINGBABIESCLOTHINGANDSUPPLIES,	
		[Description("CLOTHING-Childrens-Clothing")]CLOTHINGCHILDRENSCLOTHING,	
		[Description("CLOTHING-Mens-Clothing")]CLOTHINGMENSCLOTHING,	
		[Description("CLOTHING-Shoes")]CLOTHINGSHOES,	
		[Description("CLOTHING-Wedding-Clothing")]CLOTHINGWEDDINGCLOTHING,	
		[Description("CLOTHING-Womens-Clothing")]CLOTHINGWOMENSCLOTHING,	
		[Description("CLOTHING-General")]CLOTHINGGENERAL,	
		[Description("CLOTHING-Jewelry")]CLOTHINGJEWELRY,	
		[Description("CLOTHING-Watches-and-Clocks")]CLOTHINGWATCHESANDCLOCKS,	
		[Description("CLOTHING-Rings")]CLOTHINGRINGS,	
		[Description("COLLECTIBLES-General")]COLLECTIBLESGENERAL,	
		[Description("COLLECTIBLES-Advertising")]COLLECTIBLESADVERTISING,	
		[Description("COLLECTIBLES-Animals")]COLLECTIBLESANIMALS,	
		[Description("COLLECTIBLES-Animation")]COLLECTIBLESANIMATION,	
		[Description("COLLECTIBLES-Coin-Operated-Banks-and-Casinos")]COLLECTIBLESCOINOPERATEDBANKSANDCASINOS,	
		[Description("COLLECTIBLES-Coins-and-Paper-Money")]COLLECTIBLESCOINSANDPAPERMONEY,	
		[Description("COLLECTIBLES-Comics")]COLLECTIBLESCOMICS,	
		[Description("COLLECTIBLES-Decorative")]COLLECTIBLESDECORATIVE,	
		[Description("COLLECTIBLES-Disneyana")]COLLECTIBLESDISNEYANA,	
		[Description("COLLECTIBLES-Holiday")]COLLECTIBLESHOLIDAY,	
		[Description("COLLECTIBLES-Knives-and-Swords")]COLLECTIBLESKNIVESANDSWORDS,	
		[Description("COLLECTIBLES-Militaria")]COLLECTIBLESMILITARIA,	
		[Description("COLLECTIBLES-Postcards-and-Paper")]COLLECTIBLESPOSTCARDSANDPAPER,	
		[Description("COLLECTIBLES-Stamps")]COLLECTIBLESSTAMPS,	
		[Description("COMPUTERHARDWAREANDSOFTWARE-General")]COMPUTERHARDWAREANDSOFTWAREGENERAL,	
		[Description("COMPUTERHARDWAREANDSOFTWARE-Desktop-PCs")]COMPUTERHARDWAREANDSOFTWAREDESKTOPPCS,	
		[Description("COMPUTERHARDWAREANDSOFTWARE-Monitors")]COMPUTERHARDWAREANDSOFTWAREMONITORS,	
		[Description("COMPUTERHARDWAREANDSOFTWARE-Hardware")]COMPUTERHARDWAREANDSOFTWAREHARDWARE,	
		[Description("COMPUTERHARDWAREANDSOFTWARE-Peripherals")]COMPUTERHARDWAREANDSOFTWAREPERIPHERALS,	
		[Description("COMPUTERHARDWAREANDSOFTWARE-Laptops-Notebooks-PDAs")]COMPUTERHARDWAREANDSOFTWARELAPTOPSNOTEBOOKSPDAS,	
		[Description("COMPUTERHARDWAREANDSOFTWARE-Networking-Equipment")]COMPUTERHARDWAREANDSOFTWARENETWORKINGEQUIPMENT,	
		[Description("COMPUTERHARDWAREANDSOFTWARE-Parts-and-Accessories")]COMPUTERHARDWAREANDSOFTWAREPARTSANDACCESSORIES,	
		[Description("COMPUTERHARDWAREANDSOFTWARE-GeneralSoftware")]COMPUTERHARDWAREANDSOFTWAREGENERALSOFTWARE,	
		[Description("COMPUTERHARDWAREANDSOFTWARE-Oem-Software")]COMPUTERHARDWAREANDSOFTWAREOEMSOFTWARE,	
		[Description("COMPUTERHARDWAREANDSOFTWARE-Academic-Software")]COMPUTERHARDWAREANDSOFTWAREACADEMICSOFTWARE,	
		[Description("COMPUTERHARDWAREANDSOFTWARE-Beta-Software")]COMPUTERHARDWAREANDSOFTWAREBETASOFTWARE,	
		[Description("COMPUTERHARDWAREANDSOFTWARE-Game-Software")]COMPUTERHARDWAREANDSOFTWAREGAMESOFTWARE,	
		[Description("COMPUTERHARDWAREANDSOFTWARE-Data-Processing-Svc")]COMPUTERHARDWAREANDSOFTWAREDATAPROCESSINGSVC,	
		[Description("CULTUREANDRELIGION-General")]CULTUREANDRELIGIONGENERAL,	
		[Description("CULTUREANDRELIGION-Christianity")]CULTUREANDRELIGIONCHRISTIANITY,	
		[Description("CULTUREANDRELIGION-Metaphysical")]CULTUREANDRELIGIONMETAPHYSICAL,	
		[Description("CULTUREANDRELIGION-New-Age")]CULTUREANDRELIGIONNEWAGE,	
		[Description("CULTUREANDRELIGION-Organizations")]CULTUREANDRELIGIONORGANIZATIONS,	
		[Description("CULTUREANDRELIGION-Other-Faiths")]CULTUREANDRELIGIONOTHERFAITHS,	
		[Description("CULTUREANDRELIGION-Collectibles")]CULTUREANDRELIGIONCOLLECTIBLES,	
		[Description("ELECTRONICSANDTELECOM-GeneralTelecom")]ELECTRONICSANDTELECOMGENERALTELECOM,	
		[Description("ELECTRONICSANDTELECOM-Cell-Phones-and-Pagers")]ELECTRONICSANDTELECOMCELLPHONESANDPAGERS,	
		[Description("ELECTRONICSANDTELECOM-Telephone-Cards")]ELECTRONICSANDTELECOMTELEPHONECARDS,	
		[Description("ELECTRONICSANDTELECOM-Telephone-Equipment")]ELECTRONICSANDTELECOMTELEPHONEEQUIPMENT,	
		[Description("ELECTRONICSANDTELECOM-Telephone-Services")]ELECTRONICSANDTELECOMTELEPHONESERVICES,	
		[Description("ELECTRONICSANDTELECOM-GeneralElectronics")]ELECTRONICSANDTELECOMGENERALELECTRONICS,	
		[Description("ELECTRONICSANDTELECOM-Car-Audio-and-Electronics")]ELECTRONICSANDTELECOMCARAUDIOANDELECTRONICS,	
		[Description("ELECTRONICSANDTELECOM-Home-Electronics")]ELECTRONICSANDTELECOMHOMEELECTRONICS,	
		[Description("ELECTRONICSANDTELECOM-Home-Audio")]ELECTRONICSANDTELECOMHOMEAUDIO,	
		[Description("ELECTRONICSANDTELECOM-Gadgets-and-other-electronics")]ELECTRONICSANDTELECOMGADGETSANDOTHERELECTRONICS,	
		[Description("ELECTRONICSANDTELECOM-Batteries")]ELECTRONICSANDTELECOMBATTERIES,	
		[Description("ELECTRONICSANDTELECOM-ScannersRadios")]ELECTRONICSANDTELECOMSCANNERSRADIOS,	
		[Description("ELECTRONICSANDTELECOM-Radar-Dectors")]ELECTRONICSANDTELECOMRADARDECTORS,	
		[Description("ELECTRONICSANDTELECOM-Radar-Jamming-Devices")]ELECTRONICSANDTELECOMRADARJAMMINGDEVICES,	
		[Description("ELECTRONICSANDTELECOM-Satellite-and-Cable-TV-Descramblers")]ELECTRONICSANDTELECOMSATELLITEANDCABLETVDESCRAMBLERS,	
		[Description("ELECTRONICSANDTELECOM-Surveillance-Equipment")]ELECTRONICSANDTELECOMSURVEILLANCEEQUIPMENT,	
		[Description("ENTERTAINMENT-General")]ENTERTAINMENTGENERAL,	
		[Description("ENTERTAINMENT-Movies")]ENTERTAINMENTMOVIES,	
		[Description("ENTERTAINMENT-Music")]ENTERTAINMENTMUSIC,	
		[Description("ENTERTAINMENT-Concerts")]ENTERTAINMENTCONCERTS,	
		[Description("ENTERTAINMENT-Theater")]ENTERTAINMENTTHEATER,	
		[Description("ENTERTAINMENT-Bootleg-Recordings")]ENTERTAINMENTBOOTLEGRECORDINGS,	
		[Description("ENTERTAINMENT-Promotional-Items")]ENTERTAINMENTPROMOTIONALITEMS,	
		[Description("ENTERTAINMENTMEMORABILIA-General")]ENTERTAINMENTMEMORABILIAGENERAL,	
		[Description("ENTERTAINMENTMEMORABILIA-Autographs")]ENTERTAINMENTMEMORABILIAAUTOGRAPHS,	
		[Description("ENTERTAINMENTMEMORABILIA-Limited-Editions")]ENTERTAINMENTMEMORABILIALIMITEDEDITIONS,	
		[Description("ENTERTAINMENTMEMORABILIA-Movie")]ENTERTAINMENTMEMORABILIAMOVIE,	
		[Description("ENTERTAINMENTMEMORABILIA-Music")]ENTERTAINMENTMEMORABILIAMUSIC,	
		[Description("ENTERTAINMENTMEMORABILIA-Novelties")]ENTERTAINMENTMEMORABILIANOVELTIES,	
		[Description("ENTERTAINMENTMEMORABILIA-Photos")]ENTERTAINMENTMEMORABILIAPHOTOS,	
		[Description("ENTERTAINMENTMEMORABILIA-Posters")]ENTERTAINMENTMEMORABILIAPOSTERS,	
		[Description("ENTERTAINMENTMEMORABILIA-Sports-and-Fan-Shop")]ENTERTAINMENTMEMORABILIASPORTSANDFANSHOP,	
		[Description("ENTERTAINMENTMEMORABILIA-Science-Fiction")]ENTERTAINMENTMEMORABILIASCIENCEFICTION,	
		[Description("FOODDRINKANDNUTRITION-General")]FOODDRINKANDNUTRITIONGENERAL,	
		[Description("FOODDRINKANDNUTRITION-Coffee-and-Tea")]FOODDRINKANDNUTRITIONCOFFEEANDTEA,	
		[Description("FOODDRINKANDNUTRITION-Food-Products")]FOODDRINKANDNUTRITIONFOODPRODUCTS,	
		[Description("FOODDRINKANDNUTRITION-Gourmet-Items")]FOODDRINKANDNUTRITIONGOURMETITEMS,	
		[Description("FOODDRINKANDNUTRITION-Health-and-Nutrition")]FOODDRINKANDNUTRITIONHEALTHANDNUTRITION,	
		[Description("FOODDRINKANDNUTRITION-Services")]FOODDRINKANDNUTRITIONSERVICES,	
		[Description("FOODDRINKANDNUTRITION-Vitamins-and-Supplements")]FOODDRINKANDNUTRITIONVITAMINSANDSUPPLEMENTS,	
		[Description("FOODDRINKANDNUTRITION-Weight-Management-and-Health-Products")]FOODDRINKANDNUTRITIONWEIGHTMANAGEMENTANDHEALTHPRODUCTS,	
		[Description("FOODDRINKANDNUTRITION-Restaurant")]FOODDRINKANDNUTRITIONRESTAURANT,	
		[Description("FOODDRINKANDNUTRITION-Tobacco-and-Cigars")]FOODDRINKANDNUTRITIONTOBACCOANDCIGARS,	
		[Description("FOODDRINKANDNUTRITION-Alcoholic-Beverages")]FOODDRINKANDNUTRITIONALCOHOLICBEVERAGES,	
		[Description("GIFTSANDFLOWERS-General")]GIFTSANDFLOWERSGENERAL,	
		[Description("GIFTSANDFLOWERS-Flowers")]GIFTSANDFLOWERSFLOWERS,	
		[Description("GIFTSANDFLOWERS-Greeting-Cards")]GIFTSANDFLOWERSGREETINGCARDS,	
		[Description("GIFTSANDFLOWERS-Humorous-Gifts-and-Novelties")]GIFTSANDFLOWERSHUMOROUSGIFTSANDNOVELTIES,	
		[Description("GIFTSANDFLOWERS-Personalized-Gifts")]GIFTSANDFLOWERSPERSONALIZEDGIFTS,	
		[Description("GIFTSANDFLOWERS-Products")]GIFTSANDFLOWERSPRODUCTS,	
		[Description("GIFTSANDFLOWERS-Services")]GIFTSANDFLOWERSSERVICES,	
		[Description("HOBBIESTOYSANDGAMES-General")]HOBBIESTOYSANDGAMESGENERAL,	
		[Description("HOBBIESTOYSANDGAMES-Action-Figures")]HOBBIESTOYSANDGAMESACTIONFIGURES,	
		[Description("HOBBIESTOYSANDGAMES-Bean-Babies")]HOBBIESTOYSANDGAMESBEANBABIES,	
		[Description("HOBBIESTOYSANDGAMES-Barbies")]HOBBIESTOYSANDGAMESBARBIES,	
		[Description("HOBBIESTOYSANDGAMES-Bears")]HOBBIESTOYSANDGAMESBEARS,	
		[Description("HOBBIESTOYSANDGAMES-Dolls")]HOBBIESTOYSANDGAMESDOLLS,	
		[Description("HOBBIESTOYSANDGAMES-Games")]HOBBIESTOYSANDGAMESGAMES,	
		[Description("HOBBIESTOYSANDGAMES-Model-Kits")]HOBBIESTOYSANDGAMESMODELKITS,	
		[Description("HOBBIESTOYSANDGAMES-Diecast-Toys-Vehicles")]HOBBIESTOYSANDGAMESDIECASTTOYSVEHICLES,	
		[Description("HOBBIESTOYSANDGAMES-Video-Games-and-Systems")]HOBBIESTOYSANDGAMESVIDEOGAMESANDSYSTEMS,	
		[Description("HOBBIESTOYSANDGAMES-Vintage-and-Antique-Toys")]HOBBIESTOYSANDGAMESVINTAGEANDANTIQUETOYS,	
		[Description("HOBBIESTOYSANDGAMES-BackupUnreleased-Games")]HOBBIESTOYSANDGAMESBACKUPUNRELEASEDGAMES,	
		[Description("HOBBIESTOYSANDGAMES-Game-copying-hardwaresoftware")]HOBBIESTOYSANDGAMESGAMECOPYINGHARDWARESOFTWARE,	
		[Description("HOBBIESTOYSANDGAMES-Mod-Chips")]HOBBIESTOYSANDGAMESMODCHIPS,	
		[Description("HOMEANDGARDEN-General")]HOMEANDGARDENGENERAL,	
		[Description("HOMEANDGARDEN-Appliances")]HOMEANDGARDENAPPLIANCES,	
		[Description("HOMEANDGARDEN-Bed-and-Bath")]HOMEANDGARDENBEDANDBATH,	
		[Description("HOMEANDGARDEN-Furnishing-and-Decorating")]HOMEANDGARDENFURNISHINGANDDECORATING,	
		[Description("HOMEANDGARDEN-Garden-Supplies")]HOMEANDGARDENGARDENSUPPLIES,	
		[Description("HOMEANDGARDEN-Hardware-and-Tools")]HOMEANDGARDENHARDWAREANDTOOLS,	
		[Description("HOMEANDGARDEN-Household-Goods")]HOMEANDGARDENHOUSEHOLDGOODS,	
		[Description("HOMEANDGARDEN-Kitchenware")]HOMEANDGARDENKITCHENWARE,	
		[Description("HOMEANDGARDEN-Rugs-and-Carpets")]HOMEANDGARDENRUGSANDCARPETS,	
		[Description("HOMEANDGARDEN-Security-and-Home-Defense")]HOMEANDGARDENSECURITYANDHOMEDEFENSE,	
		[Description("HOMEANDGARDEN-Plants-and-Seeds")]HOMEANDGARDENPLANTSANDSEEDS,	
		[Description("INTERNETANDNETWORKSERVICES-General")]INTERNETANDNETWORKSERVICESGENERAL,	
		[Description("INTERNETANDNETWORKSERVICES-Bulletin-board")]INTERNETANDNETWORKSERVICESBULLETINBOARD,	
		[Description("INTERNETANDNETWORKSERVICES-online-services")]INTERNETANDNETWORKSERVICESONLINESERVICES,	
		[Description("INTERNETANDNETWORKSERVICES-Auction-management-tools")]INTERNETANDNETWORKSERVICESAUCTIONMANAGEMENTTOOLS,	
		[Description("INTERNETANDNETWORKSERVICES-ecommerce-development")]INTERNETANDNETWORKSERVICESECOMMERCEDEVELOPMENT,	
		[Description("INTERNETANDNETWORKSERVICES-training-services")]INTERNETANDNETWORKSERVICESTRAININGSERVICES,	
		[Description("INTERNETANDNETWORKSERVICES-Online-Malls")]INTERNETANDNETWORKSERVICESONLINEMALLS,	
		[Description("INTERNETANDNETWORKSERVICES-Web-hosting-and-design")]INTERNETANDNETWORKSERVICESWEBHOSTINGANDDESIGN,	
		[Description("MEDIAANDENTERTAINMENT-General")]MEDIAANDENTERTAINMENTGENERAL,	
		[Description("MEDIAANDENTERTAINMENT-Concerts")]MEDIAANDENTERTAINMENTCONCERTS,	
		[Description("MEDIAANDENTERTAINMENT-Theater")]MEDIAANDENTERTAINMENTTHEATER,	
		[Description("MEDICALANDPHARMACEUTICAL-General")]MEDICALANDPHARMACEUTICALGENERAL,	
		[Description("MEDICALANDPHARMACEUTICAL-Medical")]MEDICALANDPHARMACEUTICALMEDICAL,	
		[Description("MEDICALANDPHARMACEUTICAL-Dental")]MEDICALANDPHARMACEUTICALDENTAL,	
		[Description("MEDICALANDPHARMACEUTICAL-Opthamalic")]MEDICALANDPHARMACEUTICALOPTHAMALIC,	
		[Description("MEDICALANDPHARMACEUTICAL-Prescription-Drugs")]MEDICALANDPHARMACEUTICALPRESCRIPTIONDRUGS,	
		[Description("MEDICALANDPHARMACEUTICAL-Devices")]MEDICALANDPHARMACEUTICALDEVICES,	
		[Description("MONEYSERVICEBUSINESSES-General")]MONEYSERVICEBUSINESSESGENERAL,	
		[Description("MONEYSERVICEBUSINESSES-Remittance")]MONEYSERVICEBUSINESSESREMITTANCE,	
		[Description("MONEYSERVICEBUSINESSES-Wire-Transfer")]MONEYSERVICEBUSINESSESWIRETRANSFER,	
		[Description("MONEYSERVICEBUSINESSES-Money-Orders")]MONEYSERVICEBUSINESSESMONEYORDERS,	
		[Description("MONEYSERVICEBUSINESSES-Electronic-Cash")]MONEYSERVICEBUSINESSESELECTRONICCASH,	
		[Description("MONEYSERVICEBUSINESSES-Currency-DealerExchange")]MONEYSERVICEBUSINESSESCURRENCYDEALEREXCHANGE,	
		[Description("MONEYSERVICEBUSINESSES-Check-Cashier")]MONEYSERVICEBUSINESSESCHECKCASHIER,	
		[Description("MONEYSERVICEBUSINESSES-Travelers-Checks")]MONEYSERVICEBUSINESSESTRAVELERSCHECKS,	
		[Description("MONEYSERVICEBUSINESSES-Stored-Value-Cards")]MONEYSERVICEBUSINESSESSTOREDVALUECARDS,	
		[Description("NONPROFITPOLITICALANDRELIGION-General")]NONPROFITPOLITICALANDRELIGIONGENERAL,	
		[Description("NONPROFITPOLITICALANDRELIGION-Charities")]NONPROFITPOLITICALANDRELIGIONCHARITIES,	
		[Description("NONPROFITPOLITICALANDRELIGION-Political")]NONPROFITPOLITICALANDRELIGIONPOLITICAL,	
		[Description("NONPROFITPOLITICALANDRELIGION-Religious")]NONPROFITPOLITICALANDRELIGIONRELIGIOUS,	
		[Description("PETSANDANIMALS-General")]PETSANDANIMALSGENERAL,	
		[Description("PETSANDANIMALS-Supplies-and-Toys")]PETSANDANIMALSSUPPLIESANDTOYS,	
		[Description("PETSANDANIMALS-Wildlife-Products")]PETSANDANIMALSWILDLIFEPRODUCTS,	
		[Description("REALESTATE-General")]REALESTATEGENERAL,	
		[Description("REALESTATE-Commercial")]REALESTATECOMMERCIAL,	
		[Description("REALESTATE-Residential")]REALESTATERESIDENTIAL,	
		[Description("REALESTATE-Time-Shares")]REALESTATETIMESHARES,	
		[Description("SERVICES-GeneralGovernment")]SERVICESGENERALGOVERNMENT,	
		[Description("SERVICES-Legal")]SERVICESLEGAL,	
		[Description("SERVICES-Medical")]SERVICESMEDICAL,	
		[Description("SERVICES-Dental")]SERVICESDENTAL,	
		[Description("SERVICES-Vision")]SERVICESVISION,	
		[Description("SERVICES-General")]SERVICESGENERAL,	
		[Description("SERVICES-Child-Care-Services")]SERVICESCHILDCARESERVICES,	
		[Description("SERVICES-Consulting")]SERVICESCONSULTING,	
		[Description("SERVICES-ImportingExporting")]SERVICESIMPORTINGEXPORTING,	
		[Description("SERVICES-InsuranceDirect")]SERVICESINSURANCEDIRECT,	
		[Description("SERVICES-Financial-Services")]SERVICESFINANCIALSERVICES,	
		[Description("SERVICES-Graphic-and-Commercial-Design")]SERVICESGRAPHICANDCOMMERCIALDESIGN,	
		[Description("SERVICES-Landscaping")]SERVICESLANDSCAPING,	
		[Description("SERVICES-Locksmith")]SERVICESLOCKSMITH,	
		[Description("SERVICES-Online-Dating")]SERVICESONLINEDATING,	
		[Description("SERVICES-Event-and-Wedding-Planning")]SERVICESEVENTANDWEDDINGPLANNING,	
		[Description("SERVICES-Schools-and-Colleges")]SERVICESSCHOOLSANDCOLLEGES,	
		[Description("SERVICES-Entertainment")]SERVICESENTERTAINMENT,	
		[Description("SERVICES-Aggregators")]SERVICESAGGREGATORS,	
		[Description("SPORTSANDRECREATION-General")]SPORTSANDRECREATIONGENERAL,	
		[Description("SPORTSANDRECREATION-Bicycles-and-Accessories")]SPORTSANDRECREATIONBICYCLESANDACCESSORIES,	
		[Description("SPORTSANDRECREATION-Boating-Sailing-and-Accessories")]SPORTSANDRECREATIONBOATINGSAILINGANDACCESSORIES,	
		[Description("SPORTSANDRECREATION-Camping-and-Survival")]SPORTSANDRECREATIONCAMPINGANDSURVIVAL,	
		[Description("SPORTSANDRECREATION-Exercise-Equipment")]SPORTSANDRECREATIONEXERCISEEQUIPMENT,	
		[Description("SPORTSANDRECREATION-Fishing")]SPORTSANDRECREATIONFISHING,	
		[Description("SPORTSANDRECREATION-Golf")]SPORTSANDRECREATIONGOLF,	
		[Description("SPORTSANDRECREATION-Hunting")]SPORTSANDRECREATIONHUNTING,	
		[Description("SPORTSANDRECREATION-Paintball")]SPORTSANDRECREATIONPAINTBALL,	
		[Description("SPORTSANDRECREATION-Sporting-Goods")]SPORTSANDRECREATIONSPORTINGGOODS,	
		[Description("SPORTSANDRECREATION-Swimming-Pools-and-Spas")]SPORTSANDRECREATIONSWIMMINGPOOLSANDSPAS,	
		[Description("TRAVEL-General")]TRAVELGENERAL,	
		[Description("TRAVEL-Accommodations")]TRAVELACCOMMODATIONS,	
		[Description("TRAVEL-Agencies")]TRAVELAGENCIES,	
		[Description("TRAVEL-Airlines")]TRAVELAIRLINES,	
		[Description("TRAVEL-Auto-Rentals")]TRAVELAUTORENTALS,	
		[Description("TRAVEL-Cruises")]TRAVELCRUISES,	
		[Description("TRAVEL-Other-Transportation")]TRAVELOTHERTRANSPORTATION,	
		[Description("TRAVEL-Services")]TRAVELSERVICES,	
		[Description("TRAVEL-Supplies")]TRAVELSUPPLIES,	
		[Description("TRAVEL-Tours")]TRAVELTOURS,	
		[Description("TRAVEL-AirlinesSpirit-Air")]TRAVELAIRLINESSPIRITAIR,	
		[Description("Other-SubCategories")]OTHERSUBCATEGORIES	
	}




	/**
      * AverageTransactionPriceType
      * 
      * 
      * 
      * 
      * Enumeration
      * Meaning
      * 
      * 
      * 
      * 
      * AverageTransactionPrice-Not-Applicable 
      *
      * AverageTransactionPrice-Range1
      * Less than $25 USD
      * 
      * 
      * AverageTransactionPrice-Range2
      * $25 USD to $50 USD
      * 
      * 
      * AverageTransactionPrice-Range3
      * $50 USD to $100 USD
      * 
      * 
      * AverageTransactionPrice-Range4
      * $100 USD to $250 USD
      * 
      * 
      * AverageTransactionPrice-Range5
      * $250 USD to $500 USD
      * 
      * 
      * AverageTransactionPrice-Range6
      * $500 USD to $1,000 USD
      * 
      * 
      * AverageTransactionPrice-Range7
      * $1,000 USD to $2,000 USD
      * 
      * 
      * AverageTransactionPrice-Range8
      * $2,000 USD to $5,000 USD
      * 
      * 
      * AverageTransactionPrice-Range9
      * $5,000 USD to $10,000 USD
      * 
      * 
      * AverageTransactionPrice-Range10
      * More than $10,000 USD
      * 
      * 
      * 
      */
    [Serializable]
	public enum AverageTransactionPriceType {
		[Description("AverageTransactionPrice-Not-Applicable")]AVERAGETRANSACTIONPRICENOTAPPLICABLE,	
		[Description("AverageTransactionPrice-Range1")]AVERAGETRANSACTIONPRICERANGE1,	
		[Description("AverageTransactionPrice-Range2")]AVERAGETRANSACTIONPRICERANGE2,	
		[Description("AverageTransactionPrice-Range3")]AVERAGETRANSACTIONPRICERANGE3,	
		[Description("AverageTransactionPrice-Range4")]AVERAGETRANSACTIONPRICERANGE4,	
		[Description("AverageTransactionPrice-Range5")]AVERAGETRANSACTIONPRICERANGE5,	
		[Description("AverageTransactionPrice-Range6")]AVERAGETRANSACTIONPRICERANGE6,	
		[Description("AverageTransactionPrice-Range7")]AVERAGETRANSACTIONPRICERANGE7,	
		[Description("AverageTransactionPrice-Range8")]AVERAGETRANSACTIONPRICERANGE8,	
		[Description("AverageTransactionPrice-Range9")]AVERAGETRANSACTIONPRICERANGE9,	
		[Description("AverageTransactionPrice-Range10")]AVERAGETRANSACTIONPRICERANGE10	
	}




	/**
      * AverageMonthlyVolumeType 
      * 
      * 
      * Enumeration
      * Meaning
      * 
      * 
      * AverageMonthlyVolume-Not-Applicable
      * 
      * 
      * 
      * AverageMonthlyVolume-Range1
      * Less than $1,000 USD
      * 
      * 
      * AverageMonthlyVolume-Range2
      * $1,000 USD to $5,000 USD
      * 
      * 
      * AverageMonthlyVolume-Range3
      * $5,000 USD to $25,000 USD
      * 
      * 
      * AverageMonthlyVolume-Range4
      * $25,000 USD to $100,000 USD
      * 
      * 
      * AverageMonthlyVolume-Range5
      * $100,000 USD to $1,000,000 USD
      * 
      * 
      * AverageMonthlyVolume-Range6
      * More than $1,000,000 USD
      * 
      * 
      * 
      */
    [Serializable]
	public enum AverageMonthlyVolumeType {
		[Description("AverageMonthlyVolume-Not-Applicable")]AVERAGEMONTHLYVOLUMENOTAPPLICABLE,	
		[Description("AverageMonthlyVolume-Range1")]AVERAGEMONTHLYVOLUMERANGE1,	
		[Description("AverageMonthlyVolume-Range2")]AVERAGEMONTHLYVOLUMERANGE2,	
		[Description("AverageMonthlyVolume-Range3")]AVERAGEMONTHLYVOLUMERANGE3,	
		[Description("AverageMonthlyVolume-Range4")]AVERAGEMONTHLYVOLUMERANGE4,	
		[Description("AverageMonthlyVolume-Range5")]AVERAGEMONTHLYVOLUMERANGE5,	
		[Description("AverageMonthlyVolume-Range6")]AVERAGEMONTHLYVOLUMERANGE6	
	}




	/**
      * SalesVenueType 
      * 
      */
    [Serializable]
	public enum SalesVenueType {
		[Description("Venue-Unspecified")]VENUEUNSPECIFIED,	
		[Description("eBay")]EBAY,	
		[Description("AnotherMarketPlace")]ANOTHERMARKETPLACE,	
		[Description("OwnWebsite")]OWNWEBSITE,	
		[Description("Other")]OTHER	
	}




	/**
      * PercentageRevenueFromOnlineSalesType
      * 
      * 
      * 
      * 
      * Enumeration
      * Meaning
      * 
      * 
      * 
      * 
      * PercentageRevenueFromOnlineSales-Not-Applicable 
      *
      * PercentageRevenueFromOnlineSales-Range1
      * Less than 25%
      * 
      * 
      * PercentageRevenueFromOnlineSales-Range2
      * 25% to 50%
      * 
      * 
      * PercentageRevenueFromOnlineSales-Range3
      * 50% to 75%
      * 
      * 
      * PercentageRevenueFromOnlineSales-Range4
      * 75% to 100%
      * 
      * 
      * 
      */
    [Serializable]
	public enum PercentageRevenueFromOnlineSalesType {
		[Description("PercentageRevenueFromOnlineSales-Not-Applicable")]PERCENTAGEREVENUEFROMONLINESALESNOTAPPLICABLE,	
		[Description("PercentageRevenueFromOnlineSales-Range1")]PERCENTAGEREVENUEFROMONLINESALESRANGE1,	
		[Description("PercentageRevenueFromOnlineSales-Range2")]PERCENTAGEREVENUEFROMONLINESALESRANGE2,	
		[Description("PercentageRevenueFromOnlineSales-Range3")]PERCENTAGEREVENUEFROMONLINESALESRANGE3,	
		[Description("PercentageRevenueFromOnlineSales-Range4")]PERCENTAGEREVENUEFROMONLINESALESRANGE4	
	}




	/**
      * BankAccountTypeType 
      * 
      */
    [Serializable]
	public enum BankAccountTypeType {
		[Description("Checking")]CHECKING,	
		[Description("Savings")]SAVINGS	
	}




	/**
      * Boarding Status 
      * 
      */
    [Serializable]
	public enum BoardingStatusType {
		[Description("Unknown")]UNKNOWN,	
		[Description("Completed")]COMPLETED,	
		[Description("Cancelled")]CANCELLED,	
		[Description("Pending")]PENDING	
	}




	/**
      * User Withdrawal Limit Type Type 
      * 
      */
    [Serializable]
	public enum UserWithdrawalLimitTypeType {
		[Description("Unknown")]UNKNOWN,	
		[Description("Limited")]LIMITED,	
		[Description("Unlimited")]UNLIMITED	
	}




	/**
      * API Authentication Type 
      * 
      */
    [Serializable]
	public enum APIAuthenticationType {
		[Description("Auth-None")]AUTHNONE,	
		[Description("Cert")]CERT,	
		[Description("Sign")]SIGN	
	}




	/**
      * 
      */
    [Serializable]
	public enum RecurringPaymentsProfileStatusType {
		[Description("ActiveProfile")]ACTIVEPROFILE,	
		[Description("PendingProfile")]PENDINGPROFILE,	
		[Description("CancelledProfile")]CANCELLEDPROFILE,	
		[Description("ExpiredProfile")]EXPIREDPROFILE,	
		[Description("SuspendedProfile")]SUSPENDEDPROFILE	
	}




	/**
      * 
      */
    [Serializable]
	public enum FailedPaymentActionType {
		[Description("CancelOnFailure")]CANCELONFAILURE,	
		[Description("ContinueOnFailure")]CONTINUEONFAILURE	
	}




	/**
      * 
      */
    [Serializable]
	public enum AutoBillType {
		[Description("NoAutoBill")]NOAUTOBILL,	
		[Description("AddToNextBilling")]ADDTONEXTBILLING	
	}




	/**
      * 
      */
    [Serializable]
	public enum StatusChangeActionType {
		[Description("Cancel")]CANCEL,	
		[Description("Suspend")]SUSPEND,	
		[Description("Reactivate")]REACTIVATE	
	}




	/**
      * 
      */
    [Serializable]
	public enum BillingPeriodType {
		[Description("NoBillingPeriodType")]NOBILLINGPERIODTYPE,	
		[Description("Day")]DAY,	
		[Description("Week")]WEEK,	
		[Description("SemiMonth")]SEMIMONTH,	
		[Description("Month")]MONTH,	
		[Description("Year")]YEAR	
	}




	/**
      * 
      */
    [Serializable]
	public enum ProductCategoryType {
		[Description("Other")]OTHER,	
		[Description("Airlines")]AIRLINES,	
		[Description("Antiques")]ANTIQUES,	
		[Description("Art")]ART,	
		[Description("Cameras_Photos")]CAMERASPHOTOS,	
		[Description("Cars_Boats_Vehicles_Parts")]CARSBOATSVEHICLESPARTS,	
		[Description("CellPhones_Telecom")]CELLPHONESTELECOM,	
		[Description("Coins_PaperMoney")]COINSPAPERMONEY,	
		[Description("Collectibles")]COLLECTIBLES,	
		[Description("Computers_Networking")]COMPUTERSNETWORKING,	
		[Description("ConsumerElectronics")]CONSUMERELECTRONICS,	
		[Description("Jewelry_Watches")]JEWELRYWATCHES,	
		[Description("MusicalInstruments")]MUSICALINSTRUMENTS,	
		[Description("RealEstate")]REALESTATE,	
		[Description("SportsMemorabilia_Cards_FanShop")]SPORTSMEMORABILIACARDSFANSHOP,	
		[Description("Stamps")]STAMPS,	
		[Description("Tickets")]TICKETS,	
		[Description("Travels")]TRAVELS,	
		[Description("Gambling")]GAMBLING,	
		[Description("Alcohol")]ALCOHOL,	
		[Description("Tobacco")]TOBACCO,	
		[Description("MoneyTransfer")]MONEYTRANSFER,	
		[Description("Software")]SOFTWARE	
	}




	/**
      * Types of button coding
      * 
      */
    [Serializable]
	public enum ButtonCodeType {
		[Description("HOSTED")]HOSTED,	
		[Description("ENCRYPTED")]ENCRYPTED,	
		[Description("CLEARTEXT")]CLEARTEXT,	
		[Description("TOKEN")]TOKEN	
	}




	/**
      * Types of buttons
      * 
      */
    [Serializable]
	public enum ButtonTypeType {
		[Description("BUYNOW")]BUYNOW,	
		[Description("CART")]CART,	
		[Description("GIFTCERTIFICATE")]GIFTCERTIFICATE,	
		[Description("SUBSCRIBE")]SUBSCRIBE,	
		[Description("DONATE")]DONATE,	
		[Description("UNSUBSCRIBE")]UNSUBSCRIBE,	
		[Description("VIEWCART")]VIEWCART,	
		[Description("PAYMENTPLAN")]PAYMENTPLAN,	
		[Description("AUTOBILLING")]AUTOBILLING,	
		[Description("PAYMENT")]PAYMENT	
	}




	/**
      * Types of button sub types
      * 
      */
    [Serializable]
	public enum ButtonSubTypeType {
		[Description("PRODUCTS")]PRODUCTS,	
		[Description("SERVICES")]SERVICES	
	}




	/**
      * Types of button images
      * 
      */
    [Serializable]
	public enum ButtonImageType {
		[Description("REG")]REG,	
		[Description("SML")]SML,	
		[Description("CC")]CC	
	}




	/**
      * values for buynow button text
      * 
      */
    [Serializable]
	public enum BuyNowTextType {
		[Description("BUYNOW")]BUYNOW,	
		[Description("PAYNOW")]PAYNOW	
	}




	/**
      * values for subscribe button text
      * 
      */
    [Serializable]
	public enum SubscribeTextType {
		[Description("BUYNOW")]BUYNOW,	
		[Description("SUBSCRIBE")]SUBSCRIBE	
	}




	/**
      * values for subscribe button text
      * 
      */
    [Serializable]
	public enum ButtonStatusType {
		[Description("DELETE")]DELETE	
	}




	/**
      * 
      */
    [Serializable]
	public enum OptionTypeListType {
		[Description("NoOptionType")]NOOPTIONTYPE,	
		[Description("FULL")]FULL,	
		[Description("EMI")]EMI,	
		[Description("VARIABLE")]VARIABLE	
	}




	/**
      * UserSelectedFundingSourceType
      * User Selected Funding Source (used by Express Checkout)
      * 
      */
    [Serializable]
	public enum UserSelectedFundingSourceType {
		[Description("ELV")]ELV,	
		[Description("CreditCard")]CREDITCARD,	
		[Description("ChinaUnionPay")]CHINAUNIONPAY,	
		[Description("BML")]BML	
	}




	/**
      * 
      */
    [Serializable]
	public enum ItemCategoryType {
		[Description("Physical")]PHYSICAL,	
		[Description("Digital")]DIGITAL	
	}




	/**
      * 
      */
    [Serializable]
	public enum RecurringFlagType {
		[Description("Y")]Y1,	
		[Description("y")]Y2	
	}




	/**
      * Defines couple relationship type between buckets 
      */
    [Serializable]
	public enum CoupleType {
		[Description("LifeTime")]LIFETIME	
	}




	/**
      * Category of payment like international shipping
      * 
      */
    [Serializable]
	public enum PaymentCategoryType {
		[Description("InternationalShipping")]INTERNATIONALSHIPPING	
	}




	/**
      *Value of the application-specific error parameter.  
      */
	public partial class ErrorParameterType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string valueField;
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
		

		/**
          *
		  */
		private string paramIDField;
		public string ParamID
		{
			get
			{
				return this.paramIDField;
			}
			set
			{
				this.paramIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ErrorParameterType()
	 	{
		}


		public ErrorParameterType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Value']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Value = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ParamID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ParamID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Error code can be used by a receiving application to
      *debugging a response message. These codes will need to be
      *uniquely defined for each application. 
      */
	public partial class ErrorType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string shortMessageField;
		public string ShortMessage
		{
			get
			{
				return this.shortMessageField;
			}
			set
			{
				this.shortMessageField = value;
			}
		}
		

		/**
          *
		  */
		private string longMessageField;
		public string LongMessage
		{
			get
			{
				return this.longMessageField;
			}
			set
			{
				this.longMessageField = value;
			}
		}
		

		/**
          *
		  */
		private string errorCodeField;
		public string ErrorCode
		{
			get
			{
				return this.errorCodeField;
			}
			set
			{
				this.errorCodeField = value;
			}
		}
		

		/**
          *
		  */
		private SeverityCodeType? severityCodeField;
		public SeverityCodeType? SeverityCode
		{
			get
			{
				return this.severityCodeField;
			}
			set
			{
				this.severityCodeField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorParameterType> errorParametersField = new List<ErrorParameterType>();
		public List<ErrorParameterType> ErrorParameters
		{
			get
			{
				return this.errorParametersField;
			}
			set
			{
				this.errorParametersField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ErrorType()
	 	{
		}


		public ErrorType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ShortMessage']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ShortMessage = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'LongMessage']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.LongMessage = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ErrorCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ErrorCode = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SeverityCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SeverityCode = (SeverityCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(SeverityCodeType));
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'ErrorParameters']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.ErrorParameters.Add(new ErrorParameterType(subNode));
				}
			}
	
		}
	}




	/**
      *Base type definition of request payload that can carry any
      *type of payload content with optional versioning information
      *and detail level requirements. 
      */
	public partial class AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private List<DetailLevelCodeType?> detailLevelField = new List<DetailLevelCodeType?>();
		public List<DetailLevelCodeType?> DetailLevel
		{
			get
			{
				return this.detailLevelField;
			}
			set
			{
				this.detailLevelField = value;
			}
		}
		

		/**
          *
		  */
		private string errorLanguageField;
		public string ErrorLanguage
		{
			get
			{
				return this.errorLanguageField;
			}
			set
			{
				this.errorLanguageField = value;
			}
		}
		

		/**
          *
		  */
		private string versionField;
		public string Version
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
		

		/**
	 	  * Default Constructor
	 	  */
	 	public AbstractRequestType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(DetailLevel != null)
			{
				for(int i = 0; i < DetailLevel.Count; i++)
				{
					sb.Append("<").Append(PreferredPrefix).Append(":DetailLevel>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.DetailLevel[i]))).Append("</").Append(PreferredPrefix).Append(":DetailLevel>");
				}
			}
			if(ErrorLanguage != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ErrorLanguage>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ErrorLanguage));
				sb.Append("</").Append(PreferredPrefix).Append(":ErrorLanguage>");
			}
			if(Version != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Version>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Version));
				sb.Append("</").Append(PreferredPrefix).Append(":Version>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Base type definition of a response payload that can carry
      *any type of payload content with following optional
      *elements: - timestamp of response message, - application
      *level acknowledgement, and - application-level errors and
      *warnings. 
      */
	public partial class AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string timestampField;
		public string Timestamp
		{
			get
			{
				return this.timestampField;
			}
			set
			{
				this.timestampField = value;
			}
		}
		

		/**
          *
		  */
		private AckCodeType? ackField;
		public AckCodeType? Ack
		{
			get
			{
				return this.ackField;
			}
			set
			{
				this.ackField = value;
			}
		}
		

		/**
          *
		  */
		private string correlationIDField;
		public string CorrelationID
		{
			get
			{
				return this.correlationIDField;
			}
			set
			{
				this.correlationIDField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorType> errorsField = new List<ErrorType>();
		public List<ErrorType> Errors
		{
			get
			{
				return this.errorsField;
			}
			set
			{
				this.errorsField = value;
			}
		}
		

		/**
          *
		  */
		private string versionField;
		public string Version
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
		

		/**
          *
		  */
		private string buildField;
		public string Build
		{
			get
			{
				return this.buildField;
			}
			set
			{
				this.buildField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public AbstractResponseType()
	 	{
		}


		public AbstractResponseType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Timestamp']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Timestamp = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Ack']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Ack = (AckCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(AckCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CorrelationID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CorrelationID = ChildNode.InnerText;
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'Errors']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.Errors.Add(new ErrorType(subNode));
				}
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Version']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Version = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Build']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Build = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Country code associated with this phone number. 
      */
	public partial class PhoneNumberType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string countryCodeField;
		public string CountryCode
		{
			get
			{
				return this.countryCodeField;
			}
			set
			{
				this.countryCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string phoneNumberField;
		public string PhoneNumber
		{
			get
			{
				return this.phoneNumberField;
			}
			set
			{
				this.phoneNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string extensionField;
		public string Extension
		{
			get
			{
				return this.extensionField;
			}
			set
			{
				this.extensionField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PhoneNumberType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(CountryCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CountryCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CountryCode));
				sb.Append("</").Append(PreferredPrefix).Append(":CountryCode>");
			}
			if(PhoneNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PhoneNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PhoneNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":PhoneNumber>");
			}
			if(Extension != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Extension>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Extension));
				sb.Append("</").Append(PreferredPrefix).Append(":Extension>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Person's name associated with this address. Character length
      *and limitations: 32 single-byte alphanumeric characters 
      */
	public partial class AddressType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string nameField;
		public string Name
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
		

		/**
          *
		  */
		private string street1Field;
		public string Street1
		{
			get
			{
				return this.street1Field;
			}
			set
			{
				this.street1Field = value;
			}
		}
		

		/**
          *
		  */
		private string street2Field;
		public string Street2
		{
			get
			{
				return this.street2Field;
			}
			set
			{
				this.street2Field = value;
			}
		}
		

		/**
          *
		  */
		private string cityNameField;
		public string CityName
		{
			get
			{
				return this.cityNameField;
			}
			set
			{
				this.cityNameField = value;
			}
		}
		

		/**
          *
		  */
		private string stateOrProvinceField;
		public string StateOrProvince
		{
			get
			{
				return this.stateOrProvinceField;
			}
			set
			{
				this.stateOrProvinceField = value;
			}
		}
		

		/**
          *
		  */
		private CountryCodeType? countryField;
		public CountryCodeType? Country
		{
			get
			{
				return this.countryField;
			}
			set
			{
				this.countryField = value;
			}
		}
		

		/**
          *
		  */
		private string countryNameField;
		public string CountryName
		{
			get
			{
				return this.countryNameField;
			}
			set
			{
				this.countryNameField = value;
			}
		}
		

		/**
          *
		  */
		private string phoneField;
		public string Phone
		{
			get
			{
				return this.phoneField;
			}
			set
			{
				this.phoneField = value;
			}
		}
		

		/**
          *
		  */
		private string postalCodeField;
		public string PostalCode
		{
			get
			{
				return this.postalCodeField;
			}
			set
			{
				this.postalCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string addressIDField;
		public string AddressID
		{
			get
			{
				return this.addressIDField;
			}
			set
			{
				this.addressIDField = value;
			}
		}
		

		/**
          *
		  */
		private AddressOwnerCodeType? addressOwnerField;
		public AddressOwnerCodeType? AddressOwner
		{
			get
			{
				return this.addressOwnerField;
			}
			set
			{
				this.addressOwnerField = value;
			}
		}
		

		/**
          *
		  */
		private string externalAddressIDField;
		public string ExternalAddressID
		{
			get
			{
				return this.externalAddressIDField;
			}
			set
			{
				this.externalAddressIDField = value;
			}
		}
		

		/**
          *
		  */
		private string internationalNameField;
		public string InternationalName
		{
			get
			{
				return this.internationalNameField;
			}
			set
			{
				this.internationalNameField = value;
			}
		}
		

		/**
          *
		  */
		private string internationalStateAndCityField;
		public string InternationalStateAndCity
		{
			get
			{
				return this.internationalStateAndCityField;
			}
			set
			{
				this.internationalStateAndCityField = value;
			}
		}
		

		/**
          *
		  */
		private string internationalStreetField;
		public string InternationalStreet
		{
			get
			{
				return this.internationalStreetField;
			}
			set
			{
				this.internationalStreetField = value;
			}
		}
		

		/**
          *
		  */
		private AddressStatusCodeType? addressStatusField;
		public AddressStatusCodeType? AddressStatus
		{
			get
			{
				return this.addressStatusField;
			}
			set
			{
				this.addressStatusField = value;
			}
		}
		

		/**
          *
		  */
		private AddressNormalizationStatusCodeType? addressNormalizationStatusField;
		public AddressNormalizationStatusCodeType? AddressNormalizationStatus
		{
			get
			{
				return this.addressNormalizationStatusField;
			}
			set
			{
				this.addressNormalizationStatusField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public AddressType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Name != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Name>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Name));
				sb.Append("</").Append(PreferredPrefix).Append(":Name>");
			}
			if(Street1 != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Street1>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Street1));
				sb.Append("</").Append(PreferredPrefix).Append(":Street1>");
			}
			if(Street2 != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Street2>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Street2));
				sb.Append("</").Append(PreferredPrefix).Append(":Street2>");
			}
			if(CityName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CityName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CityName));
				sb.Append("</").Append(PreferredPrefix).Append(":CityName>");
			}
			if(StateOrProvince != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":StateOrProvince>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.StateOrProvince));
				sb.Append("</").Append(PreferredPrefix).Append(":StateOrProvince>");
			}
			if(Country != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Country>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.Country)));
				sb.Append("</").Append(PreferredPrefix).Append(":Country>");
			}
			if(CountryName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CountryName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CountryName));
				sb.Append("</").Append(PreferredPrefix).Append(":CountryName>");
			}
			if(Phone != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Phone>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Phone));
				sb.Append("</").Append(PreferredPrefix).Append(":Phone>");
			}
			if(PostalCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PostalCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PostalCode));
				sb.Append("</").Append(PreferredPrefix).Append(":PostalCode>");
			}
			if(AddressID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AddressID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.AddressID));
				sb.Append("</").Append(PreferredPrefix).Append(":AddressID>");
			}
			if(AddressOwner != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AddressOwner>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.AddressOwner)));
				sb.Append("</").Append(PreferredPrefix).Append(":AddressOwner>");
			}
			if(ExternalAddressID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ExternalAddressID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ExternalAddressID));
				sb.Append("</").Append(PreferredPrefix).Append(":ExternalAddressID>");
			}
			if(InternationalName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":InternationalName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.InternationalName));
				sb.Append("</").Append(PreferredPrefix).Append(":InternationalName>");
			}
			if(InternationalStateAndCity != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":InternationalStateAndCity>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.InternationalStateAndCity));
				sb.Append("</").Append(PreferredPrefix).Append(":InternationalStateAndCity>");
			}
			if(InternationalStreet != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":InternationalStreet>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.InternationalStreet));
				sb.Append("</").Append(PreferredPrefix).Append(":InternationalStreet>");
			}
			if(AddressStatus != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AddressStatus>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.AddressStatus)));
				sb.Append("</").Append(PreferredPrefix).Append(":AddressStatus>");
			}
			if(AddressNormalizationStatus != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AddressNormalizationStatus>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.AddressNormalizationStatus)));
				sb.Append("</").Append(PreferredPrefix).Append(":AddressNormalizationStatus>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public AddressType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Name']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Name = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Street1']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Street1 = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Street2']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Street2 = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CityName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CityName = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'StateOrProvince']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.StateOrProvince = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Country']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Country = (CountryCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(CountryCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CountryName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CountryName = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Phone']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Phone = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PostalCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PostalCode = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AddressID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AddressID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AddressOwner']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AddressOwner = (AddressOwnerCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(AddressOwnerCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ExternalAddressID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ExternalAddressID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'InternationalName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.InternationalName = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'InternationalStateAndCity']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.InternationalStateAndCity = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'InternationalStreet']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.InternationalStreet = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AddressStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AddressStatus = (AddressStatusCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(AddressStatusCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AddressNormalizationStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AddressNormalizationStatus = (AddressNormalizationStatusCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(AddressNormalizationStatusCodeType));
			}
	
		}
	}




	/**
      *
      */
	public partial class PersonNameType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string salutationField;
		public string Salutation
		{
			get
			{
				return this.salutationField;
			}
			set
			{
				this.salutationField = value;
			}
		}
		

		/**
          *
		  */
		private string firstNameField;
		public string FirstName
		{
			get
			{
				return this.firstNameField;
			}
			set
			{
				this.firstNameField = value;
			}
		}
		

		/**
          *
		  */
		private string middleNameField;
		public string MiddleName
		{
			get
			{
				return this.middleNameField;
			}
			set
			{
				this.middleNameField = value;
			}
		}
		

		/**
          *
		  */
		private string lastNameField;
		public string LastName
		{
			get
			{
				return this.lastNameField;
			}
			set
			{
				this.lastNameField = value;
			}
		}
		

		/**
          *
		  */
		private string suffixField;
		public string Suffix
		{
			get
			{
				return this.suffixField;
			}
			set
			{
				this.suffixField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PersonNameType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Salutation != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Salutation>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Salutation));
				sb.Append("</").Append(PreferredPrefix).Append(":Salutation>");
			}
			if(FirstName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":FirstName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.FirstName));
				sb.Append("</").Append(PreferredPrefix).Append(":FirstName>");
			}
			if(MiddleName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MiddleName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.MiddleName));
				sb.Append("</").Append(PreferredPrefix).Append(":MiddleName>");
			}
			if(LastName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":LastName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.LastName));
				sb.Append("</").Append(PreferredPrefix).Append(":LastName>");
			}
			if(Suffix != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Suffix>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Suffix));
				sb.Append("</").Append(PreferredPrefix).Append(":Suffix>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public PersonNameType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Salutation']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Salutation = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'FirstName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.FirstName = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'MiddleName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.MiddleName = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'LastName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.LastName = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Suffix']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Suffix = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class IncentiveAppliedToType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string bucketIdField;
		public string BucketId
		{
			get
			{
				return this.bucketIdField;
			}
			set
			{
				this.bucketIdField = value;
			}
		}
		

		/**
          *
		  */
		private string itemIdField;
		public string ItemId
		{
			get
			{
				return this.itemIdField;
			}
			set
			{
				this.itemIdField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType incentiveAmountField;
		public BasicAmountType IncentiveAmount
		{
			get
			{
				return this.incentiveAmountField;
			}
			set
			{
				this.incentiveAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string subTypeField;
		public string SubType
		{
			get
			{
				return this.subTypeField;
			}
			set
			{
				this.subTypeField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public IncentiveAppliedToType()
	 	{
		}


		public IncentiveAppliedToType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BucketId']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BucketId = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemId']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemId = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'IncentiveAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.IncentiveAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SubType']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SubType = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class IncentiveDetailType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string redemptionCodeField;
		public string RedemptionCode
		{
			get
			{
				return this.redemptionCodeField;
			}
			set
			{
				this.redemptionCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string displayCodeField;
		public string DisplayCode
		{
			get
			{
				return this.displayCodeField;
			}
			set
			{
				this.displayCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string programIdField;
		public string ProgramId
		{
			get
			{
				return this.programIdField;
			}
			set
			{
				this.programIdField = value;
			}
		}
		

		/**
          *
		  */
		private IncentiveTypeCodeType? incentiveTypeField;
		public IncentiveTypeCodeType? IncentiveType
		{
			get
			{
				return this.incentiveTypeField;
			}
			set
			{
				this.incentiveTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string incentiveDescriptionField;
		public string IncentiveDescription
		{
			get
			{
				return this.incentiveDescriptionField;
			}
			set
			{
				this.incentiveDescriptionField = value;
			}
		}
		

		/**
          *
		  */
		private List<IncentiveAppliedToType> appliedToField = new List<IncentiveAppliedToType>();
		public List<IncentiveAppliedToType> AppliedTo
		{
			get
			{
				return this.appliedToField;
			}
			set
			{
				this.appliedToField = value;
			}
		}
		

		/**
          *
		  */
		private string statusField;
		public string Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		

		/**
          *
		  */
		private string errorCodeField;
		public string ErrorCode
		{
			get
			{
				return this.errorCodeField;
			}
			set
			{
				this.errorCodeField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public IncentiveDetailType()
	 	{
		}


		public IncentiveDetailType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RedemptionCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RedemptionCode = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'DisplayCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.DisplayCode = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ProgramId']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ProgramId = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'IncentiveType']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.IncentiveType = (IncentiveTypeCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(IncentiveTypeCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'IncentiveDescription']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.IncentiveDescription = ChildNode.InnerText;
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'AppliedTo']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.AppliedTo.Add(new IncentiveAppliedToType(subNode));
				}
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Status']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Status = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ErrorCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ErrorCode = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class IncentiveItemType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string itemIdField;
		public string ItemId
		{
			get
			{
				return this.itemIdField;
			}
			set
			{
				this.itemIdField = value;
			}
		}
		

		/**
          *
		  */
		private string purchaseTimeField;
		public string PurchaseTime
		{
			get
			{
				return this.purchaseTimeField;
			}
			set
			{
				this.purchaseTimeField = value;
			}
		}
		

		/**
          *
		  */
		private string itemCategoryListField;
		public string ItemCategoryList
		{
			get
			{
				return this.itemCategoryListField;
			}
			set
			{
				this.itemCategoryListField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType itemPriceField;
		public BasicAmountType ItemPrice
		{
			get
			{
				return this.itemPriceField;
			}
			set
			{
				this.itemPriceField = value;
			}
		}
		

		/**
          *
		  */
		private int? itemQuantityField;
		public int? ItemQuantity
		{
			get
			{
				return this.itemQuantityField;
			}
			set
			{
				this.itemQuantityField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public IncentiveItemType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ItemId != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemId>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ItemId));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemId>");
			}
			if(PurchaseTime != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PurchaseTime>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PurchaseTime));
				sb.Append("</").Append(PreferredPrefix).Append(":PurchaseTime>");
			}
			if(ItemCategoryList != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemCategoryList>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ItemCategoryList));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemCategoryList>");
			}
			if(ItemPrice != null)
			{
				sb.Append(ItemPrice.ToXMLString(PreferredPrefix,"ItemPrice"));
			}
			if(ItemQuantity != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemQuantity>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ItemQuantity));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemQuantity>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class IncentiveBucketType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private List<IncentiveItemType> itemsField = new List<IncentiveItemType>();
		public List<IncentiveItemType> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}
		

		/**
          *
		  */
		private string bucketIdField;
		public string BucketId
		{
			get
			{
				return this.bucketIdField;
			}
			set
			{
				this.bucketIdField = value;
			}
		}
		

		/**
          *
		  */
		private string sellerIdField;
		public string SellerId
		{
			get
			{
				return this.sellerIdField;
			}
			set
			{
				this.sellerIdField = value;
			}
		}
		

		/**
          *
		  */
		private string externalSellerIdField;
		public string ExternalSellerId
		{
			get
			{
				return this.externalSellerIdField;
			}
			set
			{
				this.externalSellerIdField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType bucketSubtotalAmtField;
		public BasicAmountType BucketSubtotalAmt
		{
			get
			{
				return this.bucketSubtotalAmtField;
			}
			set
			{
				this.bucketSubtotalAmtField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType bucketShippingAmtField;
		public BasicAmountType BucketShippingAmt
		{
			get
			{
				return this.bucketShippingAmtField;
			}
			set
			{
				this.bucketShippingAmtField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType bucketInsuranceAmtField;
		public BasicAmountType BucketInsuranceAmt
		{
			get
			{
				return this.bucketInsuranceAmtField;
			}
			set
			{
				this.bucketInsuranceAmtField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType bucketSalesTaxAmtField;
		public BasicAmountType BucketSalesTaxAmt
		{
			get
			{
				return this.bucketSalesTaxAmtField;
			}
			set
			{
				this.bucketSalesTaxAmtField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType bucketTotalAmtField;
		public BasicAmountType BucketTotalAmt
		{
			get
			{
				return this.bucketTotalAmtField;
			}
			set
			{
				this.bucketTotalAmtField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public IncentiveBucketType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Items != null)
			{
				for(int i = 0; i < Items.Count; i++)
				{
					sb.Append(Items[i].ToXMLString(PreferredPrefix,"Items"));
				}
			}
			if(BucketId != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BucketId>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BucketId));
				sb.Append("</").Append(PreferredPrefix).Append(":BucketId>");
			}
			if(SellerId != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SellerId>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SellerId));
				sb.Append("</").Append(PreferredPrefix).Append(":SellerId>");
			}
			if(ExternalSellerId != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ExternalSellerId>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ExternalSellerId));
				sb.Append("</").Append(PreferredPrefix).Append(":ExternalSellerId>");
			}
			if(BucketSubtotalAmt != null)
			{
				sb.Append(BucketSubtotalAmt.ToXMLString(PreferredPrefix,"BucketSubtotalAmt"));
			}
			if(BucketShippingAmt != null)
			{
				sb.Append(BucketShippingAmt.ToXMLString(PreferredPrefix,"BucketShippingAmt"));
			}
			if(BucketInsuranceAmt != null)
			{
				sb.Append(BucketInsuranceAmt.ToXMLString(PreferredPrefix,"BucketInsuranceAmt"));
			}
			if(BucketSalesTaxAmt != null)
			{
				sb.Append(BucketSalesTaxAmt.ToXMLString(PreferredPrefix,"BucketSalesTaxAmt"));
			}
			if(BucketTotalAmt != null)
			{
				sb.Append(BucketTotalAmt.ToXMLString(PreferredPrefix,"BucketTotalAmt"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class IncentiveRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string requestIdField;
		public string RequestId
		{
			get
			{
				return this.requestIdField;
			}
			set
			{
				this.requestIdField = value;
			}
		}
		

		/**
          *
		  */
		private IncentiveRequestCodeType? requestTypeField;
		public IncentiveRequestCodeType? RequestType
		{
			get
			{
				return this.requestTypeField;
			}
			set
			{
				this.requestTypeField = value;
			}
		}
		

		/**
          *
		  */
		private IncentiveRequestDetailLevelCodeType? requestDetailLevelField;
		public IncentiveRequestDetailLevelCodeType? RequestDetailLevel
		{
			get
			{
				return this.requestDetailLevelField;
			}
			set
			{
				this.requestDetailLevelField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public IncentiveRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(RequestId != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":RequestId>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.RequestId));
				sb.Append("</").Append(PreferredPrefix).Append(":RequestId>");
			}
			if(RequestType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":RequestType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.RequestType)));
				sb.Append("</").Append(PreferredPrefix).Append(":RequestType>");
			}
			if(RequestDetailLevel != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":RequestDetailLevel>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.RequestDetailLevel)));
				sb.Append("</").Append(PreferredPrefix).Append(":RequestDetailLevel>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetIncentiveEvaluationRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string externalBuyerIdField;
		public string ExternalBuyerId
		{
			get
			{
				return this.externalBuyerIdField;
			}
			set
			{
				this.externalBuyerIdField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> incentiveCodesField = new List<string>();
		public List<string> IncentiveCodes
		{
			get
			{
				return this.incentiveCodesField;
			}
			set
			{
				this.incentiveCodesField = value;
			}
		}
		

		/**
          *
		  */
		private List<IncentiveApplyIndicationType> applyIndicationField = new List<IncentiveApplyIndicationType>();
		public List<IncentiveApplyIndicationType> ApplyIndication
		{
			get
			{
				return this.applyIndicationField;
			}
			set
			{
				this.applyIndicationField = value;
			}
		}
		

		/**
          *
		  */
		private List<IncentiveBucketType> bucketsField = new List<IncentiveBucketType>();
		public List<IncentiveBucketType> Buckets
		{
			get
			{
				return this.bucketsField;
			}
			set
			{
				this.bucketsField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType cartTotalAmtField;
		public BasicAmountType CartTotalAmt
		{
			get
			{
				return this.cartTotalAmtField;
			}
			set
			{
				this.cartTotalAmtField = value;
			}
		}
		

		/**
          *
		  */
		private IncentiveRequestDetailsType requestDetailsField;
		public IncentiveRequestDetailsType RequestDetails
		{
			get
			{
				return this.requestDetailsField;
			}
			set
			{
				this.requestDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetIncentiveEvaluationRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ExternalBuyerId != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ExternalBuyerId>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ExternalBuyerId));
				sb.Append("</").Append(PreferredPrefix).Append(":ExternalBuyerId>");
			}
			if(IncentiveCodes != null)
			{
				for(int i = 0; i < IncentiveCodes.Count; i++)
				{
					sb.Append("<").Append(PreferredPrefix).Append(":IncentiveCodes>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.IncentiveCodes[i]));
					sb.Append("</").Append(PreferredPrefix).Append(":IncentiveCodes>");
				}
			}
			if(ApplyIndication != null)
			{
				for(int i = 0; i < ApplyIndication.Count; i++)
				{
					sb.Append(ApplyIndication[i].ToXMLString(PreferredPrefix,"ApplyIndication"));
				}
			}
			if(Buckets != null)
			{
				for(int i = 0; i < Buckets.Count; i++)
				{
					sb.Append(Buckets[i].ToXMLString(PreferredPrefix,"Buckets"));
				}
			}
			if(CartTotalAmt != null)
			{
				sb.Append(CartTotalAmt.ToXMLString(PreferredPrefix,"CartTotalAmt"));
			}
			if(RequestDetails != null)
			{
				sb.Append(RequestDetails.ToXMLString(PreferredPrefix,"RequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetIncentiveEvaluationResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private List<IncentiveDetailType> incentiveDetailsField = new List<IncentiveDetailType>();
		public List<IncentiveDetailType> IncentiveDetails
		{
			get
			{
				return this.incentiveDetailsField;
			}
			set
			{
				this.incentiveDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string requestIdField;
		public string RequestId
		{
			get
			{
				return this.requestIdField;
			}
			set
			{
				this.requestIdField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetIncentiveEvaluationResponseDetailsType()
	 	{
		}


		public GetIncentiveEvaluationResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'IncentiveDetails']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.IncentiveDetails.Add(new IncentiveDetailType(subNode));
				}
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RequestId']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RequestId = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *The total cost of the order to the customer. If shipping
      *cost and tax charges are known, include them in OrderTotal;
      *if not, OrderTotal should be the current sub-total of the
      *order. You must set the currencyID attribute to one of the
      *three-character currency codes for any of the supported
      *PayPal currencies. Limitations: Must not exceed $10,000 USD
      *in any currency. No currency symbol. Decimal separator must
      *be a period (.), and the thousands separator must be a comma
      *(,). 
      */
	public partial class SetExpressCheckoutRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BasicAmountType orderTotalField;
		public BasicAmountType OrderTotal
		{
			get
			{
				return this.orderTotalField;
			}
			set
			{
				this.orderTotalField = value;
			}
		}
		

		/**
          *
		  */
		private string returnURLField;
		public string ReturnURL
		{
			get
			{
				return this.returnURLField;
			}
			set
			{
				this.returnURLField = value;
			}
		}
		

		/**
          *
		  */
		private string cancelURLField;
		public string CancelURL
		{
			get
			{
				return this.cancelURLField;
			}
			set
			{
				this.cancelURLField = value;
			}
		}
		

		/**
          *
		  */
		private string trackingImageURLField;
		public string TrackingImageURL
		{
			get
			{
				return this.trackingImageURLField;
			}
			set
			{
				this.trackingImageURLField = value;
			}
		}
		

		/**
          *
		  */
		private string giropaySuccessURLField;
		public string giropaySuccessURL
		{
			get
			{
				return this.giropaySuccessURLField;
			}
			set
			{
				this.giropaySuccessURLField = value;
			}
		}
		

		/**
          *
		  */
		private string giropayCancelURLField;
		public string giropayCancelURL
		{
			get
			{
				return this.giropayCancelURLField;
			}
			set
			{
				this.giropayCancelURLField = value;
			}
		}
		

		/**
          *
		  */
		private string banktxnPendingURLField;
		public string BanktxnPendingURL
		{
			get
			{
				return this.banktxnPendingURLField;
			}
			set
			{
				this.banktxnPendingURLField = value;
			}
		}
		

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType maxAmountField;
		public BasicAmountType MaxAmount
		{
			get
			{
				return this.maxAmountField;
			}
			set
			{
				this.maxAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string orderDescriptionField;
		public string OrderDescription
		{
			get
			{
				return this.orderDescriptionField;
			}
			set
			{
				this.orderDescriptionField = value;
			}
		}
		

		/**
          *
		  */
		private string customField;
		public string Custom
		{
			get
			{
				return this.customField;
			}
			set
			{
				this.customField = value;
			}
		}
		

		/**
          *
		  */
		private string invoiceIDField;
		public string InvoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/**
          *
		  */
		private string reqConfirmShippingField;
		public string ReqConfirmShipping
		{
			get
			{
				return this.reqConfirmShippingField;
			}
			set
			{
				this.reqConfirmShippingField = value;
			}
		}
		

		/**
          *
		  */
		private string reqBillingAddressField;
		public string ReqBillingAddress
		{
			get
			{
				return this.reqBillingAddressField;
			}
			set
			{
				this.reqBillingAddressField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType billingAddressField;
		public AddressType BillingAddress
		{
			get
			{
				return this.billingAddressField;
			}
			set
			{
				this.billingAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string noShippingField;
		public string NoShipping
		{
			get
			{
				return this.noShippingField;
			}
			set
			{
				this.noShippingField = value;
			}
		}
		

		/**
          *
		  */
		private string addressOverrideField;
		public string AddressOverride
		{
			get
			{
				return this.addressOverrideField;
			}
			set
			{
				this.addressOverrideField = value;
			}
		}
		

		/**
          *
		  */
		private string localeCodeField;
		public string LocaleCode
		{
			get
			{
				return this.localeCodeField;
			}
			set
			{
				this.localeCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string pageStyleField;
		public string PageStyle
		{
			get
			{
				return this.pageStyleField;
			}
			set
			{
				this.pageStyleField = value;
			}
		}
		

		/**
          *
		  */
		private string cppHeaderImageField;
		public string cppHeaderImage
		{
			get
			{
				return this.cppHeaderImageField;
			}
			set
			{
				this.cppHeaderImageField = value;
			}
		}
		

		/**
          *
		  */
		private string cppHeaderBorderColorField;
		public string cppHeaderBorderColor
		{
			get
			{
				return this.cppHeaderBorderColorField;
			}
			set
			{
				this.cppHeaderBorderColorField = value;
			}
		}
		

		/**
          *
		  */
		private string cppHeaderBackColorField;
		public string cppHeaderBackColor
		{
			get
			{
				return this.cppHeaderBackColorField;
			}
			set
			{
				this.cppHeaderBackColorField = value;
			}
		}
		

		/**
          *
		  */
		private string cppPayflowColorField;
		public string cppPayflowColor
		{
			get
			{
				return this.cppPayflowColorField;
			}
			set
			{
				this.cppPayflowColorField = value;
			}
		}
		

		/**
          *
		  */
		private string cppCartBorderColorField;
		public string cppCartBorderColor
		{
			get
			{
				return this.cppCartBorderColorField;
			}
			set
			{
				this.cppCartBorderColorField = value;
			}
		}
		

		/**
          *
		  */
		private string cppLogoImageField;
		public string cppLogoImage
		{
			get
			{
				return this.cppLogoImageField;
			}
			set
			{
				this.cppLogoImageField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType addressField;
		public AddressType Address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentActionCodeType? paymentActionField;
		public PaymentActionCodeType? PaymentAction
		{
			get
			{
				return this.paymentActionField;
			}
			set
			{
				this.paymentActionField = value;
			}
		}
		

		/**
          *
		  */
		private SolutionTypeType? solutionTypeField;
		public SolutionTypeType? SolutionType
		{
			get
			{
				return this.solutionTypeField;
			}
			set
			{
				this.solutionTypeField = value;
			}
		}
		

		/**
          *
		  */
		private LandingPageType? landingPageField;
		public LandingPageType? LandingPage
		{
			get
			{
				return this.landingPageField;
			}
			set
			{
				this.landingPageField = value;
			}
		}
		

		/**
          *
		  */
		private string buyerEmailField;
		public string BuyerEmail
		{
			get
			{
				return this.buyerEmailField;
			}
			set
			{
				this.buyerEmailField = value;
			}
		}
		

		/**
          *
		  */
		private ChannelType? channelTypeField;
		public ChannelType? ChannelType
		{
			get
			{
				return this.channelTypeField;
			}
			set
			{
				this.channelTypeField = value;
			}
		}
		

		/**
          *
		  */
		private List<BillingAgreementDetailsType> billingAgreementDetailsField = new List<BillingAgreementDetailsType>();
		public List<BillingAgreementDetailsType> BillingAgreementDetails
		{
			get
			{
				return this.billingAgreementDetailsField;
			}
			set
			{
				this.billingAgreementDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> promoCodesField = new List<string>();
		public List<string> PromoCodes
		{
			get
			{
				return this.promoCodesField;
			}
			set
			{
				this.promoCodesField = value;
			}
		}
		

		/**
          *
		  */
		private string payPalCheckOutBtnTypeField;
		public string PayPalCheckOutBtnType
		{
			get
			{
				return this.payPalCheckOutBtnTypeField;
			}
			set
			{
				this.payPalCheckOutBtnTypeField = value;
			}
		}
		

		/**
          *
		  */
		private ProductCategoryType? productCategoryField;
		public ProductCategoryType? ProductCategory
		{
			get
			{
				return this.productCategoryField;
			}
			set
			{
				this.productCategoryField = value;
			}
		}
		

		/**
          *
		  */
		private ShippingServiceCodeType? shippingMethodField;
		public ShippingServiceCodeType? ShippingMethod
		{
			get
			{
				return this.shippingMethodField;
			}
			set
			{
				this.shippingMethodField = value;
			}
		}
		

		/**
          *
		  */
		private string profileAddressChangeDateField;
		public string ProfileAddressChangeDate
		{
			get
			{
				return this.profileAddressChangeDateField;
			}
			set
			{
				this.profileAddressChangeDateField = value;
			}
		}
		

		/**
          *
		  */
		private string allowNoteField;
		public string AllowNote
		{
			get
			{
				return this.allowNoteField;
			}
			set
			{
				this.allowNoteField = value;
			}
		}
		

		/**
          *
		  */
		private FundingSourceDetailsType fundingSourceDetailsField;
		public FundingSourceDetailsType FundingSourceDetails
		{
			get
			{
				return this.fundingSourceDetailsField;
			}
			set
			{
				this.fundingSourceDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string brandNameField;
		public string BrandName
		{
			get
			{
				return this.brandNameField;
			}
			set
			{
				this.brandNameField = value;
			}
		}
		

		/**
          *
		  */
		private string callbackURLField;
		public string CallbackURL
		{
			get
			{
				return this.callbackURLField;
			}
			set
			{
				this.callbackURLField = value;
			}
		}
		

		/**
          *
		  */
		private EnhancedCheckoutDataType enhancedCheckoutDataField;
		public EnhancedCheckoutDataType EnhancedCheckoutData
		{
			get
			{
				return this.enhancedCheckoutDataField;
			}
			set
			{
				this.enhancedCheckoutDataField = value;
			}
		}
		

		/**
          *
		  */
		private List<OtherPaymentMethodDetailsType> otherPaymentMethodsField = new List<OtherPaymentMethodDetailsType>();
		public List<OtherPaymentMethodDetailsType> OtherPaymentMethods
		{
			get
			{
				return this.otherPaymentMethodsField;
			}
			set
			{
				this.otherPaymentMethodsField = value;
			}
		}
		

		/**
          *
		  */
		private BuyerDetailsType buyerDetailsField;
		public BuyerDetailsType BuyerDetails
		{
			get
			{
				return this.buyerDetailsField;
			}
			set
			{
				this.buyerDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private List<PaymentDetailsType> paymentDetailsField = new List<PaymentDetailsType>();
		public List<PaymentDetailsType> PaymentDetails
		{
			get
			{
				return this.paymentDetailsField;
			}
			set
			{
				this.paymentDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private List<ShippingOptionType> flatRateShippingOptionsField = new List<ShippingOptionType>();
		public List<ShippingOptionType> FlatRateShippingOptions
		{
			get
			{
				return this.flatRateShippingOptionsField;
			}
			set
			{
				this.flatRateShippingOptionsField = value;
			}
		}
		

		/**
          *
		  */
		private string callbackTimeoutField;
		public string CallbackTimeout
		{
			get
			{
				return this.callbackTimeoutField;
			}
			set
			{
				this.callbackTimeoutField = value;
			}
		}
		

		/**
          *
		  */
		private string callbackVersionField;
		public string CallbackVersion
		{
			get
			{
				return this.callbackVersionField;
			}
			set
			{
				this.callbackVersionField = value;
			}
		}
		

		/**
          *
		  */
		private string customerServiceNumberField;
		public string CustomerServiceNumber
		{
			get
			{
				return this.customerServiceNumberField;
			}
			set
			{
				this.customerServiceNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string giftMessageEnableField;
		public string GiftMessageEnable
		{
			get
			{
				return this.giftMessageEnableField;
			}
			set
			{
				this.giftMessageEnableField = value;
			}
		}
		

		/**
          *
		  */
		private string giftReceiptEnableField;
		public string GiftReceiptEnable
		{
			get
			{
				return this.giftReceiptEnableField;
			}
			set
			{
				this.giftReceiptEnableField = value;
			}
		}
		

		/**
          *
		  */
		private string giftWrapEnableField;
		public string GiftWrapEnable
		{
			get
			{
				return this.giftWrapEnableField;
			}
			set
			{
				this.giftWrapEnableField = value;
			}
		}
		

		/**
          *
		  */
		private string giftWrapNameField;
		public string GiftWrapName
		{
			get
			{
				return this.giftWrapNameField;
			}
			set
			{
				this.giftWrapNameField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType giftWrapAmountField;
		public BasicAmountType GiftWrapAmount
		{
			get
			{
				return this.giftWrapAmountField;
			}
			set
			{
				this.giftWrapAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string buyerEmailOptInEnableField;
		public string BuyerEmailOptInEnable
		{
			get
			{
				return this.buyerEmailOptInEnableField;
			}
			set
			{
				this.buyerEmailOptInEnableField = value;
			}
		}
		

		/**
          *
		  */
		private string surveyEnableField;
		public string SurveyEnable
		{
			get
			{
				return this.surveyEnableField;
			}
			set
			{
				this.surveyEnableField = value;
			}
		}
		

		/**
          *
		  */
		private string surveyQuestionField;
		public string SurveyQuestion
		{
			get
			{
				return this.surveyQuestionField;
			}
			set
			{
				this.surveyQuestionField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> surveyChoiceField = new List<string>();
		public List<string> SurveyChoice
		{
			get
			{
				return this.surveyChoiceField;
			}
			set
			{
				this.surveyChoiceField = value;
			}
		}
		

		/**
          *
		  */
		private TotalType? totalTypeField;
		public TotalType? TotalType
		{
			get
			{
				return this.totalTypeField;
			}
			set
			{
				this.totalTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string noteToBuyerField;
		public string NoteToBuyer
		{
			get
			{
				return this.noteToBuyerField;
			}
			set
			{
				this.noteToBuyerField = value;
			}
		}
		

		/**
          *
		  */
		private List<IncentiveInfoType> incentivesField = new List<IncentiveInfoType>();
		public List<IncentiveInfoType> Incentives
		{
			get
			{
				return this.incentivesField;
			}
			set
			{
				this.incentivesField = value;
			}
		}
		

		/**
          *
		  */
		private string reqInstrumentDetailsField;
		public string ReqInstrumentDetails
		{
			get
			{
				return this.reqInstrumentDetailsField;
			}
			set
			{
				this.reqInstrumentDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private ExternalRememberMeOptInDetailsType externalRememberMeOptInDetailsField;
		public ExternalRememberMeOptInDetailsType ExternalRememberMeOptInDetails
		{
			get
			{
				return this.externalRememberMeOptInDetailsField;
			}
			set
			{
				this.externalRememberMeOptInDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private FlowControlDetailsType flowControlDetailsField;
		public FlowControlDetailsType FlowControlDetails
		{
			get
			{
				return this.flowControlDetailsField;
			}
			set
			{
				this.flowControlDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private DisplayControlDetailsType displayControlDetailsField;
		public DisplayControlDetailsType DisplayControlDetails
		{
			get
			{
				return this.displayControlDetailsField;
			}
			set
			{
				this.displayControlDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private ExternalPartnerTrackingDetailsType externalPartnerTrackingDetailsField;
		public ExternalPartnerTrackingDetailsType ExternalPartnerTrackingDetails
		{
			get
			{
				return this.externalPartnerTrackingDetailsField;
			}
			set
			{
				this.externalPartnerTrackingDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private List<CoupledBucketsType> coupledBucketsField = new List<CoupledBucketsType>();
		public List<CoupledBucketsType> CoupledBuckets
		{
			get
			{
				return this.coupledBucketsField;
			}
			set
			{
				this.coupledBucketsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SetExpressCheckoutRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(OrderTotal != null)
			{
				sb.Append(OrderTotal.ToXMLString(PreferredPrefix,"OrderTotal"));
			}
			if(ReturnURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReturnURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReturnURL));
				sb.Append("</").Append(PreferredPrefix).Append(":ReturnURL>");
			}
			if(CancelURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CancelURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CancelURL));
				sb.Append("</").Append(PreferredPrefix).Append(":CancelURL>");
			}
			if(TrackingImageURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TrackingImageURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TrackingImageURL));
				sb.Append("</").Append(PreferredPrefix).Append(":TrackingImageURL>");
			}
			if(giropaySuccessURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":giropaySuccessURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.giropaySuccessURL));
				sb.Append("</").Append(PreferredPrefix).Append(":giropaySuccessURL>");
			}
			if(giropayCancelURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":giropayCancelURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.giropayCancelURL));
				sb.Append("</").Append(PreferredPrefix).Append(":giropayCancelURL>");
			}
			if(BanktxnPendingURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BanktxnPendingURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BanktxnPendingURL));
				sb.Append("</").Append(PreferredPrefix).Append(":BanktxnPendingURL>");
			}
			if(Token != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Token>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Token));
				sb.Append("</").Append(PreferredPrefix).Append(":Token>");
			}
			if(MaxAmount != null)
			{
				sb.Append(MaxAmount.ToXMLString(PreferredPrefix,"MaxAmount"));
			}
			if(OrderDescription != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OrderDescription>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OrderDescription));
				sb.Append("</").Append(PreferredPrefix).Append(":OrderDescription>");
			}
			if(Custom != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Custom>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Custom));
				sb.Append("</").Append(PreferredPrefix).Append(":Custom>");
			}
			if(InvoiceID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":InvoiceID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.InvoiceID));
				sb.Append("</").Append(PreferredPrefix).Append(":InvoiceID>");
			}
			if(ReqConfirmShipping != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReqConfirmShipping>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReqConfirmShipping));
				sb.Append("</").Append(PreferredPrefix).Append(":ReqConfirmShipping>");
			}
			if(ReqBillingAddress != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReqBillingAddress>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReqBillingAddress));
				sb.Append("</").Append(PreferredPrefix).Append(":ReqBillingAddress>");
			}
			if(BillingAddress != null)
			{
				sb.Append(BillingAddress.ToXMLString(PreferredPrefix,"BillingAddress"));
			}
			if(NoShipping != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":NoShipping>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.NoShipping));
				sb.Append("</").Append(PreferredPrefix).Append(":NoShipping>");
			}
			if(AddressOverride != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AddressOverride>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.AddressOverride));
				sb.Append("</").Append(PreferredPrefix).Append(":AddressOverride>");
			}
			if(LocaleCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":LocaleCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.LocaleCode));
				sb.Append("</").Append(PreferredPrefix).Append(":LocaleCode>");
			}
			if(PageStyle != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PageStyle>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PageStyle));
				sb.Append("</").Append(PreferredPrefix).Append(":PageStyle>");
			}
			if(cppHeaderImage != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-header-image>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppHeaderImage));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-header-image>");
			}
			if(cppHeaderBorderColor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-header-border-color>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppHeaderBorderColor));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-header-border-color>");
			}
			if(cppHeaderBackColor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-header-back-color>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppHeaderBackColor));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-header-back-color>");
			}
			if(cppPayflowColor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-payflow-color>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppPayflowColor));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-payflow-color>");
			}
			if(cppCartBorderColor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-cart-border-color>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppCartBorderColor));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-cart-border-color>");
			}
			if(cppLogoImage != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-logo-image>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppLogoImage));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-logo-image>");
			}
			if(Address != null)
			{
				sb.Append(Address.ToXMLString(PreferredPrefix,"Address"));
			}
			if(PaymentAction != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PaymentAction>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.PaymentAction)));
				sb.Append("</").Append(PreferredPrefix).Append(":PaymentAction>");
			}
			if(SolutionType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SolutionType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.SolutionType)));
				sb.Append("</").Append(PreferredPrefix).Append(":SolutionType>");
			}
			if(LandingPage != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":LandingPage>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.LandingPage)));
				sb.Append("</").Append(PreferredPrefix).Append(":LandingPage>");
			}
			if(BuyerEmail != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BuyerEmail>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BuyerEmail));
				sb.Append("</").Append(PreferredPrefix).Append(":BuyerEmail>");
			}
			if(ChannelType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ChannelType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ChannelType)));
				sb.Append("</").Append(PreferredPrefix).Append(":ChannelType>");
			}
			if(BillingAgreementDetails != null)
			{
				for(int i = 0; i < BillingAgreementDetails.Count; i++)
				{
					sb.Append(BillingAgreementDetails[i].ToXMLString(PreferredPrefix,"BillingAgreementDetails"));
				}
			}
			if(PromoCodes != null)
			{
				for(int i = 0; i < PromoCodes.Count; i++)
				{
					sb.Append("<").Append(PreferredPrefix).Append(":PromoCodes>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PromoCodes[i]));
					sb.Append("</").Append(PreferredPrefix).Append(":PromoCodes>");
				}
			}
			if(PayPalCheckOutBtnType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PayPalCheckOutBtnType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PayPalCheckOutBtnType));
				sb.Append("</").Append(PreferredPrefix).Append(":PayPalCheckOutBtnType>");
			}
			if(ProductCategory != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ProductCategory>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ProductCategory)));
				sb.Append("</").Append(PreferredPrefix).Append(":ProductCategory>");
			}
			if(ShippingMethod != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ShippingMethod>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ShippingMethod)));
				sb.Append("</").Append(PreferredPrefix).Append(":ShippingMethod>");
			}
			if(ProfileAddressChangeDate != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ProfileAddressChangeDate>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ProfileAddressChangeDate));
				sb.Append("</").Append(PreferredPrefix).Append(":ProfileAddressChangeDate>");
			}
			if(AllowNote != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AllowNote>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.AllowNote));
				sb.Append("</").Append(PreferredPrefix).Append(":AllowNote>");
			}
			if(FundingSourceDetails != null)
			{
				sb.Append(FundingSourceDetails.ToXMLString(PreferredPrefix,"FundingSourceDetails"));
			}
			if(BrandName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BrandName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BrandName));
				sb.Append("</").Append(PreferredPrefix).Append(":BrandName>");
			}
			if(CallbackURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CallbackURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CallbackURL));
				sb.Append("</").Append(PreferredPrefix).Append(":CallbackURL>");
			}
			if(EnhancedCheckoutData != null)
			{
				sb.Append(EnhancedCheckoutData.ToXMLString(PreferredPrefix,"EnhancedCheckoutData"));
			}
			if(OtherPaymentMethods != null)
			{
				for(int i = 0; i < OtherPaymentMethods.Count; i++)
				{
					sb.Append(OtherPaymentMethods[i].ToXMLString(PreferredPrefix,"OtherPaymentMethods"));
				}
			}
			if(BuyerDetails != null)
			{
				sb.Append(BuyerDetails.ToXMLString(PreferredPrefix,"BuyerDetails"));
			}
			if(PaymentDetails != null)
			{
				for(int i = 0; i < PaymentDetails.Count; i++)
				{
					sb.Append(PaymentDetails[i].ToXMLString(PreferredPrefix,"PaymentDetails"));
				}
			}
			if(FlatRateShippingOptions != null)
			{
				for(int i = 0; i < FlatRateShippingOptions.Count; i++)
				{
					sb.Append(FlatRateShippingOptions[i].ToXMLString(PreferredPrefix,"FlatRateShippingOptions"));
				}
			}
			if(CallbackTimeout != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CallbackTimeout>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CallbackTimeout));
				sb.Append("</").Append(PreferredPrefix).Append(":CallbackTimeout>");
			}
			if(CallbackVersion != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CallbackVersion>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CallbackVersion));
				sb.Append("</").Append(PreferredPrefix).Append(":CallbackVersion>");
			}
			if(CustomerServiceNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CustomerServiceNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CustomerServiceNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":CustomerServiceNumber>");
			}
			if(GiftMessageEnable != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":GiftMessageEnable>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.GiftMessageEnable));
				sb.Append("</").Append(PreferredPrefix).Append(":GiftMessageEnable>");
			}
			if(GiftReceiptEnable != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":GiftReceiptEnable>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.GiftReceiptEnable));
				sb.Append("</").Append(PreferredPrefix).Append(":GiftReceiptEnable>");
			}
			if(GiftWrapEnable != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":GiftWrapEnable>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.GiftWrapEnable));
				sb.Append("</").Append(PreferredPrefix).Append(":GiftWrapEnable>");
			}
			if(GiftWrapName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":GiftWrapName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.GiftWrapName));
				sb.Append("</").Append(PreferredPrefix).Append(":GiftWrapName>");
			}
			if(GiftWrapAmount != null)
			{
				sb.Append(GiftWrapAmount.ToXMLString(PreferredPrefix,"GiftWrapAmount"));
			}
			if(BuyerEmailOptInEnable != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BuyerEmailOptInEnable>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BuyerEmailOptInEnable));
				sb.Append("</").Append(PreferredPrefix).Append(":BuyerEmailOptInEnable>");
			}
			if(SurveyEnable != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SurveyEnable>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SurveyEnable));
				sb.Append("</").Append(PreferredPrefix).Append(":SurveyEnable>");
			}
			if(SurveyQuestion != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SurveyQuestion>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SurveyQuestion));
				sb.Append("</").Append(PreferredPrefix).Append(":SurveyQuestion>");
			}
			if(SurveyChoice != null)
			{
				for(int i = 0; i < SurveyChoice.Count; i++)
				{
					sb.Append("<").Append(PreferredPrefix).Append(":SurveyChoice>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SurveyChoice[i]));
					sb.Append("</").Append(PreferredPrefix).Append(":SurveyChoice>");
				}
			}
			if(TotalType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TotalType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.TotalType)));
				sb.Append("</").Append(PreferredPrefix).Append(":TotalType>");
			}
			if(NoteToBuyer != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":NoteToBuyer>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.NoteToBuyer));
				sb.Append("</").Append(PreferredPrefix).Append(":NoteToBuyer>");
			}
			if(Incentives != null)
			{
				for(int i = 0; i < Incentives.Count; i++)
				{
					sb.Append(Incentives[i].ToXMLString(PreferredPrefix,"Incentives"));
				}
			}
			if(ReqInstrumentDetails != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReqInstrumentDetails>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReqInstrumentDetails));
				sb.Append("</").Append(PreferredPrefix).Append(":ReqInstrumentDetails>");
			}
			if(ExternalRememberMeOptInDetails != null)
			{
				sb.Append(ExternalRememberMeOptInDetails.ToXMLString(PreferredPrefix,"ExternalRememberMeOptInDetails"));
			}
			if(FlowControlDetails != null)
			{
				sb.Append(FlowControlDetails.ToXMLString(PreferredPrefix,"FlowControlDetails"));
			}
			if(DisplayControlDetails != null)
			{
				sb.Append(DisplayControlDetails.ToXMLString(PreferredPrefix,"DisplayControlDetails"));
			}
			if(ExternalPartnerTrackingDetails != null)
			{
				sb.Append(ExternalPartnerTrackingDetails.ToXMLString(PreferredPrefix,"ExternalPartnerTrackingDetails"));
			}
			if(CoupledBuckets != null)
			{
				for(int i = 0; i < CoupledBuckets.Count; i++)
				{
					sb.Append(CoupledBuckets[i].ToXMLString(PreferredPrefix,"CoupledBuckets"));
				}
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *On your first invocation of
      *ExecuteCheckoutOperationsRequest, the value of this token is
      *returned by ExecuteCheckoutOperationsResponse. Optional
      *Include this element and its value only if you want to
      *modify an existing checkout session with another invocation
      *of ExecuteCheckoutOperationsRequest; for example, if you
      *want the customer to edit his shipping address on PayPal.
      *Character length and limitations: 20 single-byte characters 
      */
	public partial class ExecuteCheckoutOperationsRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
          *
		  */
		private SetDataRequestType setDataRequestField;
		public SetDataRequestType SetDataRequest
		{
			get
			{
				return this.setDataRequestField;
			}
			set
			{
				this.setDataRequestField = value;
			}
		}
		

		/**
          *
		  */
		private AuthorizationRequestType authorizationRequestField;
		public AuthorizationRequestType AuthorizationRequest
		{
			get
			{
				return this.authorizationRequestField;
			}
			set
			{
				this.authorizationRequestField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public ExecuteCheckoutOperationsRequestDetailsType(SetDataRequestType setDataRequest)
	 	{
			this.SetDataRequest = setDataRequest;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public ExecuteCheckoutOperationsRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Token != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Token>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Token));
				sb.Append("</").Append(PreferredPrefix).Append(":Token>");
			}
			if(SetDataRequest != null)
			{
				sb.Append(SetDataRequest.ToXMLString(PreferredPrefix,"SetDataRequest"));
			}
			if(AuthorizationRequest != null)
			{
				sb.Append(AuthorizationRequest.ToXMLString(PreferredPrefix,"AuthorizationRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Details about Billing Agreements requested to be created. 
      */
	public partial class SetDataRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private List<BillingApprovalDetailsType> billingApprovalDetailsField = new List<BillingApprovalDetailsType>();
		public List<BillingApprovalDetailsType> BillingApprovalDetails
		{
			get
			{
				return this.billingApprovalDetailsField;
			}
			set
			{
				this.billingApprovalDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private BuyerDetailType buyerDetailField;
		public BuyerDetailType BuyerDetail
		{
			get
			{
				return this.buyerDetailField;
			}
			set
			{
				this.buyerDetailField = value;
			}
		}
		

		/**
          *
		  */
		private InfoSharingDirectivesType infoSharingDirectivesField;
		public InfoSharingDirectivesType InfoSharingDirectives
		{
			get
			{
				return this.infoSharingDirectivesField;
			}
			set
			{
				this.infoSharingDirectivesField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SetDataRequestType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BillingApprovalDetails != null)
			{
				for(int i = 0; i < BillingApprovalDetails.Count; i++)
				{
					sb.Append(BillingApprovalDetails[i].ToXMLString(PreferredPrefix,"BillingApprovalDetails"));
				}
			}
			if(BuyerDetail != null)
			{
				sb.Append(BuyerDetail.ToXMLString(PreferredPrefix,"BuyerDetail"));
			}
			if(InfoSharingDirectives != null)
			{
				sb.Append(InfoSharingDirectives.ToXMLString(PreferredPrefix,"InfoSharingDirectives"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class AuthorizationRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private bool? isRequestedField;
		public bool? IsRequested
		{
			get
			{
				return this.isRequestedField;
			}
			set
			{
				this.isRequestedField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public AuthorizationRequestType(bool? isRequested)
	 	{
			this.IsRequested = isRequested;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public AuthorizationRequestType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(IsRequested != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":IsRequested>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.IsRequested.ToString().ToLower()));
				sb.Append("</").Append(PreferredPrefix).Append(":IsRequested>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *The Type of Approval requested - Billing Agreement or
      *Profile 
      */
	public partial class BillingApprovalDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private ApprovalTypeType? approvalTypeField;
		public ApprovalTypeType? ApprovalType
		{
			get
			{
				return this.approvalTypeField;
			}
			set
			{
				this.approvalTypeField = value;
			}
		}
		

		/**
          *
		  */
		private ApprovalSubTypeType? approvalSubTypeField;
		public ApprovalSubTypeType? ApprovalSubType
		{
			get
			{
				return this.approvalSubTypeField;
			}
			set
			{
				this.approvalSubTypeField = value;
			}
		}
		

		/**
          *
		  */
		private OrderDetailsType orderDetailsField;
		public OrderDetailsType OrderDetails
		{
			get
			{
				return this.orderDetailsField;
			}
			set
			{
				this.orderDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentDirectivesType paymentDirectivesField;
		public PaymentDirectivesType PaymentDirectives
		{
			get
			{
				return this.paymentDirectivesField;
			}
			set
			{
				this.paymentDirectivesField = value;
			}
		}
		

		/**
          *
		  */
		private string customField;
		public string Custom
		{
			get
			{
				return this.customField;
			}
			set
			{
				this.customField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public BillingApprovalDetailsType(ApprovalTypeType? approvalType)
	 	{
			this.ApprovalType = approvalType;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public BillingApprovalDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ApprovalType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ApprovalType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ApprovalType)));
				sb.Append("</").Append(PreferredPrefix).Append(":ApprovalType>");
			}
			if(ApprovalSubType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ApprovalSubType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ApprovalSubType)));
				sb.Append("</").Append(PreferredPrefix).Append(":ApprovalSubType>");
			}
			if(OrderDetails != null)
			{
				sb.Append(OrderDetails.ToXMLString(PreferredPrefix,"OrderDetails"));
			}
			if(PaymentDirectives != null)
			{
				sb.Append(PaymentDirectives.ToXMLString(PreferredPrefix,"PaymentDirectives"));
			}
			if(Custom != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Custom>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Custom));
				sb.Append("</").Append(PreferredPrefix).Append(":Custom>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *If Billing Address should be returned in
      *GetExpressCheckoutDetails response, this parameter should be
      *set to yes here 
      */
	public partial class InfoSharingDirectivesType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string reqBillingAddressField;
		public string ReqBillingAddress
		{
			get
			{
				return this.reqBillingAddressField;
			}
			set
			{
				this.reqBillingAddressField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public InfoSharingDirectivesType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ReqBillingAddress != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReqBillingAddress>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReqBillingAddress));
				sb.Append("</").Append(PreferredPrefix).Append(":ReqBillingAddress>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Description of the Order. 
      */
	public partial class OrderDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string descriptionField;
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType maxAmountField;
		public BasicAmountType MaxAmount
		{
			get
			{
				return this.maxAmountField;
			}
			set
			{
				this.maxAmountField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public OrderDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Description != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Description>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Description));
				sb.Append("</").Append(PreferredPrefix).Append(":Description>");
			}
			if(MaxAmount != null)
			{
				sb.Append(MaxAmount.ToXMLString(PreferredPrefix,"MaxAmount"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Type of the Payment is it Instant or Echeck or Any. 
      */
	public partial class PaymentDirectivesType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private MerchantPullPaymentCodeType? paymentTypeField;
		public MerchantPullPaymentCodeType? PaymentType
		{
			get
			{
				return this.paymentTypeField;
			}
			set
			{
				this.paymentTypeField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PaymentDirectivesType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(PaymentType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PaymentType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.PaymentType)));
				sb.Append("</").Append(PreferredPrefix).Append(":PaymentType>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Information that is used to indentify the Buyer. This is
      *used for auto authorization. Mandatory if Authorization is
      *requested. 
      */
	public partial class BuyerDetailType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private IdentificationInfoType identificationInfoField;
		public IdentificationInfoType IdentificationInfo
		{
			get
			{
				return this.identificationInfoField;
			}
			set
			{
				this.identificationInfoField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BuyerDetailType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(IdentificationInfo != null)
			{
				sb.Append(IdentificationInfo.ToXMLString(PreferredPrefix,"IdentificationInfo"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Mobile specific buyer identification. 
      */
	public partial class IdentificationInfoType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private MobileIDInfoType mobileIDInfoField;
		public MobileIDInfoType MobileIDInfo
		{
			get
			{
				return this.mobileIDInfoField;
			}
			set
			{
				this.mobileIDInfoField = value;
			}
		}
		

		/**
          *
		  */
		private RememberMeIDInfoType rememberMeIDInfoField;
		public RememberMeIDInfoType RememberMeIDInfo
		{
			get
			{
				return this.rememberMeIDInfoField;
			}
			set
			{
				this.rememberMeIDInfoField = value;
			}
		}
		

		/**
          *
		  */
		private IdentityTokenInfoType identityTokenInfoField;
		public IdentityTokenInfoType IdentityTokenInfo
		{
			get
			{
				return this.identityTokenInfoField;
			}
			set
			{
				this.identityTokenInfoField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public IdentificationInfoType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(MobileIDInfo != null)
			{
				sb.Append(MobileIDInfo.ToXMLString(PreferredPrefix,"MobileIDInfo"));
			}
			if(RememberMeIDInfo != null)
			{
				sb.Append(RememberMeIDInfo.ToXMLString(PreferredPrefix,"RememberMeIDInfo"));
			}
			if(IdentityTokenInfo != null)
			{
				sb.Append(IdentityTokenInfo.ToXMLString(PreferredPrefix,"IdentityTokenInfo"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *The Session token returned during buyer authentication. 
      */
	public partial class MobileIDInfoType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string sessionTokenField;
		public string SessionToken
		{
			get
			{
				return this.sessionTokenField;
			}
			set
			{
				this.sessionTokenField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public MobileIDInfoType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(SessionToken != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SessionToken>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SessionToken));
				sb.Append("</").Append(PreferredPrefix).Append(":SessionToken>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *External remember-me ID returned by
      *GetExpressCheckoutDetails on successful opt-in. The
      *ExternalRememberMeID is a 17-character alphanumeric
      *(encrypted) string that identifies the buyer's remembered
      *login with a merchant and has meaning only to the merchant.
      *If present, requests that the web flow attempt bypass of
      *login. 
      */
	public partial class RememberMeIDInfoType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string externalRememberMeIDField;
		public string ExternalRememberMeID
		{
			get
			{
				return this.externalRememberMeIDField;
			}
			set
			{
				this.externalRememberMeIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public RememberMeIDInfoType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ExternalRememberMeID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ExternalRememberMeID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ExternalRememberMeID));
				sb.Append("</").Append(PreferredPrefix).Append(":ExternalRememberMeID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Identity Access token from merchant 
      */
	public partial class IdentityTokenInfoType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string accessTokenField;
		public string AccessToken
		{
			get
			{
				return this.accessTokenField;
			}
			set
			{
				this.accessTokenField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public IdentityTokenInfoType(string accessToken)
	 	{
			this.AccessToken = accessToken;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public IdentityTokenInfoType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(AccessToken != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AccessToken>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.AccessToken));
				sb.Append("</").Append(PreferredPrefix).Append(":AccessToken>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Allowable values: 0,1 The value 1 indicates that the
      *customer can accept push funding, and 0 means they cannot.
      *Optional Character length and limitations: One single-byte
      *numeric character. 
      */
	public partial class FundingSourceDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string allowPushFundingField;
		public string AllowPushFunding
		{
			get
			{
				return this.allowPushFundingField;
			}
			set
			{
				this.allowPushFundingField = value;
			}
		}
		

		/**
          *
		  */
		private UserSelectedFundingSourceType? userSelectedFundingSourceField;
		public UserSelectedFundingSourceType? UserSelectedFundingSource
		{
			get
			{
				return this.userSelectedFundingSourceField;
			}
			set
			{
				this.userSelectedFundingSourceField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public FundingSourceDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(AllowPushFunding != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AllowPushFunding>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.AllowPushFunding));
				sb.Append("</").Append(PreferredPrefix).Append(":AllowPushFunding>");
			}
			if(UserSelectedFundingSource != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":UserSelectedFundingSource>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.UserSelectedFundingSource)));
				sb.Append("</").Append(PreferredPrefix).Append(":UserSelectedFundingSource>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class BillingAgreementDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BillingCodeType? billingTypeField;
		public BillingCodeType? BillingType
		{
			get
			{
				return this.billingTypeField;
			}
			set
			{
				this.billingTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string billingAgreementDescriptionField;
		public string BillingAgreementDescription
		{
			get
			{
				return this.billingAgreementDescriptionField;
			}
			set
			{
				this.billingAgreementDescriptionField = value;
			}
		}
		

		/**
          *
		  */
		private MerchantPullPaymentCodeType? paymentTypeField;
		public MerchantPullPaymentCodeType? PaymentType
		{
			get
			{
				return this.paymentTypeField;
			}
			set
			{
				this.paymentTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string billingAgreementCustomField;
		public string BillingAgreementCustom
		{
			get
			{
				return this.billingAgreementCustomField;
			}
			set
			{
				this.billingAgreementCustomField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public BillingAgreementDetailsType(BillingCodeType? billingType)
	 	{
			this.BillingType = billingType;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public BillingAgreementDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BillingType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BillingType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.BillingType)));
				sb.Append("</").Append(PreferredPrefix).Append(":BillingType>");
			}
			if(BillingAgreementDescription != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BillingAgreementDescription>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BillingAgreementDescription));
				sb.Append("</").Append(PreferredPrefix).Append(":BillingAgreementDescription>");
			}
			if(PaymentType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PaymentType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.PaymentType)));
				sb.Append("</").Append(PreferredPrefix).Append(":PaymentType>");
			}
			if(BillingAgreementCustom != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BillingAgreementCustom>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BillingAgreementCustom));
				sb.Append("</").Append(PreferredPrefix).Append(":BillingAgreementCustom>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *The timestamped token value that was returned by
      *SetExpressCheckoutResponse and passed on
      *GetExpressCheckoutDetailsRequest. Character length and
      *limitations: 20 single-byte characters 
      */
	public partial class GetExpressCheckoutDetailsResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
          *
		  */
		private PayerInfoType payerInfoField;
		public PayerInfoType PayerInfo
		{
			get
			{
				return this.payerInfoField;
			}
			set
			{
				this.payerInfoField = value;
			}
		}
		

		/**
          *
		  */
		private string customField;
		public string Custom
		{
			get
			{
				return this.customField;
			}
			set
			{
				this.customField = value;
			}
		}
		

		/**
          *
		  */
		private string invoiceIDField;
		public string InvoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/**
          *
		  */
		private string contactPhoneField;
		public string ContactPhone
		{
			get
			{
				return this.contactPhoneField;
			}
			set
			{
				this.contactPhoneField = value;
			}
		}
		

		/**
          *
		  */
		private bool? billingAgreementAcceptedStatusField;
		public bool? BillingAgreementAcceptedStatus
		{
			get
			{
				return this.billingAgreementAcceptedStatusField;
			}
			set
			{
				this.billingAgreementAcceptedStatusField = value;
			}
		}
		

		/**
          *
		  */
		private string redirectRequiredField;
		public string RedirectRequired
		{
			get
			{
				return this.redirectRequiredField;
			}
			set
			{
				this.redirectRequiredField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType billingAddressField;
		public AddressType BillingAddress
		{
			get
			{
				return this.billingAddressField;
			}
			set
			{
				this.billingAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string noteField;
		public string Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}
		

		/**
          *
		  */
		private string checkoutStatusField;
		public string CheckoutStatus
		{
			get
			{
				return this.checkoutStatusField;
			}
			set
			{
				this.checkoutStatusField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType payPalAdjustmentField;
		public BasicAmountType PayPalAdjustment
		{
			get
			{
				return this.payPalAdjustmentField;
			}
			set
			{
				this.payPalAdjustmentField = value;
			}
		}
		

		/**
          *
		  */
		private List<PaymentDetailsType> paymentDetailsField = new List<PaymentDetailsType>();
		public List<PaymentDetailsType> PaymentDetails
		{
			get
			{
				return this.paymentDetailsField;
			}
			set
			{
				this.paymentDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private UserSelectedOptionType userSelectedOptionsField;
		public UserSelectedOptionType UserSelectedOptions
		{
			get
			{
				return this.userSelectedOptionsField;
			}
			set
			{
				this.userSelectedOptionsField = value;
			}
		}
		

		/**
          *
		  */
		private List<IncentiveDetailsType> incentiveDetailsField = new List<IncentiveDetailsType>();
		public List<IncentiveDetailsType> IncentiveDetails
		{
			get
			{
				return this.incentiveDetailsField;
			}
			set
			{
				this.incentiveDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string giftMessageField;
		public string GiftMessage
		{
			get
			{
				return this.giftMessageField;
			}
			set
			{
				this.giftMessageField = value;
			}
		}
		

		/**
          *
		  */
		private string giftReceiptEnableField;
		public string GiftReceiptEnable
		{
			get
			{
				return this.giftReceiptEnableField;
			}
			set
			{
				this.giftReceiptEnableField = value;
			}
		}
		

		/**
          *
		  */
		private string giftWrapNameField;
		public string GiftWrapName
		{
			get
			{
				return this.giftWrapNameField;
			}
			set
			{
				this.giftWrapNameField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType giftWrapAmountField;
		public BasicAmountType GiftWrapAmount
		{
			get
			{
				return this.giftWrapAmountField;
			}
			set
			{
				this.giftWrapAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string buyerMarketingEmailField;
		public string BuyerMarketingEmail
		{
			get
			{
				return this.buyerMarketingEmailField;
			}
			set
			{
				this.buyerMarketingEmailField = value;
			}
		}
		

		/**
          *
		  */
		private string surveyQuestionField;
		public string SurveyQuestion
		{
			get
			{
				return this.surveyQuestionField;
			}
			set
			{
				this.surveyQuestionField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> surveyChoiceSelectedField = new List<string>();
		public List<string> SurveyChoiceSelected
		{
			get
			{
				return this.surveyChoiceSelectedField;
			}
			set
			{
				this.surveyChoiceSelectedField = value;
			}
		}
		

		/**
          *
		  */
		private List<PaymentRequestInfoType> paymentRequestInfoField = new List<PaymentRequestInfoType>();
		public List<PaymentRequestInfoType> PaymentRequestInfo
		{
			get
			{
				return this.paymentRequestInfoField;
			}
			set
			{
				this.paymentRequestInfoField = value;
			}
		}
		

		/**
          *
		  */
		private ExternalRememberMeStatusDetailsType externalRememberMeStatusDetailsField;
		public ExternalRememberMeStatusDetailsType ExternalRememberMeStatusDetails
		{
			get
			{
				return this.externalRememberMeStatusDetailsField;
			}
			set
			{
				this.externalRememberMeStatusDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private RefreshTokenStatusDetailsType refreshTokenStatusDetailsField;
		public RefreshTokenStatusDetailsType RefreshTokenStatusDetails
		{
			get
			{
				return this.refreshTokenStatusDetailsField;
			}
			set
			{
				this.refreshTokenStatusDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetExpressCheckoutDetailsResponseDetailsType()
	 	{
		}


		public GetExpressCheckoutDetailsResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Token']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Token = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PayerInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PayerInfo =  new PayerInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Custom']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Custom = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'InvoiceID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.InvoiceID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ContactPhone']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ContactPhone = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillingAgreementAcceptedStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillingAgreementAcceptedStatus = System.Convert.ToBoolean(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RedirectRequired']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RedirectRequired = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillingAddress']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillingAddress =  new AddressType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Note']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Note = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CheckoutStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CheckoutStatus = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PayPalAdjustment']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PayPalAdjustment =  new BasicAmountType(ChildNode);
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'PaymentDetails']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.PaymentDetails.Add(new PaymentDetailsType(subNode));
				}
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'UserSelectedOptions']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.UserSelectedOptions =  new UserSelectedOptionType(ChildNode);
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'IncentiveDetails']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.IncentiveDetails.Add(new IncentiveDetailsType(subNode));
				}
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GiftMessage']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GiftMessage = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GiftReceiptEnable']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GiftReceiptEnable = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GiftWrapName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GiftWrapName = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GiftWrapAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GiftWrapAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BuyerMarketingEmail']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BuyerMarketingEmail = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SurveyQuestion']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SurveyQuestion = ChildNode.InnerText;
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'SurveyChoiceSelected']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					string value = ChildNodeList[i].InnerText;
					this.SurveyChoiceSelected.Add(value);
				}
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'PaymentRequestInfo']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.PaymentRequestInfo.Add(new PaymentRequestInfoType(subNode));
				}
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ExternalRememberMeStatusDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ExternalRememberMeStatusDetails =  new ExternalRememberMeStatusDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RefreshTokenStatusDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RefreshTokenStatusDetails =  new RefreshTokenStatusDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class ExecuteCheckoutOperationsResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private SetDataResponseType setDataResponseField;
		public SetDataResponseType SetDataResponse
		{
			get
			{
				return this.setDataResponseField;
			}
			set
			{
				this.setDataResponseField = value;
			}
		}
		

		/**
          *
		  */
		private AuthorizationResponseType authorizationResponseField;
		public AuthorizationResponseType AuthorizationResponse
		{
			get
			{
				return this.authorizationResponseField;
			}
			set
			{
				this.authorizationResponseField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ExecuteCheckoutOperationsResponseDetailsType()
	 	{
		}


		public ExecuteCheckoutOperationsResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SetDataResponse']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SetDataResponse =  new SetDataResponseType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AuthorizationResponse']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AuthorizationResponse =  new AuthorizationResponseType(ChildNode);
			}
	
		}
	}




	/**
      *If Checkout session was initialized successfully, the
      *corresponding token is returned in this element. 
      */
	public partial class SetDataResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorType> setDataErrorField = new List<ErrorType>();
		public List<ErrorType> SetDataError
		{
			get
			{
				return this.setDataErrorField;
			}
			set
			{
				this.setDataErrorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SetDataResponseType()
	 	{
		}


		public SetDataResponseType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Token']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Token = ChildNode.InnerText;
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'SetDataError']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.SetDataError.Add(new ErrorType(subNode));
				}
			}
	
		}
	}




	/**
      *Status will denote whether Auto authorization was successful
      *or not. 
      */
	public partial class AuthorizationResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private AckCodeType? statusField;
		public AckCodeType? Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorType> authorizationErrorField = new List<ErrorType>();
		public List<ErrorType> AuthorizationError
		{
			get
			{
				return this.authorizationErrorField;
			}
			set
			{
				this.authorizationErrorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public AuthorizationResponseType()
	 	{
		}


		public AuthorizationResponseType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Status']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Status = (AckCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(AckCodeType));
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'AuthorizationError']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.AuthorizationError.Add(new ErrorType(subNode));
				}
			}
	
		}
	}




	/**
      *How you want to obtain payment. Required Authorization
      *indicates that this payment is a basic authorization subject
      *to settlement with PayPal Authorization and Capture. Order
      *indicates that this payment is is an order authorization
      *subject to settlement with PayPal Authorization and Capture.
      *Sale indicates that this is a final sale for which you are
      *requesting payment. IMPORTANT: You cannot set PaymentAction
      *to Sale on SetExpressCheckoutRequest and then change
      *PaymentAction to Authorization on the final Express Checkout
      *API, DoExpressCheckoutPaymentRequest. Character length and
      *limit: Up to 13 single-byte alphabetic characters 
      */
	public partial class DoExpressCheckoutPaymentRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private PaymentActionCodeType? paymentActionField;
		public PaymentActionCodeType? PaymentAction
		{
			get
			{
				return this.paymentActionField;
			}
			set
			{
				this.paymentActionField = value;
			}
		}
		

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
          *
		  */
		private string payerIDField;
		public string PayerID
		{
			get
			{
				return this.payerIDField;
			}
			set
			{
				this.payerIDField = value;
			}
		}
		

		/**
          *
		  */
		private string orderURLField;
		public string OrderURL
		{
			get
			{
				return this.orderURLField;
			}
			set
			{
				this.orderURLField = value;
			}
		}
		

		/**
          *
		  */
		private List<PaymentDetailsType> paymentDetailsField = new List<PaymentDetailsType>();
		public List<PaymentDetailsType> PaymentDetails
		{
			get
			{
				return this.paymentDetailsField;
			}
			set
			{
				this.paymentDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string promoOverrideFlagField;
		public string PromoOverrideFlag
		{
			get
			{
				return this.promoOverrideFlagField;
			}
			set
			{
				this.promoOverrideFlagField = value;
			}
		}
		

		/**
          *
		  */
		private string promoCodeField;
		public string PromoCode
		{
			get
			{
				return this.promoCodeField;
			}
			set
			{
				this.promoCodeField = value;
			}
		}
		

		/**
          *
		  */
		private EnhancedDataType enhancedDataField;
		public EnhancedDataType EnhancedData
		{
			get
			{
				return this.enhancedDataField;
			}
			set
			{
				this.enhancedDataField = value;
			}
		}
		

		/**
          *
		  */
		private string softDescriptorField;
		public string SoftDescriptor
		{
			get
			{
				return this.softDescriptorField;
			}
			set
			{
				this.softDescriptorField = value;
			}
		}
		

		/**
          *
		  */
		private UserSelectedOptionType userSelectedOptionsField;
		public UserSelectedOptionType UserSelectedOptions
		{
			get
			{
				return this.userSelectedOptionsField;
			}
			set
			{
				this.userSelectedOptionsField = value;
			}
		}
		

		/**
          *
		  */
		private string giftMessageField;
		public string GiftMessage
		{
			get
			{
				return this.giftMessageField;
			}
			set
			{
				this.giftMessageField = value;
			}
		}
		

		/**
          *
		  */
		private string giftReceiptEnableField;
		public string GiftReceiptEnable
		{
			get
			{
				return this.giftReceiptEnableField;
			}
			set
			{
				this.giftReceiptEnableField = value;
			}
		}
		

		/**
          *
		  */
		private string giftWrapNameField;
		public string GiftWrapName
		{
			get
			{
				return this.giftWrapNameField;
			}
			set
			{
				this.giftWrapNameField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType giftWrapAmountField;
		public BasicAmountType GiftWrapAmount
		{
			get
			{
				return this.giftWrapAmountField;
			}
			set
			{
				this.giftWrapAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string buyerMarketingEmailField;
		public string BuyerMarketingEmail
		{
			get
			{
				return this.buyerMarketingEmailField;
			}
			set
			{
				this.buyerMarketingEmailField = value;
			}
		}
		

		/**
          *
		  */
		private string surveyQuestionField;
		public string SurveyQuestion
		{
			get
			{
				return this.surveyQuestionField;
			}
			set
			{
				this.surveyQuestionField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> surveyChoiceSelectedField = new List<string>();
		public List<string> SurveyChoiceSelected
		{
			get
			{
				return this.surveyChoiceSelectedField;
			}
			set
			{
				this.surveyChoiceSelectedField = value;
			}
		}
		

		/**
          *
		  */
		private string buttonSourceField;
		public string ButtonSource
		{
			get
			{
				return this.buttonSourceField;
			}
			set
			{
				this.buttonSourceField = value;
			}
		}
		

		/**
          *
		  */
		private bool? skipBACreationField;
		public bool? SkipBACreation
		{
			get
			{
				return this.skipBACreationField;
			}
			set
			{
				this.skipBACreationField = value;
			}
		}
		

		/**
          *
		  */
		private List<CoupledBucketsType> coupledBucketsField = new List<CoupledBucketsType>();
		public List<CoupledBucketsType> CoupledBuckets
		{
			get
			{
				return this.coupledBucketsField;
			}
			set
			{
				this.coupledBucketsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoExpressCheckoutPaymentRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(PaymentAction != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PaymentAction>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.PaymentAction)));
				sb.Append("</").Append(PreferredPrefix).Append(":PaymentAction>");
			}
			if(Token != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Token>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Token));
				sb.Append("</").Append(PreferredPrefix).Append(":Token>");
			}
			if(PayerID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PayerID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PayerID));
				sb.Append("</").Append(PreferredPrefix).Append(":PayerID>");
			}
			if(OrderURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OrderURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OrderURL));
				sb.Append("</").Append(PreferredPrefix).Append(":OrderURL>");
			}
			if(PaymentDetails != null)
			{
				for(int i = 0; i < PaymentDetails.Count; i++)
				{
					sb.Append(PaymentDetails[i].ToXMLString(PreferredPrefix,"PaymentDetails"));
				}
			}
			if(PromoOverrideFlag != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PromoOverrideFlag>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PromoOverrideFlag));
				sb.Append("</").Append(PreferredPrefix).Append(":PromoOverrideFlag>");
			}
			if(PromoCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PromoCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PromoCode));
				sb.Append("</").Append(PreferredPrefix).Append(":PromoCode>");
			}
			if(EnhancedData != null)
			{
				sb.Append(EnhancedData.ToXMLString(PreferredPrefix,"EnhancedData"));
			}
			if(SoftDescriptor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SoftDescriptor>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SoftDescriptor));
				sb.Append("</").Append(PreferredPrefix).Append(":SoftDescriptor>");
			}
			if(UserSelectedOptions != null)
			{
				sb.Append(UserSelectedOptions.ToXMLString(PreferredPrefix,"UserSelectedOptions"));
			}
			if(GiftMessage != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":GiftMessage>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.GiftMessage));
				sb.Append("</").Append(PreferredPrefix).Append(":GiftMessage>");
			}
			if(GiftReceiptEnable != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":GiftReceiptEnable>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.GiftReceiptEnable));
				sb.Append("</").Append(PreferredPrefix).Append(":GiftReceiptEnable>");
			}
			if(GiftWrapName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":GiftWrapName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.GiftWrapName));
				sb.Append("</").Append(PreferredPrefix).Append(":GiftWrapName>");
			}
			if(GiftWrapAmount != null)
			{
				sb.Append(GiftWrapAmount.ToXMLString(PreferredPrefix,"GiftWrapAmount"));
			}
			if(BuyerMarketingEmail != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BuyerMarketingEmail>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BuyerMarketingEmail));
				sb.Append("</").Append(PreferredPrefix).Append(":BuyerMarketingEmail>");
			}
			if(SurveyQuestion != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SurveyQuestion>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SurveyQuestion));
				sb.Append("</").Append(PreferredPrefix).Append(":SurveyQuestion>");
			}
			if(SurveyChoiceSelected != null)
			{
				for(int i = 0; i < SurveyChoiceSelected.Count; i++)
				{
					sb.Append("<").Append(PreferredPrefix).Append(":SurveyChoiceSelected>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SurveyChoiceSelected[i]));
					sb.Append("</").Append(PreferredPrefix).Append(":SurveyChoiceSelected>");
				}
			}
			if(ButtonSource != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonSource>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ButtonSource));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonSource>");
			}
			if(SkipBACreation != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SkipBACreation>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SkipBACreation.ToString().ToLower()));
				sb.Append("</").Append(PreferredPrefix).Append(":SkipBACreation>");
			}
			if(CoupledBuckets != null)
			{
				for(int i = 0; i < CoupledBuckets.Count; i++)
				{
					sb.Append(CoupledBuckets[i].ToXMLString(PreferredPrefix,"CoupledBuckets"));
				}
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *The timestamped token value that was returned by
      *SetExpressCheckoutResponse and passed on
      *GetExpressCheckoutDetailsRequest. Character length and
      *limitations:20 single-byte characters 
      */
	public partial class DoExpressCheckoutPaymentResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
          *
		  */
		private List<PaymentInfoType> paymentInfoField = new List<PaymentInfoType>();
		public List<PaymentInfoType> PaymentInfo
		{
			get
			{
				return this.paymentInfoField;
			}
			set
			{
				this.paymentInfoField = value;
			}
		}
		

		/**
          *
		  */
		private string billingAgreementIDField;
		public string BillingAgreementID
		{
			get
			{
				return this.billingAgreementIDField;
			}
			set
			{
				this.billingAgreementIDField = value;
			}
		}
		

		/**
          *
		  */
		private string redirectRequiredField;
		public string RedirectRequired
		{
			get
			{
				return this.redirectRequiredField;
			}
			set
			{
				this.redirectRequiredField = value;
			}
		}
		

		/**
          *
		  */
		private string noteField;
		public string Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}
		

		/**
          *
		  */
		private string successPageRedirectRequestedField;
		public string SuccessPageRedirectRequested
		{
			get
			{
				return this.successPageRedirectRequestedField;
			}
			set
			{
				this.successPageRedirectRequestedField = value;
			}
		}
		

		/**
          *
		  */
		private UserSelectedOptionType userSelectedOptionsField;
		public UserSelectedOptionType UserSelectedOptions
		{
			get
			{
				return this.userSelectedOptionsField;
			}
			set
			{
				this.userSelectedOptionsField = value;
			}
		}
		

		/**
          *
		  */
		private List<CoupledPaymentInfoType> coupledPaymentInfoField = new List<CoupledPaymentInfoType>();
		public List<CoupledPaymentInfoType> CoupledPaymentInfo
		{
			get
			{
				return this.coupledPaymentInfoField;
			}
			set
			{
				this.coupledPaymentInfoField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoExpressCheckoutPaymentResponseDetailsType()
	 	{
		}


		public DoExpressCheckoutPaymentResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Token']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Token = ChildNode.InnerText;
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'PaymentInfo']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.PaymentInfo.Add(new PaymentInfoType(subNode));
				}
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillingAgreementID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillingAgreementID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RedirectRequired']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RedirectRequired = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Note']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Note = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SuccessPageRedirectRequested']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SuccessPageRedirectRequested = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'UserSelectedOptions']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.UserSelectedOptions =  new UserSelectedOptionType(ChildNode);
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'CoupledPaymentInfo']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.CoupledPaymentInfo.Add(new CoupledPaymentInfoType(subNode));
				}
			}
	
		}
	}




	/**
      *The authorization identification number you specified in the
      *request. Character length and limits: 19 single-byte
      *characters maximum 
      */
	public partial class DoCaptureResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string authorizationIDField;
		public string AuthorizationID
		{
			get
			{
				return this.authorizationIDField;
			}
			set
			{
				this.authorizationIDField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentInfoType paymentInfoField;
		public PaymentInfoType PaymentInfo
		{
			get
			{
				return this.paymentInfoField;
			}
			set
			{
				this.paymentInfoField = value;
			}
		}
		

		/**
          *
		  */
		private string msgSubIDField;
		public string MsgSubID
		{
			get
			{
				return this.msgSubIDField;
			}
			set
			{
				this.msgSubIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoCaptureResponseDetailsType()
	 	{
		}


		public DoCaptureResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AuthorizationID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AuthorizationID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentInfo =  new PaymentInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'MsgSubID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.MsgSubID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *How you want to obtain payment. Required Authorization
      *indicates that this payment is a basic authorization subject
      *to settlement with PayPal Authorization and Capture. Sale
      *indicates that this is a final sale for which you are
      *requesting payment. NOTE: Order is not allowed for Direct
      *Payment. Character length and limit: Up to 13 single-byte
      *alphabetic characters 
      */
	public partial class DoDirectPaymentRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private PaymentActionCodeType? paymentActionField;
		public PaymentActionCodeType? PaymentAction
		{
			get
			{
				return this.paymentActionField;
			}
			set
			{
				this.paymentActionField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentDetailsType paymentDetailsField;
		public PaymentDetailsType PaymentDetails
		{
			get
			{
				return this.paymentDetailsField;
			}
			set
			{
				this.paymentDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private CreditCardDetailsType creditCardField;
		public CreditCardDetailsType CreditCard
		{
			get
			{
				return this.creditCardField;
			}
			set
			{
				this.creditCardField = value;
			}
		}
		

		/**
          *
		  */
		private string iPAddressField;
		public string IPAddress
		{
			get
			{
				return this.iPAddressField;
			}
			set
			{
				this.iPAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string merchantSessionIdField;
		public string MerchantSessionId
		{
			get
			{
				return this.merchantSessionIdField;
			}
			set
			{
				this.merchantSessionIdField = value;
			}
		}
		

		/**
          *
		  */
		private bool? returnFMFDetailsField;
		public bool? ReturnFMFDetails
		{
			get
			{
				return this.returnFMFDetailsField;
			}
			set
			{
				this.returnFMFDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoDirectPaymentRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(PaymentAction != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PaymentAction>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.PaymentAction)));
				sb.Append("</").Append(PreferredPrefix).Append(":PaymentAction>");
			}
			if(PaymentDetails != null)
			{
				sb.Append(PaymentDetails.ToXMLString(PreferredPrefix,"PaymentDetails"));
			}
			if(CreditCard != null)
			{
				sb.Append(CreditCard.ToXMLString(PreferredPrefix,"CreditCard"));
			}
			if(IPAddress != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":IPAddress>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.IPAddress));
				sb.Append("</").Append(PreferredPrefix).Append(":IPAddress>");
			}
			if(MerchantSessionId != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MerchantSessionId>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.MerchantSessionId));
				sb.Append("</").Append(PreferredPrefix).Append(":MerchantSessionId>");
			}
			if(ReturnFMFDetails != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReturnFMFDetails>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReturnFMFDetails.ToString().ToLower()));
				sb.Append("</").Append(PreferredPrefix).Append(":ReturnFMFDetails>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Type of the payment Required 
      */
	public partial class CreateMobilePaymentRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private MobilePaymentCodeType? paymentTypeField;
		public MobilePaymentCodeType? PaymentType
		{
			get
			{
				return this.paymentTypeField;
			}
			set
			{
				this.paymentTypeField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentActionCodeType? paymentActionField;
		public PaymentActionCodeType? PaymentAction
		{
			get
			{
				return this.paymentActionField;
			}
			set
			{
				this.paymentActionField = value;
			}
		}
		

		/**
          *
		  */
		private PhoneNumberType senderPhoneField;
		public PhoneNumberType SenderPhone
		{
			get
			{
				return this.senderPhoneField;
			}
			set
			{
				this.senderPhoneField = value;
			}
		}
		

		/**
          *
		  */
		private MobileRecipientCodeType? recipientTypeField;
		public MobileRecipientCodeType? RecipientType
		{
			get
			{
				return this.recipientTypeField;
			}
			set
			{
				this.recipientTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string recipientEmailField;
		public string RecipientEmail
		{
			get
			{
				return this.recipientEmailField;
			}
			set
			{
				this.recipientEmailField = value;
			}
		}
		

		/**
          *
		  */
		private PhoneNumberType recipientPhoneField;
		public PhoneNumberType RecipientPhone
		{
			get
			{
				return this.recipientPhoneField;
			}
			set
			{
				this.recipientPhoneField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType itemAmountField;
		public BasicAmountType ItemAmount
		{
			get
			{
				return this.itemAmountField;
			}
			set
			{
				this.itemAmountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType taxField;
		public BasicAmountType Tax
		{
			get
			{
				return this.taxField;
			}
			set
			{
				this.taxField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType shippingField;
		public BasicAmountType Shipping
		{
			get
			{
				return this.shippingField;
			}
			set
			{
				this.shippingField = value;
			}
		}
		

		/**
          *
		  */
		private string itemNameField;
		public string ItemName
		{
			get
			{
				return this.itemNameField;
			}
			set
			{
				this.itemNameField = value;
			}
		}
		

		/**
          *
		  */
		private string itemNumberField;
		public string ItemNumber
		{
			get
			{
				return this.itemNumberField;
			}
			set
			{
				this.itemNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string noteField;
		public string Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}
		

		/**
          *
		  */
		private string customIDField;
		public string CustomID
		{
			get
			{
				return this.customIDField;
			}
			set
			{
				this.customIDField = value;
			}
		}
		

		/**
          *
		  */
		private int? sharePhoneNumberField;
		public int? SharePhoneNumber
		{
			get
			{
				return this.sharePhoneNumberField;
			}
			set
			{
				this.sharePhoneNumberField = value;
			}
		}
		

		/**
          *
		  */
		private int? shareHomeAddressField;
		public int? ShareHomeAddress
		{
			get
			{
				return this.shareHomeAddressField;
			}
			set
			{
				this.shareHomeAddressField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CreateMobilePaymentRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(PaymentType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PaymentType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.PaymentType)));
				sb.Append("</").Append(PreferredPrefix).Append(":PaymentType>");
			}
			if(PaymentAction != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PaymentAction>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.PaymentAction)));
				sb.Append("</").Append(PreferredPrefix).Append(":PaymentAction>");
			}
			if(SenderPhone != null)
			{
				sb.Append(SenderPhone.ToXMLString(PreferredPrefix,"SenderPhone"));
			}
			if(RecipientType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":RecipientType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.RecipientType)));
				sb.Append("</").Append(PreferredPrefix).Append(":RecipientType>");
			}
			if(RecipientEmail != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":RecipientEmail>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.RecipientEmail));
				sb.Append("</").Append(PreferredPrefix).Append(":RecipientEmail>");
			}
			if(RecipientPhone != null)
			{
				sb.Append(RecipientPhone.ToXMLString(PreferredPrefix,"RecipientPhone"));
			}
			if(ItemAmount != null)
			{
				sb.Append(ItemAmount.ToXMLString(PreferredPrefix,"ItemAmount"));
			}
			if(Tax != null)
			{
				sb.Append(Tax.ToXMLString(PreferredPrefix,"Tax"));
			}
			if(Shipping != null)
			{
				sb.Append(Shipping.ToXMLString(PreferredPrefix,"Shipping"));
			}
			if(ItemName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ItemName));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemName>");
			}
			if(ItemNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ItemNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemNumber>");
			}
			if(Note != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Note>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Note));
				sb.Append("</").Append(PreferredPrefix).Append(":Note>");
			}
			if(CustomID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CustomID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CustomID));
				sb.Append("</").Append(PreferredPrefix).Append(":CustomID>");
			}
			if(SharePhoneNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SharePhoneNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SharePhoneNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":SharePhoneNumber>");
			}
			if(ShareHomeAddress != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ShareHomeAddress>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ShareHomeAddress));
				sb.Append("</").Append(PreferredPrefix).Append(":ShareHomeAddress>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Phone number for status inquiry 
      */
	public partial class GetMobileStatusRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private PhoneNumberType phoneField;
		public PhoneNumberType Phone
		{
			get
			{
				return this.phoneField;
			}
			set
			{
				this.phoneField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetMobileStatusRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Phone != null)
			{
				sb.Append(Phone.ToXMLString(PreferredPrefix,"Phone"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *URL to which the customer's browser is returned after
      *choosing to login with PayPal. Required Character length and
      *limitations: no limit. 
      */
	public partial class SetAuthFlowParamRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string returnURLField;
		public string ReturnURL
		{
			get
			{
				return this.returnURLField;
			}
			set
			{
				this.returnURLField = value;
			}
		}
		

		/**
          *
		  */
		private string cancelURLField;
		public string CancelURL
		{
			get
			{
				return this.cancelURLField;
			}
			set
			{
				this.cancelURLField = value;
			}
		}
		

		/**
          *
		  */
		private string logoutURLField;
		public string LogoutURL
		{
			get
			{
				return this.logoutURLField;
			}
			set
			{
				this.logoutURLField = value;
			}
		}
		

		/**
          *
		  */
		private string initFlowTypeField;
		public string InitFlowType
		{
			get
			{
				return this.initFlowTypeField;
			}
			set
			{
				this.initFlowTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string skipLoginPageField;
		public string SkipLoginPage
		{
			get
			{
				return this.skipLoginPageField;
			}
			set
			{
				this.skipLoginPageField = value;
			}
		}
		

		/**
          *
		  */
		private string serviceName1Field;
		public string ServiceName1
		{
			get
			{
				return this.serviceName1Field;
			}
			set
			{
				this.serviceName1Field = value;
			}
		}
		

		/**
          *
		  */
		private string serviceDefReq1Field;
		public string ServiceDefReq1
		{
			get
			{
				return this.serviceDefReq1Field;
			}
			set
			{
				this.serviceDefReq1Field = value;
			}
		}
		

		/**
          *
		  */
		private string serviceName2Field;
		public string ServiceName2
		{
			get
			{
				return this.serviceName2Field;
			}
			set
			{
				this.serviceName2Field = value;
			}
		}
		

		/**
          *
		  */
		private string serviceDefReq2Field;
		public string ServiceDefReq2
		{
			get
			{
				return this.serviceDefReq2Field;
			}
			set
			{
				this.serviceDefReq2Field = value;
			}
		}
		

		/**
          *
		  */
		private string localeCodeField;
		public string LocaleCode
		{
			get
			{
				return this.localeCodeField;
			}
			set
			{
				this.localeCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string pageStyleField;
		public string PageStyle
		{
			get
			{
				return this.pageStyleField;
			}
			set
			{
				this.pageStyleField = value;
			}
		}
		

		/**
          *
		  */
		private string cppHeaderImageField;
		public string cppHeaderImage
		{
			get
			{
				return this.cppHeaderImageField;
			}
			set
			{
				this.cppHeaderImageField = value;
			}
		}
		

		/**
          *
		  */
		private string cppHeaderBorderColorField;
		public string cppHeaderBorderColor
		{
			get
			{
				return this.cppHeaderBorderColorField;
			}
			set
			{
				this.cppHeaderBorderColorField = value;
			}
		}
		

		/**
          *
		  */
		private string cppHeaderBackColorField;
		public string cppHeaderBackColor
		{
			get
			{
				return this.cppHeaderBackColorField;
			}
			set
			{
				this.cppHeaderBackColorField = value;
			}
		}
		

		/**
          *
		  */
		private string cppPayflowColorField;
		public string cppPayflowColor
		{
			get
			{
				return this.cppPayflowColorField;
			}
			set
			{
				this.cppPayflowColorField = value;
			}
		}
		

		/**
          *
		  */
		private string firstNameField;
		public string FirstName
		{
			get
			{
				return this.firstNameField;
			}
			set
			{
				this.firstNameField = value;
			}
		}
		

		/**
          *
		  */
		private string lastNameField;
		public string LastName
		{
			get
			{
				return this.lastNameField;
			}
			set
			{
				this.lastNameField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType addressField;
		public AddressType Address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SetAuthFlowParamRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ReturnURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReturnURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReturnURL));
				sb.Append("</").Append(PreferredPrefix).Append(":ReturnURL>");
			}
			if(CancelURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CancelURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CancelURL));
				sb.Append("</").Append(PreferredPrefix).Append(":CancelURL>");
			}
			if(LogoutURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":LogoutURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.LogoutURL));
				sb.Append("</").Append(PreferredPrefix).Append(":LogoutURL>");
			}
			if(InitFlowType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":InitFlowType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.InitFlowType));
				sb.Append("</").Append(PreferredPrefix).Append(":InitFlowType>");
			}
			if(SkipLoginPage != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SkipLoginPage>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SkipLoginPage));
				sb.Append("</").Append(PreferredPrefix).Append(":SkipLoginPage>");
			}
			if(ServiceName1 != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ServiceName1>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ServiceName1));
				sb.Append("</").Append(PreferredPrefix).Append(":ServiceName1>");
			}
			if(ServiceDefReq1 != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ServiceDefReq1>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ServiceDefReq1));
				sb.Append("</").Append(PreferredPrefix).Append(":ServiceDefReq1>");
			}
			if(ServiceName2 != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ServiceName2>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ServiceName2));
				sb.Append("</").Append(PreferredPrefix).Append(":ServiceName2>");
			}
			if(ServiceDefReq2 != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ServiceDefReq2>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ServiceDefReq2));
				sb.Append("</").Append(PreferredPrefix).Append(":ServiceDefReq2>");
			}
			if(LocaleCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":LocaleCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.LocaleCode));
				sb.Append("</").Append(PreferredPrefix).Append(":LocaleCode>");
			}
			if(PageStyle != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PageStyle>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PageStyle));
				sb.Append("</").Append(PreferredPrefix).Append(":PageStyle>");
			}
			if(cppHeaderImage != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-header-image>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppHeaderImage));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-header-image>");
			}
			if(cppHeaderBorderColor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-header-border-color>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppHeaderBorderColor));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-header-border-color>");
			}
			if(cppHeaderBackColor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-header-back-color>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppHeaderBackColor));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-header-back-color>");
			}
			if(cppPayflowColor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-payflow-color>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppPayflowColor));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-payflow-color>");
			}
			if(FirstName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":FirstName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.FirstName));
				sb.Append("</").Append(PreferredPrefix).Append(":FirstName>");
			}
			if(LastName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":LastName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.LastName));
				sb.Append("</").Append(PreferredPrefix).Append(":LastName>");
			}
			if(Address != null)
			{
				sb.Append(Address.ToXMLString(PreferredPrefix,"Address"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *The first name of the User. Character length and
      *limitations: 127 single-byte alphanumeric characters 
      */
	public partial class GetAuthDetailsResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string firstNameField;
		public string FirstName
		{
			get
			{
				return this.firstNameField;
			}
			set
			{
				this.firstNameField = value;
			}
		}
		

		/**
          *
		  */
		private string lastNameField;
		public string LastName
		{
			get
			{
				return this.lastNameField;
			}
			set
			{
				this.lastNameField = value;
			}
		}
		

		/**
          *
		  */
		private string emailField;
		public string Email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
			}
		}
		

		/**
          *
		  */
		private string payerIDField;
		public string PayerID
		{
			get
			{
				return this.payerIDField;
			}
			set
			{
				this.payerIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetAuthDetailsResponseDetailsType()
	 	{
		}


		public GetAuthDetailsResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'FirstName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.FirstName = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'LastName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.LastName = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Email']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Email = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PayerID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PayerID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *URL to which the customer's browser is returned after
      *choosing to login with PayPal. Required Character length and
      *limitations: no limit. 
      */
	public partial class SetAccessPermissionsRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string returnURLField;
		public string ReturnURL
		{
			get
			{
				return this.returnURLField;
			}
			set
			{
				this.returnURLField = value;
			}
		}
		

		/**
          *
		  */
		private string cancelURLField;
		public string CancelURL
		{
			get
			{
				return this.cancelURLField;
			}
			set
			{
				this.cancelURLField = value;
			}
		}
		

		/**
          *
		  */
		private string logoutURLField;
		public string LogoutURL
		{
			get
			{
				return this.logoutURLField;
			}
			set
			{
				this.logoutURLField = value;
			}
		}
		

		/**
          *
		  */
		private string initFlowTypeField;
		public string InitFlowType
		{
			get
			{
				return this.initFlowTypeField;
			}
			set
			{
				this.initFlowTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string skipLoginPageField;
		public string SkipLoginPage
		{
			get
			{
				return this.skipLoginPageField;
			}
			set
			{
				this.skipLoginPageField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> requiredAccessPermissionsField = new List<string>();
		public List<string> RequiredAccessPermissions
		{
			get
			{
				return this.requiredAccessPermissionsField;
			}
			set
			{
				this.requiredAccessPermissionsField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> optionalAccessPermissionsField = new List<string>();
		public List<string> OptionalAccessPermissions
		{
			get
			{
				return this.optionalAccessPermissionsField;
			}
			set
			{
				this.optionalAccessPermissionsField = value;
			}
		}
		

		/**
          *
		  */
		private string localeCodeField;
		public string LocaleCode
		{
			get
			{
				return this.localeCodeField;
			}
			set
			{
				this.localeCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string pageStyleField;
		public string PageStyle
		{
			get
			{
				return this.pageStyleField;
			}
			set
			{
				this.pageStyleField = value;
			}
		}
		

		/**
          *
		  */
		private string cppHeaderImageField;
		public string cppHeaderImage
		{
			get
			{
				return this.cppHeaderImageField;
			}
			set
			{
				this.cppHeaderImageField = value;
			}
		}
		

		/**
          *
		  */
		private string cppHeaderBorderColorField;
		public string cppHeaderBorderColor
		{
			get
			{
				return this.cppHeaderBorderColorField;
			}
			set
			{
				this.cppHeaderBorderColorField = value;
			}
		}
		

		/**
          *
		  */
		private string cppHeaderBackColorField;
		public string cppHeaderBackColor
		{
			get
			{
				return this.cppHeaderBackColorField;
			}
			set
			{
				this.cppHeaderBackColorField = value;
			}
		}
		

		/**
          *
		  */
		private string cppPayflowColorField;
		public string cppPayflowColor
		{
			get
			{
				return this.cppPayflowColorField;
			}
			set
			{
				this.cppPayflowColorField = value;
			}
		}
		

		/**
          *
		  */
		private string firstNameField;
		public string FirstName
		{
			get
			{
				return this.firstNameField;
			}
			set
			{
				this.firstNameField = value;
			}
		}
		

		/**
          *
		  */
		private string lastNameField;
		public string LastName
		{
			get
			{
				return this.lastNameField;
			}
			set
			{
				this.lastNameField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType addressField;
		public AddressType Address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SetAccessPermissionsRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ReturnURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReturnURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReturnURL));
				sb.Append("</").Append(PreferredPrefix).Append(":ReturnURL>");
			}
			if(CancelURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CancelURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CancelURL));
				sb.Append("</").Append(PreferredPrefix).Append(":CancelURL>");
			}
			if(LogoutURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":LogoutURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.LogoutURL));
				sb.Append("</").Append(PreferredPrefix).Append(":LogoutURL>");
			}
			if(InitFlowType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":InitFlowType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.InitFlowType));
				sb.Append("</").Append(PreferredPrefix).Append(":InitFlowType>");
			}
			if(SkipLoginPage != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SkipLoginPage>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SkipLoginPage));
				sb.Append("</").Append(PreferredPrefix).Append(":SkipLoginPage>");
			}
			if(RequiredAccessPermissions != null)
			{
				for(int i = 0; i < RequiredAccessPermissions.Count; i++)
				{
					sb.Append("<").Append(PreferredPrefix).Append(":RequiredAccessPermissions>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.RequiredAccessPermissions[i]));
					sb.Append("</").Append(PreferredPrefix).Append(":RequiredAccessPermissions>");
				}
			}
			if(OptionalAccessPermissions != null)
			{
				for(int i = 0; i < OptionalAccessPermissions.Count; i++)
				{
					sb.Append("<").Append(PreferredPrefix).Append(":OptionalAccessPermissions>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OptionalAccessPermissions[i]));
					sb.Append("</").Append(PreferredPrefix).Append(":OptionalAccessPermissions>");
				}
			}
			if(LocaleCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":LocaleCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.LocaleCode));
				sb.Append("</").Append(PreferredPrefix).Append(":LocaleCode>");
			}
			if(PageStyle != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PageStyle>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PageStyle));
				sb.Append("</").Append(PreferredPrefix).Append(":PageStyle>");
			}
			if(cppHeaderImage != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-header-image>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppHeaderImage));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-header-image>");
			}
			if(cppHeaderBorderColor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-header-border-color>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppHeaderBorderColor));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-header-border-color>");
			}
			if(cppHeaderBackColor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-header-back-color>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppHeaderBackColor));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-header-back-color>");
			}
			if(cppPayflowColor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-payflow-color>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppPayflowColor));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-payflow-color>");
			}
			if(FirstName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":FirstName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.FirstName));
				sb.Append("</").Append(PreferredPrefix).Append(":FirstName>");
			}
			if(LastName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":LastName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.LastName));
				sb.Append("</").Append(PreferredPrefix).Append(":LastName>");
			}
			if(Address != null)
			{
				sb.Append(Address.ToXMLString(PreferredPrefix,"Address"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *The first name of the User. Character length and
      *limitations: 127 single-byte alphanumeric characters 
      */
	public partial class GetAccessPermissionDetailsResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string firstNameField;
		public string FirstName
		{
			get
			{
				return this.firstNameField;
			}
			set
			{
				this.firstNameField = value;
			}
		}
		

		/**
          *
		  */
		private string lastNameField;
		public string LastName
		{
			get
			{
				return this.lastNameField;
			}
			set
			{
				this.lastNameField = value;
			}
		}
		

		/**
          *
		  */
		private string emailField;
		public string Email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> accessPermissionNameField = new List<string>();
		public List<string> AccessPermissionName
		{
			get
			{
				return this.accessPermissionNameField;
			}
			set
			{
				this.accessPermissionNameField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> accessPermissionStatusField = new List<string>();
		public List<string> AccessPermissionStatus
		{
			get
			{
				return this.accessPermissionStatusField;
			}
			set
			{
				this.accessPermissionStatusField = value;
			}
		}
		

		/**
          *
		  */
		private string payerIDField;
		public string PayerID
		{
			get
			{
				return this.payerIDField;
			}
			set
			{
				this.payerIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetAccessPermissionDetailsResponseDetailsType()
	 	{
		}


		public GetAccessPermissionDetailsResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'FirstName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.FirstName = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'LastName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.LastName = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Email']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Email = ChildNode.InnerText;
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'AccessPermissionName']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					string value = ChildNodeList[i].InnerText;
					this.AccessPermissionName.Add(value);
				}
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'AccessPermissionStatus']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					string value = ChildNodeList[i].InnerText;
					this.AccessPermissionStatus.Add(value);
				}
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PayerID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PayerID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class BAUpdateResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string billingAgreementIDField;
		public string BillingAgreementID
		{
			get
			{
				return this.billingAgreementIDField;
			}
			set
			{
				this.billingAgreementIDField = value;
			}
		}
		

		/**
          *
		  */
		private string billingAgreementDescriptionField;
		public string BillingAgreementDescription
		{
			get
			{
				return this.billingAgreementDescriptionField;
			}
			set
			{
				this.billingAgreementDescriptionField = value;
			}
		}
		

		/**
          *
		  */
		private MerchantPullStatusCodeType? billingAgreementStatusField;
		public MerchantPullStatusCodeType? BillingAgreementStatus
		{
			get
			{
				return this.billingAgreementStatusField;
			}
			set
			{
				this.billingAgreementStatusField = value;
			}
		}
		

		/**
          *
		  */
		private string billingAgreementCustomField;
		public string BillingAgreementCustom
		{
			get
			{
				return this.billingAgreementCustomField;
			}
			set
			{
				this.billingAgreementCustomField = value;
			}
		}
		

		/**
          *
		  */
		private PayerInfoType payerInfoField;
		public PayerInfoType PayerInfo
		{
			get
			{
				return this.payerInfoField;
			}
			set
			{
				this.payerInfoField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType billingAgreementMaxField;
		public BasicAmountType BillingAgreementMax
		{
			get
			{
				return this.billingAgreementMaxField;
			}
			set
			{
				this.billingAgreementMaxField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType billingAddressField;
		public AddressType BillingAddress
		{
			get
			{
				return this.billingAddressField;
			}
			set
			{
				this.billingAddressField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BAUpdateResponseDetailsType()
	 	{
		}


		public BAUpdateResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillingAgreementID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillingAgreementID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillingAgreementDescription']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillingAgreementDescription = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillingAgreementStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillingAgreementStatus = (MerchantPullStatusCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(MerchantPullStatusCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillingAgreementCustom']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillingAgreementCustom = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PayerInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PayerInfo =  new PayerInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillingAgreementMax']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillingAgreementMax =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillingAddress']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillingAddress =  new AddressType(ChildNode);
			}
	
		}
	}




	/**
      *MerchantPullPaymentResponseType Response data from the
      *merchant pull. 
      */
	public partial class MerchantPullPaymentResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private PayerInfoType payerInfoField;
		public PayerInfoType PayerInfo
		{
			get
			{
				return this.payerInfoField;
			}
			set
			{
				this.payerInfoField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentInfoType paymentInfoField;
		public PaymentInfoType PaymentInfo
		{
			get
			{
				return this.paymentInfoField;
			}
			set
			{
				this.paymentInfoField = value;
			}
		}
		

		/**
          *
		  */
		private MerchantPullInfoType merchantPullInfoField;
		public MerchantPullInfoType MerchantPullInfo
		{
			get
			{
				return this.merchantPullInfoField;
			}
			set
			{
				this.merchantPullInfoField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public MerchantPullPaymentResponseType()
	 	{
		}


		public MerchantPullPaymentResponseType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PayerInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PayerInfo =  new PayerInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentInfo =  new PaymentInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'MerchantPullInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.MerchantPullInfo =  new MerchantPullInfoType(ChildNode);
			}
	
		}
	}




	/**
      *MerchantPullInfoType Information about the merchant pull. 
      */
	public partial class MerchantPullInfoType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private MerchantPullStatusCodeType? mpStatusField;
		public MerchantPullStatusCodeType? MpStatus
		{
			get
			{
				return this.mpStatusField;
			}
			set
			{
				this.mpStatusField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType mpMaxField;
		public BasicAmountType MpMax
		{
			get
			{
				return this.mpMaxField;
			}
			set
			{
				this.mpMaxField = value;
			}
		}
		

		/**
          *
		  */
		private string mpCustomField;
		public string MpCustom
		{
			get
			{
				return this.mpCustomField;
			}
			set
			{
				this.mpCustomField = value;
			}
		}
		

		/**
          *
		  */
		private string descField;
		public string Desc
		{
			get
			{
				return this.descField;
			}
			set
			{
				this.descField = value;
			}
		}
		

		/**
          *
		  */
		private string invoiceField;
		public string Invoice
		{
			get
			{
				return this.invoiceField;
			}
			set
			{
				this.invoiceField = value;
			}
		}
		

		/**
          *
		  */
		private string customField;
		public string Custom
		{
			get
			{
				return this.customField;
			}
			set
			{
				this.customField = value;
			}
		}
		

		/**
          *
		  */
		private string paymentSourceIDField;
		public string PaymentSourceID
		{
			get
			{
				return this.paymentSourceIDField;
			}
			set
			{
				this.paymentSourceIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public MerchantPullInfoType()
	 	{
		}


		public MerchantPullInfoType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'MpStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.MpStatus = (MerchantPullStatusCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(MerchantPullStatusCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'MpMax']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.MpMax =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'MpCustom']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.MpCustom = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Desc']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Desc = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Invoice']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Invoice = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Custom']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Custom = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentSourceID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentSourceID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *PaymentTransactionSearchResultType Results from a
      *PaymentTransaction search 
      */
	public partial class PaymentTransactionSearchResultType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string timestampField;
		public string Timestamp
		{
			get
			{
				return this.timestampField;
			}
			set
			{
				this.timestampField = value;
			}
		}
		

		/**
          *
		  */
		private string timezoneField;
		public string Timezone
		{
			get
			{
				return this.timezoneField;
			}
			set
			{
				this.timezoneField = value;
			}
		}
		

		/**
          *
		  */
		private string typeField;
		public string Type
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
		

		/**
          *
		  */
		private string payerField;
		public string Payer
		{
			get
			{
				return this.payerField;
			}
			set
			{
				this.payerField = value;
			}
		}
		

		/**
          *
		  */
		private string payerDisplayNameField;
		public string PayerDisplayName
		{
			get
			{
				return this.payerDisplayNameField;
			}
			set
			{
				this.payerDisplayNameField = value;
			}
		}
		

		/**
          *
		  */
		private string transactionIDField;
		public string TransactionID
		{
			get
			{
				return this.transactionIDField;
			}
			set
			{
				this.transactionIDField = value;
			}
		}
		

		/**
          *
		  */
		private string statusField;
		public string Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType grossAmountField;
		public BasicAmountType GrossAmount
		{
			get
			{
				return this.grossAmountField;
			}
			set
			{
				this.grossAmountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType feeAmountField;
		public BasicAmountType FeeAmount
		{
			get
			{
				return this.feeAmountField;
			}
			set
			{
				this.feeAmountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType netAmountField;
		public BasicAmountType NetAmount
		{
			get
			{
				return this.netAmountField;
			}
			set
			{
				this.netAmountField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PaymentTransactionSearchResultType()
	 	{
		}


		public PaymentTransactionSearchResultType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Timestamp']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Timestamp = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Timezone']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Timezone = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Type']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Type = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Payer']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Payer = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PayerDisplayName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PayerDisplayName = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TransactionID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TransactionID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Status']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Status = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GrossAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GrossAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'FeeAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.FeeAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'NetAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.NetAmount =  new BasicAmountType(ChildNode);
			}
	
		}
	}




	/**
      *MerchantPullPayment Parameters to make initiate a pull
      *payment 
      */
	public partial class MerchantPullPaymentType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private string mpIDField;
		public string MpID
		{
			get
			{
				return this.mpIDField;
			}
			set
			{
				this.mpIDField = value;
			}
		}
		

		/**
          *
		  */
		private MerchantPullPaymentCodeType? paymentTypeField;
		public MerchantPullPaymentCodeType? PaymentType
		{
			get
			{
				return this.paymentTypeField;
			}
			set
			{
				this.paymentTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string memoField;
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
			}
		}
		

		/**
          *
		  */
		private string emailSubjectField;
		public string EmailSubject
		{
			get
			{
				return this.emailSubjectField;
			}
			set
			{
				this.emailSubjectField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType taxField;
		public BasicAmountType Tax
		{
			get
			{
				return this.taxField;
			}
			set
			{
				this.taxField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType shippingField;
		public BasicAmountType Shipping
		{
			get
			{
				return this.shippingField;
			}
			set
			{
				this.shippingField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType handlingField;
		public BasicAmountType Handling
		{
			get
			{
				return this.handlingField;
			}
			set
			{
				this.handlingField = value;
			}
		}
		

		/**
          *
		  */
		private string itemNameField;
		public string ItemName
		{
			get
			{
				return this.itemNameField;
			}
			set
			{
				this.itemNameField = value;
			}
		}
		

		/**
          *
		  */
		private string itemNumberField;
		public string ItemNumber
		{
			get
			{
				return this.itemNumberField;
			}
			set
			{
				this.itemNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string invoiceField;
		public string Invoice
		{
			get
			{
				return this.invoiceField;
			}
			set
			{
				this.invoiceField = value;
			}
		}
		

		/**
          *
		  */
		private string customField;
		public string Custom
		{
			get
			{
				return this.customField;
			}
			set
			{
				this.customField = value;
			}
		}
		

		/**
          *
		  */
		private string buttonSourceField;
		public string ButtonSource
		{
			get
			{
				return this.buttonSourceField;
			}
			set
			{
				this.buttonSourceField = value;
			}
		}
		

		/**
          *
		  */
		private string softDescriptorField;
		public string SoftDescriptor
		{
			get
			{
				return this.softDescriptorField;
			}
			set
			{
				this.softDescriptorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public MerchantPullPaymentType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Amount != null)
			{
				sb.Append(Amount.ToXMLString(PreferredPrefix,"Amount"));
			}
			if(MpID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MpID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.MpID));
				sb.Append("</").Append(PreferredPrefix).Append(":MpID>");
			}
			if(PaymentType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PaymentType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.PaymentType)));
				sb.Append("</").Append(PreferredPrefix).Append(":PaymentType>");
			}
			if(Memo != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Memo>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Memo));
				sb.Append("</").Append(PreferredPrefix).Append(":Memo>");
			}
			if(EmailSubject != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":EmailSubject>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.EmailSubject));
				sb.Append("</").Append(PreferredPrefix).Append(":EmailSubject>");
			}
			if(Tax != null)
			{
				sb.Append(Tax.ToXMLString(PreferredPrefix,"Tax"));
			}
			if(Shipping != null)
			{
				sb.Append(Shipping.ToXMLString(PreferredPrefix,"Shipping"));
			}
			if(Handling != null)
			{
				sb.Append(Handling.ToXMLString(PreferredPrefix,"Handling"));
			}
			if(ItemName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ItemName));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemName>");
			}
			if(ItemNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ItemNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemNumber>");
			}
			if(Invoice != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Invoice>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Invoice));
				sb.Append("</").Append(PreferredPrefix).Append(":Invoice>");
			}
			if(Custom != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Custom>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Custom));
				sb.Append("</").Append(PreferredPrefix).Append(":Custom>");
			}
			if(ButtonSource != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonSource>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ButtonSource));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonSource>");
			}
			if(SoftDescriptor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SoftDescriptor>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SoftDescriptor));
				sb.Append("</").Append(PreferredPrefix).Append(":SoftDescriptor>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *PaymentTransactionType Information about a PayPal payment
      *from the seller side 
      */
	public partial class PaymentTransactionType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private ReceiverInfoType receiverInfoField;
		public ReceiverInfoType ReceiverInfo
		{
			get
			{
				return this.receiverInfoField;
			}
			set
			{
				this.receiverInfoField = value;
			}
		}
		

		/**
          *
		  */
		private PayerInfoType payerInfoField;
		public PayerInfoType PayerInfo
		{
			get
			{
				return this.payerInfoField;
			}
			set
			{
				this.payerInfoField = value;
			}
		}
		

		/**
          *
		  */
		private string tPLReferenceIDField;
		public string TPLReferenceID
		{
			get
			{
				return this.tPLReferenceIDField;
			}
			set
			{
				this.tPLReferenceIDField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentInfoType paymentInfoField;
		public PaymentInfoType PaymentInfo
		{
			get
			{
				return this.paymentInfoField;
			}
			set
			{
				this.paymentInfoField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentItemInfoType paymentItemInfoField;
		public PaymentItemInfoType PaymentItemInfo
		{
			get
			{
				return this.paymentItemInfoField;
			}
			set
			{
				this.paymentItemInfoField = value;
			}
		}
		

		/**
          *
		  */
		private OfferCouponInfoType offerCouponInfoField;
		public OfferCouponInfoType OfferCouponInfo
		{
			get
			{
				return this.offerCouponInfoField;
			}
			set
			{
				this.offerCouponInfoField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType secondaryAddressField;
		public AddressType SecondaryAddress
		{
			get
			{
				return this.secondaryAddressField;
			}
			set
			{
				this.secondaryAddressField = value;
			}
		}
		

		/**
          *
		  */
		private UserSelectedOptionType userSelectedOptionsField;
		public UserSelectedOptionType UserSelectedOptions
		{
			get
			{
				return this.userSelectedOptionsField;
			}
			set
			{
				this.userSelectedOptionsField = value;
			}
		}
		

		/**
          *
		  */
		private string giftMessageField;
		public string GiftMessage
		{
			get
			{
				return this.giftMessageField;
			}
			set
			{
				this.giftMessageField = value;
			}
		}
		

		/**
          *
		  */
		private string giftReceiptField;
		public string GiftReceipt
		{
			get
			{
				return this.giftReceiptField;
			}
			set
			{
				this.giftReceiptField = value;
			}
		}
		

		/**
          *
		  */
		private string giftWrapNameField;
		public string GiftWrapName
		{
			get
			{
				return this.giftWrapNameField;
			}
			set
			{
				this.giftWrapNameField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType giftWrapAmountField;
		public BasicAmountType GiftWrapAmount
		{
			get
			{
				return this.giftWrapAmountField;
			}
			set
			{
				this.giftWrapAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string buyerEmailOptInField;
		public string BuyerEmailOptIn
		{
			get
			{
				return this.buyerEmailOptInField;
			}
			set
			{
				this.buyerEmailOptInField = value;
			}
		}
		

		/**
          *
		  */
		private string surveyQuestionField;
		public string SurveyQuestion
		{
			get
			{
				return this.surveyQuestionField;
			}
			set
			{
				this.surveyQuestionField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> surveyChoiceSelectedField = new List<string>();
		public List<string> SurveyChoiceSelected
		{
			get
			{
				return this.surveyChoiceSelectedField;
			}
			set
			{
				this.surveyChoiceSelectedField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PaymentTransactionType()
	 	{
		}


		public PaymentTransactionType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ReceiverInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ReceiverInfo =  new ReceiverInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PayerInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PayerInfo =  new PayerInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TPLReferenceID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TPLReferenceID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentInfo =  new PaymentInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentItemInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentItemInfo =  new PaymentItemInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OfferCouponInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OfferCouponInfo =  new OfferCouponInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SecondaryAddress']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SecondaryAddress =  new AddressType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'UserSelectedOptions']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.UserSelectedOptions =  new UserSelectedOptionType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GiftMessage']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GiftMessage = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GiftReceipt']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GiftReceipt = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GiftWrapName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GiftWrapName = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GiftWrapAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GiftWrapAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BuyerEmailOptIn']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BuyerEmailOptIn = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SurveyQuestion']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SurveyQuestion = ChildNode.InnerText;
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'SurveyChoiceSelected']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					string value = ChildNodeList[i].InnerText;
					this.SurveyChoiceSelected.Add(value);
				}
			}
	
		}
	}




	/**
      *ReceiverInfoType Receiver information. 
      */
	public partial class ReceiverInfoType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string businessField;
		public string Business
		{
			get
			{
				return this.businessField;
			}
			set
			{
				this.businessField = value;
			}
		}
		

		/**
          *
		  */
		private string receiverField;
		public string Receiver
		{
			get
			{
				return this.receiverField;
			}
			set
			{
				this.receiverField = value;
			}
		}
		

		/**
          *
		  */
		private string receiverIDField;
		public string ReceiverID
		{
			get
			{
				return this.receiverIDField;
			}
			set
			{
				this.receiverIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ReceiverInfoType()
	 	{
		}


		public ReceiverInfoType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Business']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Business = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Receiver']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Receiver = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ReceiverID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ReceiverID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *PayerInfoType Payer information 
      */
	public partial class PayerInfoType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string payerField;
		public string Payer
		{
			get
			{
				return this.payerField;
			}
			set
			{
				this.payerField = value;
			}
		}
		

		/**
          *
		  */
		private string payerIDField;
		public string PayerID
		{
			get
			{
				return this.payerIDField;
			}
			set
			{
				this.payerIDField = value;
			}
		}
		

		/**
          *
		  */
		private PayPalUserStatusCodeType? payerStatusField;
		public PayPalUserStatusCodeType? PayerStatus
		{
			get
			{
				return this.payerStatusField;
			}
			set
			{
				this.payerStatusField = value;
			}
		}
		

		/**
          *
		  */
		private PersonNameType payerNameField;
		public PersonNameType PayerName
		{
			get
			{
				return this.payerNameField;
			}
			set
			{
				this.payerNameField = value;
			}
		}
		

		/**
          *
		  */
		private CountryCodeType? payerCountryField;
		public CountryCodeType? PayerCountry
		{
			get
			{
				return this.payerCountryField;
			}
			set
			{
				this.payerCountryField = value;
			}
		}
		

		/**
          *
		  */
		private string payerBusinessField;
		public string PayerBusiness
		{
			get
			{
				return this.payerBusinessField;
			}
			set
			{
				this.payerBusinessField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType addressField;
		public AddressType Address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}
		

		/**
          *
		  */
		private string contactPhoneField;
		public string ContactPhone
		{
			get
			{
				return this.contactPhoneField;
			}
			set
			{
				this.contactPhoneField = value;
			}
		}
		

		/**
          *
		  */
		private TaxIdDetailsType taxIdDetailsField;
		public TaxIdDetailsType TaxIdDetails
		{
			get
			{
				return this.taxIdDetailsField;
			}
			set
			{
				this.taxIdDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private EnhancedPayerInfoType enhancedPayerInfoField;
		public EnhancedPayerInfoType EnhancedPayerInfo
		{
			get
			{
				return this.enhancedPayerInfoField;
			}
			set
			{
				this.enhancedPayerInfoField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PayerInfoType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Payer != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Payer>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Payer));
				sb.Append("</").Append(PreferredPrefix).Append(":Payer>");
			}
			if(PayerID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PayerID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PayerID));
				sb.Append("</").Append(PreferredPrefix).Append(":PayerID>");
			}
			if(PayerStatus != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PayerStatus>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.PayerStatus)));
				sb.Append("</").Append(PreferredPrefix).Append(":PayerStatus>");
			}
			if(PayerName != null)
			{
				sb.Append(PayerName.ToXMLString(PreferredPrefix,"PayerName"));
			}
			if(PayerCountry != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PayerCountry>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.PayerCountry)));
				sb.Append("</").Append(PreferredPrefix).Append(":PayerCountry>");
			}
			if(PayerBusiness != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PayerBusiness>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PayerBusiness));
				sb.Append("</").Append(PreferredPrefix).Append(":PayerBusiness>");
			}
			if(Address != null)
			{
				sb.Append(Address.ToXMLString(PreferredPrefix,"Address"));
			}
			if(ContactPhone != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ContactPhone>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ContactPhone));
				sb.Append("</").Append(PreferredPrefix).Append(":ContactPhone>");
			}
			if(TaxIdDetails != null)
			{
				sb.Append(TaxIdDetails.ToXMLString(PreferredPrefix,"TaxIdDetails"));
			}
			if(EnhancedPayerInfo != null)
			{
				sb.Append(EnhancedPayerInfo.ToXMLString(PreferredPrefix,"EnhancedPayerInfo"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public PayerInfoType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Payer']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Payer = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PayerID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PayerID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PayerStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PayerStatus = (PayPalUserStatusCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(PayPalUserStatusCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PayerName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PayerName =  new PersonNameType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PayerCountry']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PayerCountry = (CountryCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(CountryCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PayerBusiness']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PayerBusiness = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Address']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Address =  new AddressType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ContactPhone']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ContactPhone = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TaxIdDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TaxIdDetails =  new TaxIdDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'EnhancedPayerInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.EnhancedPayerInfo =  new EnhancedPayerInfoType(ChildNode);
			}
	
		}
	}




	/**
      *InstrumentDetailsType Promotional Instrument Information. 
      */
	public partial class InstrumentDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string instrumentCategoryField;
		public string InstrumentCategory
		{
			get
			{
				return this.instrumentCategoryField;
			}
			set
			{
				this.instrumentCategoryField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public InstrumentDetailsType()
	 	{
		}


		public InstrumentDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'InstrumentCategory']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.InstrumentCategory = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *BMLOfferInfoType Specific information for BML. 
      */
	public partial class BMLOfferInfoType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string offerTrackingIDField;
		public string OfferTrackingID
		{
			get
			{
				return this.offerTrackingIDField;
			}
			set
			{
				this.offerTrackingIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BMLOfferInfoType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(OfferTrackingID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OfferTrackingID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OfferTrackingID));
				sb.Append("</").Append(PreferredPrefix).Append(":OfferTrackingID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public BMLOfferInfoType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OfferTrackingID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OfferTrackingID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *OfferDetailsType Specific information for an offer. 
      */
	public partial class OfferDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string offerCodeField;
		public string OfferCode
		{
			get
			{
				return this.offerCodeField;
			}
			set
			{
				this.offerCodeField = value;
			}
		}
		

		/**
          *
		  */
		private BMLOfferInfoType bMLOfferInfoField;
		public BMLOfferInfoType BMLOfferInfo
		{
			get
			{
				return this.bMLOfferInfoField;
			}
			set
			{
				this.bMLOfferInfoField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public OfferDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(OfferCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OfferCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OfferCode));
				sb.Append("</").Append(PreferredPrefix).Append(":OfferCode>");
			}
			if(BMLOfferInfo != null)
			{
				sb.Append(BMLOfferInfo.ToXMLString(PreferredPrefix,"BMLOfferInfo"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public OfferDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OfferCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OfferCode = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BMLOfferInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BMLOfferInfo =  new BMLOfferInfoType(ChildNode);
			}
	
		}
	}




	/**
      *PaymentInfoType Payment information. 
      */
	public partial class PaymentInfoType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string transactionIDField;
		public string TransactionID
		{
			get
			{
				return this.transactionIDField;
			}
			set
			{
				this.transactionIDField = value;
			}
		}
		

		/**
          *
		  */
		private string ebayTransactionIDField;
		public string EbayTransactionID
		{
			get
			{
				return this.ebayTransactionIDField;
			}
			set
			{
				this.ebayTransactionIDField = value;
			}
		}
		

		/**
          *
		  */
		private string parentTransactionIDField;
		public string ParentTransactionID
		{
			get
			{
				return this.parentTransactionIDField;
			}
			set
			{
				this.parentTransactionIDField = value;
			}
		}
		

		/**
          *
		  */
		private string receiptIDField;
		public string ReceiptID
		{
			get
			{
				return this.receiptIDField;
			}
			set
			{
				this.receiptIDField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentTransactionCodeType? transactionTypeField;
		public PaymentTransactionCodeType? TransactionType
		{
			get
			{
				return this.transactionTypeField;
			}
			set
			{
				this.transactionTypeField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentCodeType? paymentTypeField;
		public PaymentCodeType? PaymentType
		{
			get
			{
				return this.paymentTypeField;
			}
			set
			{
				this.paymentTypeField = value;
			}
		}
		

		/**
          *
		  */
		private RefundSourceCodeType? refundSourceCodeTypeField;
		public RefundSourceCodeType? RefundSourceCodeType
		{
			get
			{
				return this.refundSourceCodeTypeField;
			}
			set
			{
				this.refundSourceCodeTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string expectedeCheckClearDateField;
		public string ExpectedeCheckClearDate
		{
			get
			{
				return this.expectedeCheckClearDateField;
			}
			set
			{
				this.expectedeCheckClearDateField = value;
			}
		}
		

		/**
          *
		  */
		private string paymentDateField;
		public string PaymentDate
		{
			get
			{
				return this.paymentDateField;
			}
			set
			{
				this.paymentDateField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType grossAmountField;
		public BasicAmountType GrossAmount
		{
			get
			{
				return this.grossAmountField;
			}
			set
			{
				this.grossAmountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType feeAmountField;
		public BasicAmountType FeeAmount
		{
			get
			{
				return this.feeAmountField;
			}
			set
			{
				this.feeAmountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType settleAmountField;
		public BasicAmountType SettleAmount
		{
			get
			{
				return this.settleAmountField;
			}
			set
			{
				this.settleAmountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType taxAmountField;
		public BasicAmountType TaxAmount
		{
			get
			{
				return this.taxAmountField;
			}
			set
			{
				this.taxAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string exchangeRateField;
		public string ExchangeRate
		{
			get
			{
				return this.exchangeRateField;
			}
			set
			{
				this.exchangeRateField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentStatusCodeType? paymentStatusField;
		public PaymentStatusCodeType? PaymentStatus
		{
			get
			{
				return this.paymentStatusField;
			}
			set
			{
				this.paymentStatusField = value;
			}
		}
		

		/**
          *
		  */
		private PendingStatusCodeType? pendingReasonField;
		public PendingStatusCodeType? PendingReason
		{
			get
			{
				return this.pendingReasonField;
			}
			set
			{
				this.pendingReasonField = value;
			}
		}
		

		/**
          *
		  */
		private ReversalReasonCodeType? reasonCodeField;
		public ReversalReasonCodeType? ReasonCode
		{
			get
			{
				return this.reasonCodeField;
			}
			set
			{
				this.reasonCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string holdDecisionField;
		public string HoldDecision
		{
			get
			{
				return this.holdDecisionField;
			}
			set
			{
				this.holdDecisionField = value;
			}
		}
		

		/**
          *
		  */
		private string shippingMethodField;
		public string ShippingMethod
		{
			get
			{
				return this.shippingMethodField;
			}
			set
			{
				this.shippingMethodField = value;
			}
		}
		

		/**
          *
		  */
		private string protectionEligibilityField;
		public string ProtectionEligibility
		{
			get
			{
				return this.protectionEligibilityField;
			}
			set
			{
				this.protectionEligibilityField = value;
			}
		}
		

		/**
          *
		  */
		private string protectionEligibilityTypeField;
		public string ProtectionEligibilityType
		{
			get
			{
				return this.protectionEligibilityTypeField;
			}
			set
			{
				this.protectionEligibilityTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string receiptReferenceNumberField;
		public string ReceiptReferenceNumber
		{
			get
			{
				return this.receiptReferenceNumberField;
			}
			set
			{
				this.receiptReferenceNumberField = value;
			}
		}
		

		/**
          *
		  */
		private POSTransactionCodeType? pOSTransactionTypeField;
		public POSTransactionCodeType? POSTransactionType
		{
			get
			{
				return this.pOSTransactionTypeField;
			}
			set
			{
				this.pOSTransactionTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string shipAmountField;
		public string ShipAmount
		{
			get
			{
				return this.shipAmountField;
			}
			set
			{
				this.shipAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string shipHandleAmountField;
		public string ShipHandleAmount
		{
			get
			{
				return this.shipHandleAmountField;
			}
			set
			{
				this.shipHandleAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string shipDiscountField;
		public string ShipDiscount
		{
			get
			{
				return this.shipDiscountField;
			}
			set
			{
				this.shipDiscountField = value;
			}
		}
		

		/**
          *
		  */
		private string insuranceAmountField;
		public string InsuranceAmount
		{
			get
			{
				return this.insuranceAmountField;
			}
			set
			{
				this.insuranceAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string subjectField;
		public string Subject
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
		

		/**
          *
		  */
		private string storeIDField;
		public string StoreID
		{
			get
			{
				return this.storeIDField;
			}
			set
			{
				this.storeIDField = value;
			}
		}
		

		/**
          *
		  */
		private string terminalIDField;
		public string TerminalID
		{
			get
			{
				return this.terminalIDField;
			}
			set
			{
				this.terminalIDField = value;
			}
		}
		

		/**
          *
		  */
		private SellerDetailsType sellerDetailsField;
		public SellerDetailsType SellerDetails
		{
			get
			{
				return this.sellerDetailsField;
			}
			set
			{
				this.sellerDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string paymentRequestIDField;
		public string PaymentRequestID
		{
			get
			{
				return this.paymentRequestIDField;
			}
			set
			{
				this.paymentRequestIDField = value;
			}
		}
		

		/**
          *
		  */
		private FMFDetailsType fMFDetailsField;
		public FMFDetailsType FMFDetails
		{
			get
			{
				return this.fMFDetailsField;
			}
			set
			{
				this.fMFDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private EnhancedPaymentInfoType enhancedPaymentInfoField;
		public EnhancedPaymentInfoType EnhancedPaymentInfo
		{
			get
			{
				return this.enhancedPaymentInfoField;
			}
			set
			{
				this.enhancedPaymentInfoField = value;
			}
		}
		

		/**
          *
		  */
		private ErrorType paymentErrorField;
		public ErrorType PaymentError
		{
			get
			{
				return this.paymentErrorField;
			}
			set
			{
				this.paymentErrorField = value;
			}
		}
		

		/**
          *
		  */
		private InstrumentDetailsType instrumentDetailsField;
		public InstrumentDetailsType InstrumentDetails
		{
			get
			{
				return this.instrumentDetailsField;
			}
			set
			{
				this.instrumentDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private OfferDetailsType offerDetailsField;
		public OfferDetailsType OfferDetails
		{
			get
			{
				return this.offerDetailsField;
			}
			set
			{
				this.offerDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string binEligibilityField;
		public string BinEligibility
		{
			get
			{
				return this.binEligibilityField;
			}
			set
			{
				this.binEligibilityField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PaymentInfoType()
	 	{
		}


		public PaymentInfoType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TransactionID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TransactionID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'EbayTransactionID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.EbayTransactionID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ParentTransactionID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ParentTransactionID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ReceiptID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ReceiptID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TransactionType']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TransactionType = (PaymentTransactionCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(PaymentTransactionCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentType']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentType = (PaymentCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(PaymentCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RefundSourceCodeType']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RefundSourceCodeType = (RefundSourceCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(RefundSourceCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ExpectedeCheckClearDate']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ExpectedeCheckClearDate = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentDate']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentDate = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GrossAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GrossAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'FeeAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.FeeAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SettleAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SettleAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TaxAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TaxAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ExchangeRate']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ExchangeRate = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentStatus = (PaymentStatusCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(PaymentStatusCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PendingReason']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PendingReason = (PendingStatusCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(PendingStatusCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ReasonCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ReasonCode = (ReversalReasonCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(ReversalReasonCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'HoldDecision']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.HoldDecision = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ShippingMethod']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ShippingMethod = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ProtectionEligibility']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ProtectionEligibility = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ProtectionEligibilityType']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ProtectionEligibilityType = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ReceiptReferenceNumber']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ReceiptReferenceNumber = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'POSTransactionType']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.POSTransactionType = (POSTransactionCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(POSTransactionCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ShipAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ShipAmount = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ShipHandleAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ShipHandleAmount = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ShipDiscount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ShipDiscount = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'InsuranceAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.InsuranceAmount = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Subject']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Subject = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'StoreID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.StoreID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TerminalID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TerminalID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SellerDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SellerDetails =  new SellerDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentRequestID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentRequestID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'FMFDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.FMFDetails =  new FMFDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'EnhancedPaymentInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.EnhancedPaymentInfo =  new EnhancedPaymentInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentError']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentError =  new ErrorType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'InstrumentDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.InstrumentDetails =  new InstrumentDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OfferDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OfferDetails =  new OfferDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BinEligibility']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BinEligibility = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *SubscriptionTermsType Terms of a PayPal subscription. 
      */
	public partial class SubscriptionTermsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private string periodField;
		public string period
		{
			get
			{
				return this.periodField;
			}
			set
			{
				this.periodField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SubscriptionTermsType()
	 	{
		}


		public SubscriptionTermsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Amount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Amount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'period']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.period = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *SubscriptionInfoType Information about a PayPal
      *Subscription. 
      */
	public partial class SubscriptionInfoType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string subscriptionIDField;
		public string SubscriptionID
		{
			get
			{
				return this.subscriptionIDField;
			}
			set
			{
				this.subscriptionIDField = value;
			}
		}
		

		/**
          *
		  */
		private string subscriptionDateField;
		public string SubscriptionDate
		{
			get
			{
				return this.subscriptionDateField;
			}
			set
			{
				this.subscriptionDateField = value;
			}
		}
		

		/**
          *
		  */
		private string effectiveDateField;
		public string EffectiveDate
		{
			get
			{
				return this.effectiveDateField;
			}
			set
			{
				this.effectiveDateField = value;
			}
		}
		

		/**
          *
		  */
		private string retryTimeField;
		public string RetryTime
		{
			get
			{
				return this.retryTimeField;
			}
			set
			{
				this.retryTimeField = value;
			}
		}
		

		/**
          *
		  */
		private string usernameField;
		public string Username
		{
			get
			{
				return this.usernameField;
			}
			set
			{
				this.usernameField = value;
			}
		}
		

		/**
          *
		  */
		private string passwordField;
		public string Password
		{
			get
			{
				return this.passwordField;
			}
			set
			{
				this.passwordField = value;
			}
		}
		

		/**
          *
		  */
		private string recurrencesField;
		public string Recurrences
		{
			get
			{
				return this.recurrencesField;
			}
			set
			{
				this.recurrencesField = value;
			}
		}
		

		/**
          *
		  */
		private List<SubscriptionTermsType> termsField = new List<SubscriptionTermsType>();
		public List<SubscriptionTermsType> Terms
		{
			get
			{
				return this.termsField;
			}
			set
			{
				this.termsField = value;
			}
		}
		

		/**
          *
		  */
		private string reattemptField;
		public string reattempt
		{
			get
			{
				return this.reattemptField;
			}
			set
			{
				this.reattemptField = value;
			}
		}
		

		/**
          *
		  */
		private string recurringField;
		public string recurring
		{
			get
			{
				return this.recurringField;
			}
			set
			{
				this.recurringField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SubscriptionInfoType()
	 	{
		}


		public SubscriptionInfoType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SubscriptionID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SubscriptionID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SubscriptionDate']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SubscriptionDate = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'EffectiveDate']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.EffectiveDate = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RetryTime']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RetryTime = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Username']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Username = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Password']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Password = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Recurrences']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Recurrences = ChildNode.InnerText;
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'Terms']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.Terms.Add(new SubscriptionTermsType(subNode));
				}
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'reattempt']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.reattempt = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'recurring']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.recurring = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *AuctionInfoType Basic information about an auction. 
      */
	public partial class AuctionInfoType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string buyerIDField;
		public string BuyerID
		{
			get
			{
				return this.buyerIDField;
			}
			set
			{
				this.buyerIDField = value;
			}
		}
		

		/**
          *
		  */
		private string closingDateField;
		public string ClosingDate
		{
			get
			{
				return this.closingDateField;
			}
			set
			{
				this.closingDateField = value;
			}
		}
		

		/**
          *
		  */
		private string multiItemField;
		public string multiItem
		{
			get
			{
				return this.multiItemField;
			}
			set
			{
				this.multiItemField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public AuctionInfoType()
	 	{
		}


		public AuctionInfoType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BuyerID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BuyerID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ClosingDate']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ClosingDate = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'multiItem']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.multiItem = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *OptionType PayPal item options for shopping cart. 
      */
	public partial class OptionType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string nameField;
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
		

		/**
          *
		  */
		private string valueField;
		public string value
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
		

		/**
	 	  * Default Constructor
	 	  */
	 	public OptionType()
	 	{
		}


		public OptionType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'name']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.name = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'value']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.value = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *EbayItemPaymentDetailsItemType - Type declaration to be used
      *by other schemas. Information about an Ebay Payment Item. 
      */
	public partial class EbayItemPaymentDetailsItemType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string itemNumberField;
		public string ItemNumber
		{
			get
			{
				return this.itemNumberField;
			}
			set
			{
				this.itemNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string auctionTransactionIdField;
		public string AuctionTransactionId
		{
			get
			{
				return this.auctionTransactionIdField;
			}
			set
			{
				this.auctionTransactionIdField = value;
			}
		}
		

		/**
          *
		  */
		private string orderIdField;
		public string OrderId
		{
			get
			{
				return this.orderIdField;
			}
			set
			{
				this.orderIdField = value;
			}
		}
		

		/**
          *
		  */
		private string cartIDField;
		public string CartID
		{
			get
			{
				return this.cartIDField;
			}
			set
			{
				this.cartIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public EbayItemPaymentDetailsItemType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ItemNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ItemNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemNumber>");
			}
			if(AuctionTransactionId != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AuctionTransactionId>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.AuctionTransactionId));
				sb.Append("</").Append(PreferredPrefix).Append(":AuctionTransactionId>");
			}
			if(OrderId != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OrderId>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OrderId));
				sb.Append("</").Append(PreferredPrefix).Append(":OrderId>");
			}
			if(CartID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CartID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CartID));
				sb.Append("</").Append(PreferredPrefix).Append(":CartID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public EbayItemPaymentDetailsItemType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemNumber']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemNumber = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AuctionTransactionId']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AuctionTransactionId = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OrderId']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OrderId = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CartID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CartID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *PaymentDetailsItemType Information about a Payment Item. 
      */
	public partial class PaymentDetailsItemType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string nameField;
		public string Name
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
		

		/**
          *
		  */
		private string numberField;
		public string Number
		{
			get
			{
				return this.numberField;
			}
			set
			{
				this.numberField = value;
			}
		}
		

		/**
          *
		  */
		private int? quantityField;
		public int? Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType taxField;
		public BasicAmountType Tax
		{
			get
			{
				return this.taxField;
			}
			set
			{
				this.taxField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private EbayItemPaymentDetailsItemType ebayItemPaymentDetailsItemField;
		public EbayItemPaymentDetailsItemType EbayItemPaymentDetailsItem
		{
			get
			{
				return this.ebayItemPaymentDetailsItemField;
			}
			set
			{
				this.ebayItemPaymentDetailsItemField = value;
			}
		}
		

		/**
          *
		  */
		private string promoCodeField;
		public string PromoCode
		{
			get
			{
				return this.promoCodeField;
			}
			set
			{
				this.promoCodeField = value;
			}
		}
		

		/**
          *
		  */
		private ProductCategoryType? productCategoryField;
		public ProductCategoryType? ProductCategory
		{
			get
			{
				return this.productCategoryField;
			}
			set
			{
				this.productCategoryField = value;
			}
		}
		

		/**
          *
		  */
		private string descriptionField;
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		

		/**
          *
		  */
		private MeasureType itemWeightField;
		public MeasureType ItemWeight
		{
			get
			{
				return this.itemWeightField;
			}
			set
			{
				this.itemWeightField = value;
			}
		}
		

		/**
          *
		  */
		private MeasureType itemLengthField;
		public MeasureType ItemLength
		{
			get
			{
				return this.itemLengthField;
			}
			set
			{
				this.itemLengthField = value;
			}
		}
		

		/**
          *
		  */
		private MeasureType itemWidthField;
		public MeasureType ItemWidth
		{
			get
			{
				return this.itemWidthField;
			}
			set
			{
				this.itemWidthField = value;
			}
		}
		

		/**
          *
		  */
		private MeasureType itemHeightField;
		public MeasureType ItemHeight
		{
			get
			{
				return this.itemHeightField;
			}
			set
			{
				this.itemHeightField = value;
			}
		}
		

		/**
          *
		  */
		private string itemURLField;
		public string ItemURL
		{
			get
			{
				return this.itemURLField;
			}
			set
			{
				this.itemURLField = value;
			}
		}
		

		/**
          *
		  */
		private EnhancedItemDataType enhancedItemDataField;
		public EnhancedItemDataType EnhancedItemData
		{
			get
			{
				return this.enhancedItemDataField;
			}
			set
			{
				this.enhancedItemDataField = value;
			}
		}
		

		/**
          *
		  */
		private ItemCategoryType? itemCategoryField;
		public ItemCategoryType? ItemCategory
		{
			get
			{
				return this.itemCategoryField;
			}
			set
			{
				this.itemCategoryField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PaymentDetailsItemType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Name != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Name>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Name));
				sb.Append("</").Append(PreferredPrefix).Append(":Name>");
			}
			if(Number != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Number>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Number));
				sb.Append("</").Append(PreferredPrefix).Append(":Number>");
			}
			if(Quantity != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Quantity>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Quantity));
				sb.Append("</").Append(PreferredPrefix).Append(":Quantity>");
			}
			if(Tax != null)
			{
				sb.Append(Tax.ToXMLString(PreferredPrefix,"Tax"));
			}
			if(Amount != null)
			{
				sb.Append(Amount.ToXMLString(PreferredPrefix,"Amount"));
			}
			if(EbayItemPaymentDetailsItem != null)
			{
				sb.Append(EbayItemPaymentDetailsItem.ToXMLString(PreferredPrefix,"EbayItemPaymentDetailsItem"));
			}
			if(PromoCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PromoCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PromoCode));
				sb.Append("</").Append(PreferredPrefix).Append(":PromoCode>");
			}
			if(ProductCategory != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ProductCategory>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ProductCategory)));
				sb.Append("</").Append(PreferredPrefix).Append(":ProductCategory>");
			}
			if(Description != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Description>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Description));
				sb.Append("</").Append(PreferredPrefix).Append(":Description>");
			}
			if(ItemWeight != null)
			{
				sb.Append(ItemWeight.ToXMLString(PreferredPrefix,"ItemWeight"));
			}
			if(ItemLength != null)
			{
				sb.Append(ItemLength.ToXMLString(PreferredPrefix,"ItemLength"));
			}
			if(ItemWidth != null)
			{
				sb.Append(ItemWidth.ToXMLString(PreferredPrefix,"ItemWidth"));
			}
			if(ItemHeight != null)
			{
				sb.Append(ItemHeight.ToXMLString(PreferredPrefix,"ItemHeight"));
			}
			if(ItemURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ItemURL));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemURL>");
			}
			if(EnhancedItemData != null)
			{
				sb.Append(EnhancedItemData.ToXMLString(PreferredPrefix,"EnhancedItemData"));
			}
			if(ItemCategory != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemCategory>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ItemCategory)));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemCategory>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public PaymentDetailsItemType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Name']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Name = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Number']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Number = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Quantity']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Quantity = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Tax']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Tax =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Amount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Amount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'EbayItemPaymentDetailsItem']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.EbayItemPaymentDetailsItem =  new EbayItemPaymentDetailsItemType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PromoCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PromoCode = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ProductCategory']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ProductCategory = (ProductCategoryType)EnumUtils.GetValue(ChildNode.InnerText,typeof(ProductCategoryType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Description']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Description = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemWeight']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemWeight =  new MeasureType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemLength']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemLength =  new MeasureType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemWidth']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemWidth =  new MeasureType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemHeight']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemHeight =  new MeasureType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemURL']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemURL = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'EnhancedItemData']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.EnhancedItemData =  new EnhancedItemDataType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemCategory']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemCategory = (ItemCategoryType)EnumUtils.GetValue(ChildNode.InnerText,typeof(ItemCategoryType));
			}
	
		}
	}




	/**
      *PaymentItemType Information about a Payment Item. 
      */
	public partial class PaymentItemType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string ebayItemTxnIdField;
		public string EbayItemTxnId
		{
			get
			{
				return this.ebayItemTxnIdField;
			}
			set
			{
				this.ebayItemTxnIdField = value;
			}
		}
		

		/**
          *
		  */
		private string nameField;
		public string Name
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
		

		/**
          *
		  */
		private string numberField;
		public string Number
		{
			get
			{
				return this.numberField;
			}
			set
			{
				this.numberField = value;
			}
		}
		

		/**
          *
		  */
		private string quantityField;
		public string Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
			}
		}
		

		/**
          *
		  */
		private string salesTaxField;
		public string SalesTax
		{
			get
			{
				return this.salesTaxField;
			}
			set
			{
				this.salesTaxField = value;
			}
		}
		

		/**
          *
		  */
		private string shippingAmountField;
		public string ShippingAmount
		{
			get
			{
				return this.shippingAmountField;
			}
			set
			{
				this.shippingAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string handlingAmountField;
		public string HandlingAmount
		{
			get
			{
				return this.handlingAmountField;
			}
			set
			{
				this.handlingAmountField = value;
			}
		}
		

		/**
          *
		  */
		private InvoiceItemType invoiceItemDetailsField;
		public InvoiceItemType InvoiceItemDetails
		{
			get
			{
				return this.invoiceItemDetailsField;
			}
			set
			{
				this.invoiceItemDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string couponIDField;
		public string CouponID
		{
			get
			{
				return this.couponIDField;
			}
			set
			{
				this.couponIDField = value;
			}
		}
		

		/**
          *
		  */
		private string couponAmountField;
		public string CouponAmount
		{
			get
			{
				return this.couponAmountField;
			}
			set
			{
				this.couponAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string couponAmountCurrencyField;
		public string CouponAmountCurrency
		{
			get
			{
				return this.couponAmountCurrencyField;
			}
			set
			{
				this.couponAmountCurrencyField = value;
			}
		}
		

		/**
          *
		  */
		private string loyaltyCardDiscountAmountField;
		public string LoyaltyCardDiscountAmount
		{
			get
			{
				return this.loyaltyCardDiscountAmountField;
			}
			set
			{
				this.loyaltyCardDiscountAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string loyaltyCardDiscountCurrencyField;
		public string LoyaltyCardDiscountCurrency
		{
			get
			{
				return this.loyaltyCardDiscountCurrencyField;
			}
			set
			{
				this.loyaltyCardDiscountCurrencyField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private List<OptionType> optionsField = new List<OptionType>();
		public List<OptionType> Options
		{
			get
			{
				return this.optionsField;
			}
			set
			{
				this.optionsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PaymentItemType()
	 	{
		}


		public PaymentItemType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'EbayItemTxnId']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.EbayItemTxnId = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Name']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Name = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Number']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Number = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Quantity']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Quantity = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SalesTax']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SalesTax = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ShippingAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ShippingAmount = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'HandlingAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.HandlingAmount = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'InvoiceItemDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.InvoiceItemDetails =  new InvoiceItemType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CouponID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CouponID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CouponAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CouponAmount = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CouponAmountCurrency']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CouponAmountCurrency = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'LoyaltyCardDiscountAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.LoyaltyCardDiscountAmount = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'LoyaltyCardDiscountCurrency']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.LoyaltyCardDiscountCurrency = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Amount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Amount =  new BasicAmountType(ChildNode);
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'Options']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.Options.Add(new OptionType(subNode));
				}
			}
	
		}
	}




	/**
      *PaymentItemInfoType Information about a PayPal item. 
      */
	public partial class PaymentItemInfoType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string invoiceIDField;
		public string InvoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/**
          *
		  */
		private string customField;
		public string Custom
		{
			get
			{
				return this.customField;
			}
			set
			{
				this.customField = value;
			}
		}
		

		/**
          *
		  */
		private string memoField;
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
			}
		}
		

		/**
          *
		  */
		private string salesTaxField;
		public string SalesTax
		{
			get
			{
				return this.salesTaxField;
			}
			set
			{
				this.salesTaxField = value;
			}
		}
		

		/**
          *
		  */
		private List<PaymentItemType> paymentItemField = new List<PaymentItemType>();
		public List<PaymentItemType> PaymentItem
		{
			get
			{
				return this.paymentItemField;
			}
			set
			{
				this.paymentItemField = value;
			}
		}
		

		/**
          *
		  */
		private SubscriptionInfoType subscriptionField;
		public SubscriptionInfoType Subscription
		{
			get
			{
				return this.subscriptionField;
			}
			set
			{
				this.subscriptionField = value;
			}
		}
		

		/**
          *
		  */
		private AuctionInfoType auctionField;
		public AuctionInfoType Auction
		{
			get
			{
				return this.auctionField;
			}
			set
			{
				this.auctionField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PaymentItemInfoType()
	 	{
		}


		public PaymentItemInfoType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'InvoiceID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.InvoiceID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Custom']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Custom = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Memo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Memo = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SalesTax']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SalesTax = ChildNode.InnerText;
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'PaymentItem']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.PaymentItem.Add(new PaymentItemType(subNode));
				}
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Subscription']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Subscription =  new SubscriptionInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Auction']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Auction =  new AuctionInfoType(ChildNode);
			}
	
		}
	}




	/**
      *OffersAndCouponsInfoType Information about a Offers and
      *Coupons. 
      */
	public partial class OfferCouponInfoType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string typeField;
		public string Type
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
		

		/**
          *
		  */
		private string iDField;
		public string ID
		{
			get
			{
				return this.iDField;
			}
			set
			{
				this.iDField = value;
			}
		}
		

		/**
          *
		  */
		private string amountField;
		public string Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private string amountCurrencyField;
		public string AmountCurrency
		{
			get
			{
				return this.amountCurrencyField;
			}
			set
			{
				this.amountCurrencyField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public OfferCouponInfoType()
	 	{
		}


		public OfferCouponInfoType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Type']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Type = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Amount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Amount = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AmountCurrency']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AmountCurrency = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *PaymentDetailsType Information about a payment. Used by DCC
      *and Express Checkout. 
      */
	public partial class PaymentDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BasicAmountType orderTotalField;
		public BasicAmountType OrderTotal
		{
			get
			{
				return this.orderTotalField;
			}
			set
			{
				this.orderTotalField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType itemTotalField;
		public BasicAmountType ItemTotal
		{
			get
			{
				return this.itemTotalField;
			}
			set
			{
				this.itemTotalField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType shippingTotalField;
		public BasicAmountType ShippingTotal
		{
			get
			{
				return this.shippingTotalField;
			}
			set
			{
				this.shippingTotalField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType handlingTotalField;
		public BasicAmountType HandlingTotal
		{
			get
			{
				return this.handlingTotalField;
			}
			set
			{
				this.handlingTotalField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType taxTotalField;
		public BasicAmountType TaxTotal
		{
			get
			{
				return this.taxTotalField;
			}
			set
			{
				this.taxTotalField = value;
			}
		}
		

		/**
          *
		  */
		private string orderDescriptionField;
		public string OrderDescription
		{
			get
			{
				return this.orderDescriptionField;
			}
			set
			{
				this.orderDescriptionField = value;
			}
		}
		

		/**
          *
		  */
		private string customField;
		public string Custom
		{
			get
			{
				return this.customField;
			}
			set
			{
				this.customField = value;
			}
		}
		

		/**
          *
		  */
		private string invoiceIDField;
		public string InvoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/**
          *
		  */
		private string buttonSourceField;
		public string ButtonSource
		{
			get
			{
				return this.buttonSourceField;
			}
			set
			{
				this.buttonSourceField = value;
			}
		}
		

		/**
          *
		  */
		private string notifyURLField;
		public string NotifyURL
		{
			get
			{
				return this.notifyURLField;
			}
			set
			{
				this.notifyURLField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType shipToAddressField;
		public AddressType ShipToAddress
		{
			get
			{
				return this.shipToAddressField;
			}
			set
			{
				this.shipToAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string fulfillmentReferenceNumberField;
		public string FulfillmentReferenceNumber
		{
			get
			{
				return this.fulfillmentReferenceNumberField;
			}
			set
			{
				this.fulfillmentReferenceNumberField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType fulfillmentAddressField;
		public AddressType FulfillmentAddress
		{
			get
			{
				return this.fulfillmentAddressField;
			}
			set
			{
				this.fulfillmentAddressField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentCategoryType? paymentCategoryTypeField;
		public PaymentCategoryType? PaymentCategoryType
		{
			get
			{
				return this.paymentCategoryTypeField;
			}
			set
			{
				this.paymentCategoryTypeField = value;
			}
		}
		

		/**
          *
		  */
		private ShippingServiceCodeType? shippingMethodField;
		public ShippingServiceCodeType? ShippingMethod
		{
			get
			{
				return this.shippingMethodField;
			}
			set
			{
				this.shippingMethodField = value;
			}
		}
		

		/**
          *
		  */
		private string profileAddressChangeDateField;
		public string ProfileAddressChangeDate
		{
			get
			{
				return this.profileAddressChangeDateField;
			}
			set
			{
				this.profileAddressChangeDateField = value;
			}
		}
		

		/**
          *
		  */
		private List<PaymentDetailsItemType> paymentDetailsItemField = new List<PaymentDetailsItemType>();
		public List<PaymentDetailsItemType> PaymentDetailsItem
		{
			get
			{
				return this.paymentDetailsItemField;
			}
			set
			{
				this.paymentDetailsItemField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType insuranceTotalField;
		public BasicAmountType InsuranceTotal
		{
			get
			{
				return this.insuranceTotalField;
			}
			set
			{
				this.insuranceTotalField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType shippingDiscountField;
		public BasicAmountType ShippingDiscount
		{
			get
			{
				return this.shippingDiscountField;
			}
			set
			{
				this.shippingDiscountField = value;
			}
		}
		

		/**
          *
		  */
		private string insuranceOptionOfferedField;
		public string InsuranceOptionOffered
		{
			get
			{
				return this.insuranceOptionOfferedField;
			}
			set
			{
				this.insuranceOptionOfferedField = value;
			}
		}
		

		/**
          *
		  */
		private AllowedPaymentMethodType? allowedPaymentMethodField;
		public AllowedPaymentMethodType? AllowedPaymentMethod
		{
			get
			{
				return this.allowedPaymentMethodField;
			}
			set
			{
				this.allowedPaymentMethodField = value;
			}
		}
		

		/**
          *
		  */
		private EnhancedPaymentDataType enhancedPaymentDataField;
		public EnhancedPaymentDataType EnhancedPaymentData
		{
			get
			{
				return this.enhancedPaymentDataField;
			}
			set
			{
				this.enhancedPaymentDataField = value;
			}
		}
		

		/**
          *
		  */
		private SellerDetailsType sellerDetailsField;
		public SellerDetailsType SellerDetails
		{
			get
			{
				return this.sellerDetailsField;
			}
			set
			{
				this.sellerDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string noteTextField;
		public string NoteText
		{
			get
			{
				return this.noteTextField;
			}
			set
			{
				this.noteTextField = value;
			}
		}
		

		/**
          *
		  */
		private string transactionIdField;
		public string TransactionId
		{
			get
			{
				return this.transactionIdField;
			}
			set
			{
				this.transactionIdField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentActionCodeType? paymentActionField;
		public PaymentActionCodeType? PaymentAction
		{
			get
			{
				return this.paymentActionField;
			}
			set
			{
				this.paymentActionField = value;
			}
		}
		

		/**
          *
		  */
		private string paymentRequestIDField;
		public string PaymentRequestID
		{
			get
			{
				return this.paymentRequestIDField;
			}
			set
			{
				this.paymentRequestIDField = value;
			}
		}
		

		/**
          *
		  */
		private string orderURLField;
		public string OrderURL
		{
			get
			{
				return this.orderURLField;
			}
			set
			{
				this.orderURLField = value;
			}
		}
		

		/**
          *
		  */
		private string softDescriptorField;
		public string SoftDescriptor
		{
			get
			{
				return this.softDescriptorField;
			}
			set
			{
				this.softDescriptorField = value;
			}
		}
		

		/**
          *
		  */
		private int? branchLevelField;
		public int? BranchLevel
		{
			get
			{
				return this.branchLevelField;
			}
			set
			{
				this.branchLevelField = value;
			}
		}
		

		/**
          *
		  */
		private OfferDetailsType offerDetailsField;
		public OfferDetailsType OfferDetails
		{
			get
			{
				return this.offerDetailsField;
			}
			set
			{
				this.offerDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private RecurringFlagType? recurringField;
		public RecurringFlagType? Recurring
		{
			get
			{
				return this.recurringField;
			}
			set
			{
				this.recurringField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentReasonType? paymentReasonField;
		public PaymentReasonType? PaymentReason
		{
			get
			{
				return this.paymentReasonField;
			}
			set
			{
				this.paymentReasonField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PaymentDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(OrderTotal != null)
			{
				sb.Append(OrderTotal.ToXMLString(PreferredPrefix,"OrderTotal"));
			}
			if(ItemTotal != null)
			{
				sb.Append(ItemTotal.ToXMLString(PreferredPrefix,"ItemTotal"));
			}
			if(ShippingTotal != null)
			{
				sb.Append(ShippingTotal.ToXMLString(PreferredPrefix,"ShippingTotal"));
			}
			if(HandlingTotal != null)
			{
				sb.Append(HandlingTotal.ToXMLString(PreferredPrefix,"HandlingTotal"));
			}
			if(TaxTotal != null)
			{
				sb.Append(TaxTotal.ToXMLString(PreferredPrefix,"TaxTotal"));
			}
			if(OrderDescription != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OrderDescription>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OrderDescription));
				sb.Append("</").Append(PreferredPrefix).Append(":OrderDescription>");
			}
			if(Custom != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Custom>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Custom));
				sb.Append("</").Append(PreferredPrefix).Append(":Custom>");
			}
			if(InvoiceID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":InvoiceID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.InvoiceID));
				sb.Append("</").Append(PreferredPrefix).Append(":InvoiceID>");
			}
			if(ButtonSource != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonSource>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ButtonSource));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonSource>");
			}
			if(NotifyURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":NotifyURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.NotifyURL));
				sb.Append("</").Append(PreferredPrefix).Append(":NotifyURL>");
			}
			if(ShipToAddress != null)
			{
				sb.Append(ShipToAddress.ToXMLString(PreferredPrefix,"ShipToAddress"));
			}
			if(FulfillmentReferenceNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":FulfillmentReferenceNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.FulfillmentReferenceNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":FulfillmentReferenceNumber>");
			}
			if(FulfillmentAddress != null)
			{
				sb.Append(FulfillmentAddress.ToXMLString(PreferredPrefix,"FulfillmentAddress"));
			}
			if(PaymentCategoryType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PaymentCategoryType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.PaymentCategoryType)));
				sb.Append("</").Append(PreferredPrefix).Append(":PaymentCategoryType>");
			}
			if(ShippingMethod != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ShippingMethod>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ShippingMethod)));
				sb.Append("</").Append(PreferredPrefix).Append(":ShippingMethod>");
			}
			if(ProfileAddressChangeDate != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ProfileAddressChangeDate>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ProfileAddressChangeDate));
				sb.Append("</").Append(PreferredPrefix).Append(":ProfileAddressChangeDate>");
			}
			if(PaymentDetailsItem != null)
			{
				for(int i = 0; i < PaymentDetailsItem.Count; i++)
				{
					sb.Append(PaymentDetailsItem[i].ToXMLString(PreferredPrefix,"PaymentDetailsItem"));
				}
			}
			if(InsuranceTotal != null)
			{
				sb.Append(InsuranceTotal.ToXMLString(PreferredPrefix,"InsuranceTotal"));
			}
			if(ShippingDiscount != null)
			{
				sb.Append(ShippingDiscount.ToXMLString(PreferredPrefix,"ShippingDiscount"));
			}
			if(InsuranceOptionOffered != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":InsuranceOptionOffered>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.InsuranceOptionOffered));
				sb.Append("</").Append(PreferredPrefix).Append(":InsuranceOptionOffered>");
			}
			if(AllowedPaymentMethod != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AllowedPaymentMethod>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.AllowedPaymentMethod)));
				sb.Append("</").Append(PreferredPrefix).Append(":AllowedPaymentMethod>");
			}
			if(EnhancedPaymentData != null)
			{
				sb.Append(EnhancedPaymentData.ToXMLString(PreferredPrefix,"EnhancedPaymentData"));
			}
			if(SellerDetails != null)
			{
				sb.Append(SellerDetails.ToXMLString(PreferredPrefix,"SellerDetails"));
			}
			if(NoteText != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":NoteText>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.NoteText));
				sb.Append("</").Append(PreferredPrefix).Append(":NoteText>");
			}
			if(TransactionId != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TransactionId>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TransactionId));
				sb.Append("</").Append(PreferredPrefix).Append(":TransactionId>");
			}
			if(PaymentAction != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PaymentAction>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.PaymentAction)));
				sb.Append("</").Append(PreferredPrefix).Append(":PaymentAction>");
			}
			if(PaymentRequestID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PaymentRequestID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PaymentRequestID));
				sb.Append("</").Append(PreferredPrefix).Append(":PaymentRequestID>");
			}
			if(OrderURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OrderURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OrderURL));
				sb.Append("</").Append(PreferredPrefix).Append(":OrderURL>");
			}
			if(SoftDescriptor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SoftDescriptor>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SoftDescriptor));
				sb.Append("</").Append(PreferredPrefix).Append(":SoftDescriptor>");
			}
			if(BranchLevel != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BranchLevel>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BranchLevel));
				sb.Append("</").Append(PreferredPrefix).Append(":BranchLevel>");
			}
			if(OfferDetails != null)
			{
				sb.Append(OfferDetails.ToXMLString(PreferredPrefix,"OfferDetails"));
			}
			if(Recurring != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Recurring>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.Recurring)));
				sb.Append("</").Append(PreferredPrefix).Append(":Recurring>");
			}
			if(PaymentReason != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PaymentReason>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.PaymentReason)));
				sb.Append("</").Append(PreferredPrefix).Append(":PaymentReason>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public PaymentDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OrderTotal']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OrderTotal =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemTotal']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemTotal =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ShippingTotal']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ShippingTotal =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'HandlingTotal']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.HandlingTotal =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TaxTotal']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TaxTotal =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OrderDescription']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OrderDescription = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Custom']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Custom = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'InvoiceID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.InvoiceID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ButtonSource']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ButtonSource = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'NotifyURL']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.NotifyURL = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ShipToAddress']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ShipToAddress =  new AddressType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'FulfillmentReferenceNumber']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.FulfillmentReferenceNumber = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'FulfillmentAddress']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.FulfillmentAddress =  new AddressType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentCategoryType']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentCategoryType = (PaymentCategoryType)EnumUtils.GetValue(ChildNode.InnerText,typeof(PaymentCategoryType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ShippingMethod']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ShippingMethod = (ShippingServiceCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(ShippingServiceCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ProfileAddressChangeDate']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ProfileAddressChangeDate = ChildNode.InnerText;
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'PaymentDetailsItem']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.PaymentDetailsItem.Add(new PaymentDetailsItemType(subNode));
				}
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'InsuranceTotal']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.InsuranceTotal =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ShippingDiscount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ShippingDiscount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'InsuranceOptionOffered']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.InsuranceOptionOffered = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AllowedPaymentMethod']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AllowedPaymentMethod = (AllowedPaymentMethodType)EnumUtils.GetValue(ChildNode.InnerText,typeof(AllowedPaymentMethodType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'EnhancedPaymentData']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.EnhancedPaymentData =  new EnhancedPaymentDataType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SellerDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SellerDetails =  new SellerDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'NoteText']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.NoteText = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TransactionId']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TransactionId = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentAction']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentAction = (PaymentActionCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(PaymentActionCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentRequestID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentRequestID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OrderURL']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OrderURL = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SoftDescriptor']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SoftDescriptor = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BranchLevel']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BranchLevel = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OfferDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OfferDetails =  new OfferDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Recurring']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Recurring = (RecurringFlagType)EnumUtils.GetValue(ChildNode.InnerText,typeof(RecurringFlagType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentReason']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentReason = (PaymentReasonType)EnumUtils.GetValue(ChildNode.InnerText,typeof(PaymentReasonType));
			}
	
		}
	}




	/**
      *Information about the incentives that were applied from Ebay
      *RYP page and PayPal RYP page. 
      */
	public partial class IncentiveDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string uniqueIdentifierField;
		public string UniqueIdentifier
		{
			get
			{
				return this.uniqueIdentifierField;
			}
			set
			{
				this.uniqueIdentifierField = value;
			}
		}
		

		/**
          *
		  */
		private IncentiveSiteAppliedOnType? siteAppliedOnField;
		public IncentiveSiteAppliedOnType? SiteAppliedOn
		{
			get
			{
				return this.siteAppliedOnField;
			}
			set
			{
				this.siteAppliedOnField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType totalDiscountAmountField;
		public BasicAmountType TotalDiscountAmount
		{
			get
			{
				return this.totalDiscountAmountField;
			}
			set
			{
				this.totalDiscountAmountField = value;
			}
		}
		

		/**
          *
		  */
		private IncentiveAppliedStatusType? statusField;
		public IncentiveAppliedStatusType? Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		

		/**
          *
		  */
		private int? errorCodeField;
		public int? ErrorCode
		{
			get
			{
				return this.errorCodeField;
			}
			set
			{
				this.errorCodeField = value;
			}
		}
		

		/**
          *
		  */
		private List<IncentiveAppliedDetailsType> incentiveAppliedDetailsField = new List<IncentiveAppliedDetailsType>();
		public List<IncentiveAppliedDetailsType> IncentiveAppliedDetails
		{
			get
			{
				return this.incentiveAppliedDetailsField;
			}
			set
			{
				this.incentiveAppliedDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public IncentiveDetailsType()
	 	{
		}


		public IncentiveDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'UniqueIdentifier']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.UniqueIdentifier = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SiteAppliedOn']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SiteAppliedOn = (IncentiveSiteAppliedOnType)EnumUtils.GetValue(ChildNode.InnerText,typeof(IncentiveSiteAppliedOnType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TotalDiscountAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TotalDiscountAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Status']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Status = (IncentiveAppliedStatusType)EnumUtils.GetValue(ChildNode.InnerText,typeof(IncentiveAppliedStatusType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ErrorCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ErrorCode = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'IncentiveAppliedDetails']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.IncentiveAppliedDetails.Add(new IncentiveAppliedDetailsType(subNode));
				}
			}
	
		}
	}




	/**
      *Details of incentive application on individual bucket/item. 
      */
	public partial class IncentiveAppliedDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string paymentRequestIDField;
		public string PaymentRequestID
		{
			get
			{
				return this.paymentRequestIDField;
			}
			set
			{
				this.paymentRequestIDField = value;
			}
		}
		

		/**
          *
		  */
		private string itemIdField;
		public string ItemId
		{
			get
			{
				return this.itemIdField;
			}
			set
			{
				this.itemIdField = value;
			}
		}
		

		/**
          *
		  */
		private string externalTxnIdField;
		public string ExternalTxnId
		{
			get
			{
				return this.externalTxnIdField;
			}
			set
			{
				this.externalTxnIdField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType discountAmountField;
		public BasicAmountType DiscountAmount
		{
			get
			{
				return this.discountAmountField;
			}
			set
			{
				this.discountAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string subTypeField;
		public string SubType
		{
			get
			{
				return this.subTypeField;
			}
			set
			{
				this.subTypeField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public IncentiveAppliedDetailsType()
	 	{
		}


		public IncentiveAppliedDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentRequestID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentRequestID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemId']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemId = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ExternalTxnId']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ExternalTxnId = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'DiscountAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.DiscountAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SubType']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SubType = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Details about the seller. 
      */
	public partial class SellerDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string sellerIdField;
		public string SellerId
		{
			get
			{
				return this.sellerIdField;
			}
			set
			{
				this.sellerIdField = value;
			}
		}
		

		/**
          *
		  */
		private string sellerUserNameField;
		public string SellerUserName
		{
			get
			{
				return this.sellerUserNameField;
			}
			set
			{
				this.sellerUserNameField = value;
			}
		}
		

		/**
          *
		  */
		private string sellerRegistrationDateField;
		public string SellerRegistrationDate
		{
			get
			{
				return this.sellerRegistrationDateField;
			}
			set
			{
				this.sellerRegistrationDateField = value;
			}
		}
		

		/**
          *
		  */
		private string payPalAccountIDField;
		public string PayPalAccountID
		{
			get
			{
				return this.payPalAccountIDField;
			}
			set
			{
				this.payPalAccountIDField = value;
			}
		}
		

		/**
          *
		  */
		private string secureMerchantAccountIDField;
		public string SecureMerchantAccountID
		{
			get
			{
				return this.secureMerchantAccountIDField;
			}
			set
			{
				this.secureMerchantAccountIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SellerDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(SellerId != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SellerId>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SellerId));
				sb.Append("</").Append(PreferredPrefix).Append(":SellerId>");
			}
			if(SellerUserName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SellerUserName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SellerUserName));
				sb.Append("</").Append(PreferredPrefix).Append(":SellerUserName>");
			}
			if(SellerRegistrationDate != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SellerRegistrationDate>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SellerRegistrationDate));
				sb.Append("</").Append(PreferredPrefix).Append(":SellerRegistrationDate>");
			}
			if(PayPalAccountID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PayPalAccountID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PayPalAccountID));
				sb.Append("</").Append(PreferredPrefix).Append(":PayPalAccountID>");
			}
			if(SecureMerchantAccountID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SecureMerchantAccountID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SecureMerchantAccountID));
				sb.Append("</").Append(PreferredPrefix).Append(":SecureMerchantAccountID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public SellerDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SellerId']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SellerId = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SellerUserName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SellerUserName = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SellerRegistrationDate']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SellerRegistrationDate = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PayPalAccountID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PayPalAccountID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SecureMerchantAccountID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SecureMerchantAccountID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Lists the Payment Methods (other than PayPal) that the use
      *can pay with e.g. Money Order. Optional. 
      */
	public partial class OtherPaymentMethodDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string otherPaymentMethodIdField;
		public string OtherPaymentMethodId
		{
			get
			{
				return this.otherPaymentMethodIdField;
			}
			set
			{
				this.otherPaymentMethodIdField = value;
			}
		}
		

		/**
          *
		  */
		private string otherPaymentMethodTypeField;
		public string OtherPaymentMethodType
		{
			get
			{
				return this.otherPaymentMethodTypeField;
			}
			set
			{
				this.otherPaymentMethodTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string otherPaymentMethodLabelField;
		public string OtherPaymentMethodLabel
		{
			get
			{
				return this.otherPaymentMethodLabelField;
			}
			set
			{
				this.otherPaymentMethodLabelField = value;
			}
		}
		

		/**
          *
		  */
		private string otherPaymentMethodLabelDescriptionField;
		public string OtherPaymentMethodLabelDescription
		{
			get
			{
				return this.otherPaymentMethodLabelDescriptionField;
			}
			set
			{
				this.otherPaymentMethodLabelDescriptionField = value;
			}
		}
		

		/**
          *
		  */
		private string otherPaymentMethodLongDescriptionTitleField;
		public string OtherPaymentMethodLongDescriptionTitle
		{
			get
			{
				return this.otherPaymentMethodLongDescriptionTitleField;
			}
			set
			{
				this.otherPaymentMethodLongDescriptionTitleField = value;
			}
		}
		

		/**
          *
		  */
		private string otherPaymentMethodLongDescriptionField;
		public string OtherPaymentMethodLongDescription
		{
			get
			{
				return this.otherPaymentMethodLongDescriptionField;
			}
			set
			{
				this.otherPaymentMethodLongDescriptionField = value;
			}
		}
		

		/**
          *
		  */
		private string otherPaymentMethodIconField;
		public string OtherPaymentMethodIcon
		{
			get
			{
				return this.otherPaymentMethodIconField;
			}
			set
			{
				this.otherPaymentMethodIconField = value;
			}
		}
		

		/**
          *
		  */
		private bool? otherPaymentMethodHideLabelField;
		public bool? OtherPaymentMethodHideLabel
		{
			get
			{
				return this.otherPaymentMethodHideLabelField;
			}
			set
			{
				this.otherPaymentMethodHideLabelField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public OtherPaymentMethodDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(OtherPaymentMethodId != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OtherPaymentMethodId>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OtherPaymentMethodId));
				sb.Append("</").Append(PreferredPrefix).Append(":OtherPaymentMethodId>");
			}
			if(OtherPaymentMethodType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OtherPaymentMethodType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OtherPaymentMethodType));
				sb.Append("</").Append(PreferredPrefix).Append(":OtherPaymentMethodType>");
			}
			if(OtherPaymentMethodLabel != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OtherPaymentMethodLabel>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OtherPaymentMethodLabel));
				sb.Append("</").Append(PreferredPrefix).Append(":OtherPaymentMethodLabel>");
			}
			if(OtherPaymentMethodLabelDescription != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OtherPaymentMethodLabelDescription>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OtherPaymentMethodLabelDescription));
				sb.Append("</").Append(PreferredPrefix).Append(":OtherPaymentMethodLabelDescription>");
			}
			if(OtherPaymentMethodLongDescriptionTitle != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OtherPaymentMethodLongDescriptionTitle>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OtherPaymentMethodLongDescriptionTitle));
				sb.Append("</").Append(PreferredPrefix).Append(":OtherPaymentMethodLongDescriptionTitle>");
			}
			if(OtherPaymentMethodLongDescription != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OtherPaymentMethodLongDescription>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OtherPaymentMethodLongDescription));
				sb.Append("</").Append(PreferredPrefix).Append(":OtherPaymentMethodLongDescription>");
			}
			if(OtherPaymentMethodIcon != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OtherPaymentMethodIcon>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OtherPaymentMethodIcon));
				sb.Append("</").Append(PreferredPrefix).Append(":OtherPaymentMethodIcon>");
			}
			if(OtherPaymentMethodHideLabel != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OtherPaymentMethodHideLabel>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OtherPaymentMethodHideLabel.ToString().ToLower()));
				sb.Append("</").Append(PreferredPrefix).Append(":OtherPaymentMethodHideLabel>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Details about the buyer's account passed in by the merchant
      *or partner. Optional. 
      */
	public partial class BuyerDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string buyerIdField;
		public string BuyerId
		{
			get
			{
				return this.buyerIdField;
			}
			set
			{
				this.buyerIdField = value;
			}
		}
		

		/**
          *
		  */
		private string buyerUserNameField;
		public string BuyerUserName
		{
			get
			{
				return this.buyerUserNameField;
			}
			set
			{
				this.buyerUserNameField = value;
			}
		}
		

		/**
          *
		  */
		private string buyerRegistrationDateField;
		public string BuyerRegistrationDate
		{
			get
			{
				return this.buyerRegistrationDateField;
			}
			set
			{
				this.buyerRegistrationDateField = value;
			}
		}
		

		/**
          *
		  */
		private TaxIdDetailsType taxIdDetailsField;
		public TaxIdDetailsType TaxIdDetails
		{
			get
			{
				return this.taxIdDetailsField;
			}
			set
			{
				this.taxIdDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private IdentificationInfoType identificationInfoField;
		public IdentificationInfoType IdentificationInfo
		{
			get
			{
				return this.identificationInfoField;
			}
			set
			{
				this.identificationInfoField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BuyerDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BuyerId != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BuyerId>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BuyerId));
				sb.Append("</").Append(PreferredPrefix).Append(":BuyerId>");
			}
			if(BuyerUserName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BuyerUserName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BuyerUserName));
				sb.Append("</").Append(PreferredPrefix).Append(":BuyerUserName>");
			}
			if(BuyerRegistrationDate != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BuyerRegistrationDate>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BuyerRegistrationDate));
				sb.Append("</").Append(PreferredPrefix).Append(":BuyerRegistrationDate>");
			}
			if(TaxIdDetails != null)
			{
				sb.Append(TaxIdDetails.ToXMLString(PreferredPrefix,"TaxIdDetails"));
			}
			if(IdentificationInfo != null)
			{
				sb.Append(IdentificationInfo.ToXMLString(PreferredPrefix,"IdentificationInfo"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Details about the payer's tax info passed in by the merchant
      *or partner. Optional. 
      */
	public partial class TaxIdDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string taxIdTypeField;
		public string TaxIdType
		{
			get
			{
				return this.taxIdTypeField;
			}
			set
			{
				this.taxIdTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string taxIdField;
		public string TaxId
		{
			get
			{
				return this.taxIdField;
			}
			set
			{
				this.taxIdField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public TaxIdDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(TaxIdType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TaxIdType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TaxIdType));
				sb.Append("</").Append(PreferredPrefix).Append(":TaxIdType>");
			}
			if(TaxId != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TaxId>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TaxId));
				sb.Append("</").Append(PreferredPrefix).Append(":TaxId>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public TaxIdDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TaxIdType']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TaxIdType = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TaxId']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TaxId = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *The Common 3DS fields. Common for both GTD and DCC API's. 
      */
	public partial class ThreeDSecureRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string eci3dsField;
		public string Eci3ds
		{
			get
			{
				return this.eci3dsField;
			}
			set
			{
				this.eci3dsField = value;
			}
		}
		

		/**
          *
		  */
		private string cavvField;
		public string Cavv
		{
			get
			{
				return this.cavvField;
			}
			set
			{
				this.cavvField = value;
			}
		}
		

		/**
          *
		  */
		private string xidField;
		public string Xid
		{
			get
			{
				return this.xidField;
			}
			set
			{
				this.xidField = value;
			}
		}
		

		/**
          *
		  */
		private string mpiVendor3dsField;
		public string MpiVendor3ds
		{
			get
			{
				return this.mpiVendor3dsField;
			}
			set
			{
				this.mpiVendor3dsField = value;
			}
		}
		

		/**
          *
		  */
		private string authStatus3dsField;
		public string AuthStatus3ds
		{
			get
			{
				return this.authStatus3dsField;
			}
			set
			{
				this.authStatus3dsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ThreeDSecureRequestType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Eci3ds != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Eci3ds>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Eci3ds));
				sb.Append("</").Append(PreferredPrefix).Append(":Eci3ds>");
			}
			if(Cavv != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Cavv>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Cavv));
				sb.Append("</").Append(PreferredPrefix).Append(":Cavv>");
			}
			if(Xid != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Xid>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Xid));
				sb.Append("</").Append(PreferredPrefix).Append(":Xid>");
			}
			if(MpiVendor3ds != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MpiVendor3ds>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.MpiVendor3ds));
				sb.Append("</").Append(PreferredPrefix).Append(":MpiVendor3ds>");
			}
			if(AuthStatus3ds != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AuthStatus3ds>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.AuthStatus3ds));
				sb.Append("</").Append(PreferredPrefix).Append(":AuthStatus3ds>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public ThreeDSecureRequestType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Eci3ds']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Eci3ds = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Cavv']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Cavv = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Xid']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Xid = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'MpiVendor3ds']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.MpiVendor3ds = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AuthStatus3ds']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AuthStatus3ds = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *3DS remaining fields. 
      */
	public partial class ThreeDSecureResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string vpasField;
		public string Vpas
		{
			get
			{
				return this.vpasField;
			}
			set
			{
				this.vpasField = value;
			}
		}
		

		/**
          *
		  */
		private string eciSubmitted3DSField;
		public string EciSubmitted3DS
		{
			get
			{
				return this.eciSubmitted3DSField;
			}
			set
			{
				this.eciSubmitted3DSField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ThreeDSecureResponseType()
	 	{
		}


		public ThreeDSecureResponseType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Vpas']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Vpas = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'EciSubmitted3DS']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.EciSubmitted3DS = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *3DSecureInfoType Information about 3D Secure parameters. 
      */
	public partial class ThreeDSecureInfoType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private ThreeDSecureRequestType threeDSecureRequestField;
		public ThreeDSecureRequestType ThreeDSecureRequest
		{
			get
			{
				return this.threeDSecureRequestField;
			}
			set
			{
				this.threeDSecureRequestField = value;
			}
		}
		

		/**
          *
		  */
		private ThreeDSecureResponseType threeDSecureResponseField;
		public ThreeDSecureResponseType ThreeDSecureResponse
		{
			get
			{
				return this.threeDSecureResponseField;
			}
			set
			{
				this.threeDSecureResponseField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ThreeDSecureInfoType()
	 	{
		}


		public ThreeDSecureInfoType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ThreeDSecureRequest']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ThreeDSecureRequest =  new ThreeDSecureRequestType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ThreeDSecureResponse']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ThreeDSecureResponse =  new ThreeDSecureResponseType(ChildNode);
			}
	
		}
	}




	/**
      *CreditCardDetailsType Information about a Credit Card. 
      */
	public partial class CreditCardDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private CreditCardTypeType? creditCardTypeField;
		public CreditCardTypeType? CreditCardType
		{
			get
			{
				return this.creditCardTypeField;
			}
			set
			{
				this.creditCardTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string creditCardNumberField;
		public string CreditCardNumber
		{
			get
			{
				return this.creditCardNumberField;
			}
			set
			{
				this.creditCardNumberField = value;
			}
		}
		

		/**
          *
		  */
		private int? expMonthField;
		public int? ExpMonth
		{
			get
			{
				return this.expMonthField;
			}
			set
			{
				this.expMonthField = value;
			}
		}
		

		/**
          *
		  */
		private int? expYearField;
		public int? ExpYear
		{
			get
			{
				return this.expYearField;
			}
			set
			{
				this.expYearField = value;
			}
		}
		

		/**
          *
		  */
		private PayerInfoType cardOwnerField;
		public PayerInfoType CardOwner
		{
			get
			{
				return this.cardOwnerField;
			}
			set
			{
				this.cardOwnerField = value;
			}
		}
		

		/**
          *
		  */
		private string cVV2Field;
		public string CVV2
		{
			get
			{
				return this.cVV2Field;
			}
			set
			{
				this.cVV2Field = value;
			}
		}
		

		/**
          *
		  */
		private int? startMonthField;
		public int? StartMonth
		{
			get
			{
				return this.startMonthField;
			}
			set
			{
				this.startMonthField = value;
			}
		}
		

		/**
          *
		  */
		private int? startYearField;
		public int? StartYear
		{
			get
			{
				return this.startYearField;
			}
			set
			{
				this.startYearField = value;
			}
		}
		

		/**
          *
		  */
		private string issueNumberField;
		public string IssueNumber
		{
			get
			{
				return this.issueNumberField;
			}
			set
			{
				this.issueNumberField = value;
			}
		}
		

		/**
          *
		  */
		private ThreeDSecureRequestType threeDSecureRequestField;
		public ThreeDSecureRequestType ThreeDSecureRequest
		{
			get
			{
				return this.threeDSecureRequestField;
			}
			set
			{
				this.threeDSecureRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CreditCardDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(CreditCardType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CreditCardType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.CreditCardType)));
				sb.Append("</").Append(PreferredPrefix).Append(":CreditCardType>");
			}
			if(CreditCardNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CreditCardNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CreditCardNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":CreditCardNumber>");
			}
			if(ExpMonth != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ExpMonth>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ExpMonth));
				sb.Append("</").Append(PreferredPrefix).Append(":ExpMonth>");
			}
			if(ExpYear != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ExpYear>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ExpYear));
				sb.Append("</").Append(PreferredPrefix).Append(":ExpYear>");
			}
			if(CardOwner != null)
			{
				sb.Append(CardOwner.ToXMLString(PreferredPrefix,"CardOwner"));
			}
			if(CVV2 != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CVV2>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CVV2));
				sb.Append("</").Append(PreferredPrefix).Append(":CVV2>");
			}
			if(StartMonth != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":StartMonth>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.StartMonth));
				sb.Append("</").Append(PreferredPrefix).Append(":StartMonth>");
			}
			if(StartYear != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":StartYear>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.StartYear));
				sb.Append("</").Append(PreferredPrefix).Append(":StartYear>");
			}
			if(IssueNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":IssueNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.IssueNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":IssueNumber>");
			}
			if(ThreeDSecureRequest != null)
			{
				sb.Append(ThreeDSecureRequest.ToXMLString(PreferredPrefix,"ThreeDSecureRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public CreditCardDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CreditCardType']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CreditCardType = (CreditCardTypeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(CreditCardTypeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CreditCardNumber']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CreditCardNumber = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ExpMonth']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ExpMonth = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ExpYear']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ExpYear = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CardOwner']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CardOwner =  new PayerInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CVV2']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CVV2 = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'StartMonth']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.StartMonth = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'StartYear']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.StartYear = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'IssueNumber']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.IssueNumber = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ThreeDSecureRequest']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ThreeDSecureRequest =  new ThreeDSecureRequestType(ChildNode);
			}
	
		}
	}




	/**
      *Fallback shipping options type. 
      */
	public partial class ShippingOptionType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string shippingOptionIsDefaultField;
		public string ShippingOptionIsDefault
		{
			get
			{
				return this.shippingOptionIsDefaultField;
			}
			set
			{
				this.shippingOptionIsDefaultField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType shippingOptionAmountField;
		public BasicAmountType ShippingOptionAmount
		{
			get
			{
				return this.shippingOptionAmountField;
			}
			set
			{
				this.shippingOptionAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string shippingOptionNameField;
		public string ShippingOptionName
		{
			get
			{
				return this.shippingOptionNameField;
			}
			set
			{
				this.shippingOptionNameField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ShippingOptionType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ShippingOptionIsDefault != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ShippingOptionIsDefault>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ShippingOptionIsDefault));
				sb.Append("</").Append(PreferredPrefix).Append(":ShippingOptionIsDefault>");
			}
			if(ShippingOptionAmount != null)
			{
				sb.Append(ShippingOptionAmount.ToXMLString(PreferredPrefix,"ShippingOptionAmount"));
			}
			if(ShippingOptionName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ShippingOptionName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ShippingOptionName));
				sb.Append("</").Append(PreferredPrefix).Append(":ShippingOptionName>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Information on user selected options 
      */
	public partial class UserSelectedOptionType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string shippingCalculationModeField;
		public string ShippingCalculationMode
		{
			get
			{
				return this.shippingCalculationModeField;
			}
			set
			{
				this.shippingCalculationModeField = value;
			}
		}
		

		/**
          *
		  */
		private string insuranceOptionSelectedField;
		public string InsuranceOptionSelected
		{
			get
			{
				return this.insuranceOptionSelectedField;
			}
			set
			{
				this.insuranceOptionSelectedField = value;
			}
		}
		

		/**
          *
		  */
		private string shippingOptionIsDefaultField;
		public string ShippingOptionIsDefault
		{
			get
			{
				return this.shippingOptionIsDefaultField;
			}
			set
			{
				this.shippingOptionIsDefaultField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType shippingOptionAmountField;
		public BasicAmountType ShippingOptionAmount
		{
			get
			{
				return this.shippingOptionAmountField;
			}
			set
			{
				this.shippingOptionAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string shippingOptionNameField;
		public string ShippingOptionName
		{
			get
			{
				return this.shippingOptionNameField;
			}
			set
			{
				this.shippingOptionNameField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public UserSelectedOptionType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ShippingCalculationMode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ShippingCalculationMode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ShippingCalculationMode));
				sb.Append("</").Append(PreferredPrefix).Append(":ShippingCalculationMode>");
			}
			if(InsuranceOptionSelected != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":InsuranceOptionSelected>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.InsuranceOptionSelected));
				sb.Append("</").Append(PreferredPrefix).Append(":InsuranceOptionSelected>");
			}
			if(ShippingOptionIsDefault != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ShippingOptionIsDefault>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ShippingOptionIsDefault));
				sb.Append("</").Append(PreferredPrefix).Append(":ShippingOptionIsDefault>");
			}
			if(ShippingOptionAmount != null)
			{
				sb.Append(ShippingOptionAmount.ToXMLString(PreferredPrefix,"ShippingOptionAmount"));
			}
			if(ShippingOptionName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ShippingOptionName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ShippingOptionName));
				sb.Append("</").Append(PreferredPrefix).Append(":ShippingOptionName>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public UserSelectedOptionType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ShippingCalculationMode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ShippingCalculationMode = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'InsuranceOptionSelected']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.InsuranceOptionSelected = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ShippingOptionIsDefault']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ShippingOptionIsDefault = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ShippingOptionAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ShippingOptionAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ShippingOptionName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ShippingOptionName = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class CreditCardNumberTypeType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private CreditCardTypeType? creditCardTypeField;
		public CreditCardTypeType? CreditCardType
		{
			get
			{
				return this.creditCardTypeField;
			}
			set
			{
				this.creditCardTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string creditCardNumberField;
		public string CreditCardNumber
		{
			get
			{
				return this.creditCardNumberField;
			}
			set
			{
				this.creditCardNumberField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CreditCardNumberTypeType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(CreditCardType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CreditCardType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.CreditCardType)));
				sb.Append("</").Append(PreferredPrefix).Append(":CreditCardType>");
			}
			if(CreditCardNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CreditCardNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CreditCardNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":CreditCardNumber>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *CreditCardDetailsType for DCC Reference Transaction
      *Information about a Credit Card. 
      */
	public partial class ReferenceCreditCardDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private CreditCardNumberTypeType creditCardNumberTypeField;
		public CreditCardNumberTypeType CreditCardNumberType
		{
			get
			{
				return this.creditCardNumberTypeField;
			}
			set
			{
				this.creditCardNumberTypeField = value;
			}
		}
		

		/**
          *
		  */
		private int? expMonthField;
		public int? ExpMonth
		{
			get
			{
				return this.expMonthField;
			}
			set
			{
				this.expMonthField = value;
			}
		}
		

		/**
          *
		  */
		private int? expYearField;
		public int? ExpYear
		{
			get
			{
				return this.expYearField;
			}
			set
			{
				this.expYearField = value;
			}
		}
		

		/**
          *
		  */
		private PersonNameType cardOwnerNameField;
		public PersonNameType CardOwnerName
		{
			get
			{
				return this.cardOwnerNameField;
			}
			set
			{
				this.cardOwnerNameField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType billingAddressField;
		public AddressType BillingAddress
		{
			get
			{
				return this.billingAddressField;
			}
			set
			{
				this.billingAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string cVV2Field;
		public string CVV2
		{
			get
			{
				return this.cVV2Field;
			}
			set
			{
				this.cVV2Field = value;
			}
		}
		

		/**
          *
		  */
		private int? startMonthField;
		public int? StartMonth
		{
			get
			{
				return this.startMonthField;
			}
			set
			{
				this.startMonthField = value;
			}
		}
		

		/**
          *
		  */
		private int? startYearField;
		public int? StartYear
		{
			get
			{
				return this.startYearField;
			}
			set
			{
				this.startYearField = value;
			}
		}
		

		/**
          *
		  */
		private string issueNumberField;
		public string IssueNumber
		{
			get
			{
				return this.issueNumberField;
			}
			set
			{
				this.issueNumberField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ReferenceCreditCardDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(CreditCardNumberType != null)
			{
				sb.Append(CreditCardNumberType.ToXMLString(PreferredPrefix,"CreditCardNumberType"));
			}
			if(ExpMonth != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ExpMonth>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ExpMonth));
				sb.Append("</").Append(PreferredPrefix).Append(":ExpMonth>");
			}
			if(ExpYear != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ExpYear>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ExpYear));
				sb.Append("</").Append(PreferredPrefix).Append(":ExpYear>");
			}
			if(CardOwnerName != null)
			{
				sb.Append(CardOwnerName.ToXMLString(PreferredPrefix,"CardOwnerName"));
			}
			if(BillingAddress != null)
			{
				sb.Append(BillingAddress.ToXMLString(PreferredPrefix,"BillingAddress"));
			}
			if(CVV2 != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CVV2>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CVV2));
				sb.Append("</").Append(PreferredPrefix).Append(":CVV2>");
			}
			if(StartMonth != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":StartMonth>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.StartMonth));
				sb.Append("</").Append(PreferredPrefix).Append(":StartMonth>");
			}
			if(StartYear != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":StartYear>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.StartYear));
				sb.Append("</").Append(PreferredPrefix).Append(":StartYear>");
			}
			if(IssueNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":IssueNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.IssueNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":IssueNumber>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class SetCustomerBillingAgreementRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BillingAgreementDetailsType billingAgreementDetailsField;
		public BillingAgreementDetailsType BillingAgreementDetails
		{
			get
			{
				return this.billingAgreementDetailsField;
			}
			set
			{
				this.billingAgreementDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string returnURLField;
		public string ReturnURL
		{
			get
			{
				return this.returnURLField;
			}
			set
			{
				this.returnURLField = value;
			}
		}
		

		/**
          *
		  */
		private string cancelURLField;
		public string CancelURL
		{
			get
			{
				return this.cancelURLField;
			}
			set
			{
				this.cancelURLField = value;
			}
		}
		

		/**
          *
		  */
		private string localeCodeField;
		public string LocaleCode
		{
			get
			{
				return this.localeCodeField;
			}
			set
			{
				this.localeCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string pageStyleField;
		public string PageStyle
		{
			get
			{
				return this.pageStyleField;
			}
			set
			{
				this.pageStyleField = value;
			}
		}
		

		/**
          *
		  */
		private string cppHeaderImageField;
		public string cppHeaderImage
		{
			get
			{
				return this.cppHeaderImageField;
			}
			set
			{
				this.cppHeaderImageField = value;
			}
		}
		

		/**
          *
		  */
		private string cppHeaderBorderColorField;
		public string cppHeaderBorderColor
		{
			get
			{
				return this.cppHeaderBorderColorField;
			}
			set
			{
				this.cppHeaderBorderColorField = value;
			}
		}
		

		/**
          *
		  */
		private string cppHeaderBackColorField;
		public string cppHeaderBackColor
		{
			get
			{
				return this.cppHeaderBackColorField;
			}
			set
			{
				this.cppHeaderBackColorField = value;
			}
		}
		

		/**
          *
		  */
		private string cppPayflowColorField;
		public string cppPayflowColor
		{
			get
			{
				return this.cppPayflowColorField;
			}
			set
			{
				this.cppPayflowColorField = value;
			}
		}
		

		/**
          *
		  */
		private string buyerEmailField;
		public string BuyerEmail
		{
			get
			{
				return this.buyerEmailField;
			}
			set
			{
				this.buyerEmailField = value;
			}
		}
		

		/**
          *
		  */
		private string reqBillingAddressField;
		public string ReqBillingAddress
		{
			get
			{
				return this.reqBillingAddressField;
			}
			set
			{
				this.reqBillingAddressField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public SetCustomerBillingAgreementRequestDetailsType(BillingAgreementDetailsType billingAgreementDetails, string returnURL, string cancelURL)
	 	{
			this.BillingAgreementDetails = billingAgreementDetails;
			this.ReturnURL = returnURL;
			this.CancelURL = cancelURL;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public SetCustomerBillingAgreementRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BillingAgreementDetails != null)
			{
				sb.Append(BillingAgreementDetails.ToXMLString(PreferredPrefix,"BillingAgreementDetails"));
			}
			if(ReturnURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReturnURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReturnURL));
				sb.Append("</").Append(PreferredPrefix).Append(":ReturnURL>");
			}
			if(CancelURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CancelURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CancelURL));
				sb.Append("</").Append(PreferredPrefix).Append(":CancelURL>");
			}
			if(LocaleCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":LocaleCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.LocaleCode));
				sb.Append("</").Append(PreferredPrefix).Append(":LocaleCode>");
			}
			if(PageStyle != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PageStyle>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PageStyle));
				sb.Append("</").Append(PreferredPrefix).Append(":PageStyle>");
			}
			if(cppHeaderImage != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-header-image>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppHeaderImage));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-header-image>");
			}
			if(cppHeaderBorderColor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-header-border-color>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppHeaderBorderColor));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-header-border-color>");
			}
			if(cppHeaderBackColor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-header-back-color>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppHeaderBackColor));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-header-back-color>");
			}
			if(cppPayflowColor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":cpp-payflow-color>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.cppPayflowColor));
				sb.Append("</").Append(PreferredPrefix).Append(":cpp-payflow-color>");
			}
			if(BuyerEmail != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BuyerEmail>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BuyerEmail));
				sb.Append("</").Append(PreferredPrefix).Append(":BuyerEmail>");
			}
			if(ReqBillingAddress != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReqBillingAddress>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReqBillingAddress));
				sb.Append("</").Append(PreferredPrefix).Append(":ReqBillingAddress>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetBillingAgreementCustomerDetailsResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private PayerInfoType payerInfoField;
		public PayerInfoType PayerInfo
		{
			get
			{
				return this.payerInfoField;
			}
			set
			{
				this.payerInfoField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType billingAddressField;
		public AddressType BillingAddress
		{
			get
			{
				return this.billingAddressField;
			}
			set
			{
				this.billingAddressField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetBillingAgreementCustomerDetailsResponseDetailsType()
	 	{
		}


		public GetBillingAgreementCustomerDetailsResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PayerInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PayerInfo =  new PayerInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillingAddress']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillingAddress =  new AddressType(ChildNode);
			}
	
		}
	}




	/**
      *Device ID Optional  Character length and limits: 256
      *single-byte characters DeviceID length morethan 256 is
      *truncated  
      */
	public partial class DeviceDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string deviceIDField;
		public string DeviceID
		{
			get
			{
				return this.deviceIDField;
			}
			set
			{
				this.deviceIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DeviceDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(DeviceID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":DeviceID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.DeviceID));
				sb.Append("</").Append(PreferredPrefix).Append(":DeviceID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class SenderDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DeviceDetailsType deviceDetailsField;
		public DeviceDetailsType DeviceDetails
		{
			get
			{
				return this.deviceDetailsField;
			}
			set
			{
				this.deviceDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SenderDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(DeviceDetails != null)
			{
				sb.Append(DeviceDetails.ToXMLString(PreferredPrefix,"DeviceDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class DoReferenceTransactionRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string referenceIDField;
		public string ReferenceID
		{
			get
			{
				return this.referenceIDField;
			}
			set
			{
				this.referenceIDField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentActionCodeType? paymentActionField;
		public PaymentActionCodeType? PaymentAction
		{
			get
			{
				return this.paymentActionField;
			}
			set
			{
				this.paymentActionField = value;
			}
		}
		

		/**
          *
		  */
		private MerchantPullPaymentCodeType? paymentTypeField;
		public MerchantPullPaymentCodeType? PaymentType
		{
			get
			{
				return this.paymentTypeField;
			}
			set
			{
				this.paymentTypeField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentDetailsType paymentDetailsField;
		public PaymentDetailsType PaymentDetails
		{
			get
			{
				return this.paymentDetailsField;
			}
			set
			{
				this.paymentDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private ReferenceCreditCardDetailsType creditCardField;
		public ReferenceCreditCardDetailsType CreditCard
		{
			get
			{
				return this.creditCardField;
			}
			set
			{
				this.creditCardField = value;
			}
		}
		

		/**
          *
		  */
		private string iPAddressField;
		public string IPAddress
		{
			get
			{
				return this.iPAddressField;
			}
			set
			{
				this.iPAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string merchantSessionIdField;
		public string MerchantSessionId
		{
			get
			{
				return this.merchantSessionIdField;
			}
			set
			{
				this.merchantSessionIdField = value;
			}
		}
		

		/**
          *
		  */
		private string reqConfirmShippingField;
		public string ReqConfirmShipping
		{
			get
			{
				return this.reqConfirmShippingField;
			}
			set
			{
				this.reqConfirmShippingField = value;
			}
		}
		

		/**
          *
		  */
		private string softDescriptorField;
		public string SoftDescriptor
		{
			get
			{
				return this.softDescriptorField;
			}
			set
			{
				this.softDescriptorField = value;
			}
		}
		

		/**
          *
		  */
		private SenderDetailsType senderDetailsField;
		public SenderDetailsType SenderDetails
		{
			get
			{
				return this.senderDetailsField;
			}
			set
			{
				this.senderDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string msgSubIDField;
		public string MsgSubID
		{
			get
			{
				return this.msgSubIDField;
			}
			set
			{
				this.msgSubIDField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public DoReferenceTransactionRequestDetailsType(string referenceID, PaymentActionCodeType? paymentAction, PaymentDetailsType paymentDetails)
	 	{
			this.ReferenceID = referenceID;
			this.PaymentAction = paymentAction;
			this.PaymentDetails = paymentDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public DoReferenceTransactionRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ReferenceID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReferenceID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReferenceID));
				sb.Append("</").Append(PreferredPrefix).Append(":ReferenceID>");
			}
			if(PaymentAction != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PaymentAction>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.PaymentAction)));
				sb.Append("</").Append(PreferredPrefix).Append(":PaymentAction>");
			}
			if(PaymentType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PaymentType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.PaymentType)));
				sb.Append("</").Append(PreferredPrefix).Append(":PaymentType>");
			}
			if(PaymentDetails != null)
			{
				sb.Append(PaymentDetails.ToXMLString(PreferredPrefix,"PaymentDetails"));
			}
			if(CreditCard != null)
			{
				sb.Append(CreditCard.ToXMLString(PreferredPrefix,"CreditCard"));
			}
			if(IPAddress != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":IPAddress>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.IPAddress));
				sb.Append("</").Append(PreferredPrefix).Append(":IPAddress>");
			}
			if(MerchantSessionId != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MerchantSessionId>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.MerchantSessionId));
				sb.Append("</").Append(PreferredPrefix).Append(":MerchantSessionId>");
			}
			if(ReqConfirmShipping != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReqConfirmShipping>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReqConfirmShipping));
				sb.Append("</").Append(PreferredPrefix).Append(":ReqConfirmShipping>");
			}
			if(SoftDescriptor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SoftDescriptor>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SoftDescriptor));
				sb.Append("</").Append(PreferredPrefix).Append(":SoftDescriptor>");
			}
			if(SenderDetails != null)
			{
				sb.Append(SenderDetails.ToXMLString(PreferredPrefix,"SenderDetails"));
			}
			if(MsgSubID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MsgSubID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.MsgSubID));
				sb.Append("</").Append(PreferredPrefix).Append(":MsgSubID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class DoReferenceTransactionResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string billingAgreementIDField;
		public string BillingAgreementID
		{
			get
			{
				return this.billingAgreementIDField;
			}
			set
			{
				this.billingAgreementIDField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentInfoType paymentInfoField;
		public PaymentInfoType PaymentInfo
		{
			get
			{
				return this.paymentInfoField;
			}
			set
			{
				this.paymentInfoField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private string aVSCodeField;
		public string AVSCode
		{
			get
			{
				return this.aVSCodeField;
			}
			set
			{
				this.aVSCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string cVV2CodeField;
		public string CVV2Code
		{
			get
			{
				return this.cVV2CodeField;
			}
			set
			{
				this.cVV2CodeField = value;
			}
		}
		

		/**
          *
		  */
		private string transactionIDField;
		public string TransactionID
		{
			get
			{
				return this.transactionIDField;
			}
			set
			{
				this.transactionIDField = value;
			}
		}
		

		/**
          *
		  */
		private string paymentAdviceCodeField;
		public string PaymentAdviceCode
		{
			get
			{
				return this.paymentAdviceCodeField;
			}
			set
			{
				this.paymentAdviceCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string msgSubIDField;
		public string MsgSubID
		{
			get
			{
				return this.msgSubIDField;
			}
			set
			{
				this.msgSubIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoReferenceTransactionResponseDetailsType()
	 	{
		}


		public DoReferenceTransactionResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillingAgreementID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillingAgreementID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentInfo =  new PaymentInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Amount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Amount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AVSCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AVSCode = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CVV2Code']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CVV2Code = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TransactionID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TransactionID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentAdviceCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentAdviceCode = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'MsgSubID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.MsgSubID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class DoNonReferencedCreditRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType netAmountField;
		public BasicAmountType NetAmount
		{
			get
			{
				return this.netAmountField;
			}
			set
			{
				this.netAmountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType taxAmountField;
		public BasicAmountType TaxAmount
		{
			get
			{
				return this.taxAmountField;
			}
			set
			{
				this.taxAmountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType shippingAmountField;
		public BasicAmountType ShippingAmount
		{
			get
			{
				return this.shippingAmountField;
			}
			set
			{
				this.shippingAmountField = value;
			}
		}
		

		/**
          *
		  */
		private CreditCardDetailsType creditCardField;
		public CreditCardDetailsType CreditCard
		{
			get
			{
				return this.creditCardField;
			}
			set
			{
				this.creditCardField = value;
			}
		}
		

		/**
          *
		  */
		private string receiverEmailField;
		public string ReceiverEmail
		{
			get
			{
				return this.receiverEmailField;
			}
			set
			{
				this.receiverEmailField = value;
			}
		}
		

		/**
          *
		  */
		private string commentField;
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoNonReferencedCreditRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Amount != null)
			{
				sb.Append(Amount.ToXMLString(PreferredPrefix,"Amount"));
			}
			if(NetAmount != null)
			{
				sb.Append(NetAmount.ToXMLString(PreferredPrefix,"NetAmount"));
			}
			if(TaxAmount != null)
			{
				sb.Append(TaxAmount.ToXMLString(PreferredPrefix,"TaxAmount"));
			}
			if(ShippingAmount != null)
			{
				sb.Append(ShippingAmount.ToXMLString(PreferredPrefix,"ShippingAmount"));
			}
			if(CreditCard != null)
			{
				sb.Append(CreditCard.ToXMLString(PreferredPrefix,"CreditCard"));
			}
			if(ReceiverEmail != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReceiverEmail>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReceiverEmail));
				sb.Append("</").Append(PreferredPrefix).Append(":ReceiverEmail>");
			}
			if(Comment != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Comment>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Comment));
				sb.Append("</").Append(PreferredPrefix).Append(":Comment>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class DoNonReferencedCreditResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private string transactionIDField;
		public string TransactionID
		{
			get
			{
				return this.transactionIDField;
			}
			set
			{
				this.transactionIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoNonReferencedCreditResponseDetailsType()
	 	{
		}


		public DoNonReferencedCreditResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Amount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Amount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TransactionID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TransactionID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Onboarding program code given to you by PayPal. Required
      *Character length and limitations: 64 alphanumeric characters
      *
      */
	public partial class EnterBoardingRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string programCodeField;
		public string ProgramCode
		{
			get
			{
				return this.programCodeField;
			}
			set
			{
				this.programCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string productListField;
		public string ProductList
		{
			get
			{
				return this.productListField;
			}
			set
			{
				this.productListField = value;
			}
		}
		

		/**
          *
		  */
		private string partnerCustomField;
		public string PartnerCustom
		{
			get
			{
				return this.partnerCustomField;
			}
			set
			{
				this.partnerCustomField = value;
			}
		}
		

		/**
          *
		  */
		private string imageUrlField;
		public string ImageUrl
		{
			get
			{
				return this.imageUrlField;
			}
			set
			{
				this.imageUrlField = value;
			}
		}
		

		/**
          *
		  */
		private MarketingCategoryType? marketingCategoryField;
		public MarketingCategoryType? MarketingCategory
		{
			get
			{
				return this.marketingCategoryField;
			}
			set
			{
				this.marketingCategoryField = value;
			}
		}
		

		/**
          *
		  */
		private BusinessInfoType businessInfoField;
		public BusinessInfoType BusinessInfo
		{
			get
			{
				return this.businessInfoField;
			}
			set
			{
				this.businessInfoField = value;
			}
		}
		

		/**
          *
		  */
		private BusinessOwnerInfoType ownerInfoField;
		public BusinessOwnerInfoType OwnerInfo
		{
			get
			{
				return this.ownerInfoField;
			}
			set
			{
				this.ownerInfoField = value;
			}
		}
		

		/**
          *
		  */
		private BankAccountDetailsType bankAccountField;
		public BankAccountDetailsType BankAccount
		{
			get
			{
				return this.bankAccountField;
			}
			set
			{
				this.bankAccountField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public EnterBoardingRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ProgramCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ProgramCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ProgramCode));
				sb.Append("</").Append(PreferredPrefix).Append(":ProgramCode>");
			}
			if(ProductList != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ProductList>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ProductList));
				sb.Append("</").Append(PreferredPrefix).Append(":ProductList>");
			}
			if(PartnerCustom != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PartnerCustom>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PartnerCustom));
				sb.Append("</").Append(PreferredPrefix).Append(":PartnerCustom>");
			}
			if(ImageUrl != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ImageUrl>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ImageUrl));
				sb.Append("</").Append(PreferredPrefix).Append(":ImageUrl>");
			}
			if(MarketingCategory != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MarketingCategory>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.MarketingCategory)));
				sb.Append("</").Append(PreferredPrefix).Append(":MarketingCategory>");
			}
			if(BusinessInfo != null)
			{
				sb.Append(BusinessInfo.ToXMLString(PreferredPrefix,"BusinessInfo"));
			}
			if(OwnerInfo != null)
			{
				sb.Append(OwnerInfo.ToXMLString(PreferredPrefix,"OwnerInfo"));
			}
			if(BankAccount != null)
			{
				sb.Append(BankAccount.ToXMLString(PreferredPrefix,"BankAccount"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *BusinessInfoType 
      */
	public partial class BusinessInfoType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BusinessTypeType? typeField;
		public BusinessTypeType? Type
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
		

		/**
          *
		  */
		private string nameField;
		public string Name
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
		

		/**
          *
		  */
		private AddressType addressField;
		public AddressType Address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}
		

		/**
          *
		  */
		private string workPhoneField;
		public string WorkPhone
		{
			get
			{
				return this.workPhoneField;
			}
			set
			{
				this.workPhoneField = value;
			}
		}
		

		/**
          *
		  */
		private BusinessCategoryType? categoryField;
		public BusinessCategoryType? Category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
			}
		}
		

		/**
          *
		  */
		private BusinessSubCategoryType? subCategoryField;
		public BusinessSubCategoryType? SubCategory
		{
			get
			{
				return this.subCategoryField;
			}
			set
			{
				this.subCategoryField = value;
			}
		}
		

		/**
          *
		  */
		private AverageTransactionPriceType? averagePriceField;
		public AverageTransactionPriceType? AveragePrice
		{
			get
			{
				return this.averagePriceField;
			}
			set
			{
				this.averagePriceField = value;
			}
		}
		

		/**
          *
		  */
		private AverageMonthlyVolumeType? averageMonthlyVolumeField;
		public AverageMonthlyVolumeType? AverageMonthlyVolume
		{
			get
			{
				return this.averageMonthlyVolumeField;
			}
			set
			{
				this.averageMonthlyVolumeField = value;
			}
		}
		

		/**
          *
		  */
		private SalesVenueType? salesVenueField;
		public SalesVenueType? SalesVenue
		{
			get
			{
				return this.salesVenueField;
			}
			set
			{
				this.salesVenueField = value;
			}
		}
		

		/**
          *
		  */
		private string websiteField;
		public string Website
		{
			get
			{
				return this.websiteField;
			}
			set
			{
				this.websiteField = value;
			}
		}
		

		/**
          *
		  */
		private PercentageRevenueFromOnlineSalesType? revenueFromOnlineSalesField;
		public PercentageRevenueFromOnlineSalesType? RevenueFromOnlineSales
		{
			get
			{
				return this.revenueFromOnlineSalesField;
			}
			set
			{
				this.revenueFromOnlineSalesField = value;
			}
		}
		

		/**
          *
		  */
		private string businessEstablishedField;
		public string BusinessEstablished
		{
			get
			{
				return this.businessEstablishedField;
			}
			set
			{
				this.businessEstablishedField = value;
			}
		}
		

		/**
          *
		  */
		private string customerServiceEmailField;
		public string CustomerServiceEmail
		{
			get
			{
				return this.customerServiceEmailField;
			}
			set
			{
				this.customerServiceEmailField = value;
			}
		}
		

		/**
          *
		  */
		private string customerServicePhoneField;
		public string CustomerServicePhone
		{
			get
			{
				return this.customerServicePhoneField;
			}
			set
			{
				this.customerServicePhoneField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BusinessInfoType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Type != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Type>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.Type)));
				sb.Append("</").Append(PreferredPrefix).Append(":Type>");
			}
			if(Name != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Name>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Name));
				sb.Append("</").Append(PreferredPrefix).Append(":Name>");
			}
			if(Address != null)
			{
				sb.Append(Address.ToXMLString(PreferredPrefix,"Address"));
			}
			if(WorkPhone != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":WorkPhone>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.WorkPhone));
				sb.Append("</").Append(PreferredPrefix).Append(":WorkPhone>");
			}
			if(Category != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Category>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.Category)));
				sb.Append("</").Append(PreferredPrefix).Append(":Category>");
			}
			if(SubCategory != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SubCategory>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.SubCategory)));
				sb.Append("</").Append(PreferredPrefix).Append(":SubCategory>");
			}
			if(AveragePrice != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AveragePrice>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.AveragePrice)));
				sb.Append("</").Append(PreferredPrefix).Append(":AveragePrice>");
			}
			if(AverageMonthlyVolume != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AverageMonthlyVolume>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.AverageMonthlyVolume)));
				sb.Append("</").Append(PreferredPrefix).Append(":AverageMonthlyVolume>");
			}
			if(SalesVenue != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SalesVenue>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.SalesVenue)));
				sb.Append("</").Append(PreferredPrefix).Append(":SalesVenue>");
			}
			if(Website != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Website>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Website));
				sb.Append("</").Append(PreferredPrefix).Append(":Website>");
			}
			if(RevenueFromOnlineSales != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":RevenueFromOnlineSales>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.RevenueFromOnlineSales)));
				sb.Append("</").Append(PreferredPrefix).Append(":RevenueFromOnlineSales>");
			}
			if(BusinessEstablished != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BusinessEstablished>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BusinessEstablished));
				sb.Append("</").Append(PreferredPrefix).Append(":BusinessEstablished>");
			}
			if(CustomerServiceEmail != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CustomerServiceEmail>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CustomerServiceEmail));
				sb.Append("</").Append(PreferredPrefix).Append(":CustomerServiceEmail>");
			}
			if(CustomerServicePhone != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CustomerServicePhone>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CustomerServicePhone));
				sb.Append("</").Append(PreferredPrefix).Append(":CustomerServicePhone>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *BusinessOwnerInfoType 
      */
	public partial class BusinessOwnerInfoType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private PayerInfoType ownerField;
		public PayerInfoType Owner
		{
			get
			{
				return this.ownerField;
			}
			set
			{
				this.ownerField = value;
			}
		}
		

		/**
          *
		  */
		private string homePhoneField;
		public string HomePhone
		{
			get
			{
				return this.homePhoneField;
			}
			set
			{
				this.homePhoneField = value;
			}
		}
		

		/**
          *
		  */
		private string mobilePhoneField;
		public string MobilePhone
		{
			get
			{
				return this.mobilePhoneField;
			}
			set
			{
				this.mobilePhoneField = value;
			}
		}
		

		/**
          *
		  */
		private string sSNField;
		public string SSN
		{
			get
			{
				return this.sSNField;
			}
			set
			{
				this.sSNField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BusinessOwnerInfoType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Owner != null)
			{
				sb.Append(Owner.ToXMLString(PreferredPrefix,"Owner"));
			}
			if(HomePhone != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":HomePhone>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.HomePhone));
				sb.Append("</").Append(PreferredPrefix).Append(":HomePhone>");
			}
			if(MobilePhone != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MobilePhone>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.MobilePhone));
				sb.Append("</").Append(PreferredPrefix).Append(":MobilePhone>");
			}
			if(SSN != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SSN>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SSN));
				sb.Append("</").Append(PreferredPrefix).Append(":SSN>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *BankAccountDetailsType 
      */
	public partial class BankAccountDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string nameField;
		public string Name
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
		

		/**
          *
		  */
		private BankAccountTypeType? typeField;
		public BankAccountTypeType? Type
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
		

		/**
          *
		  */
		private string routingNumberField;
		public string RoutingNumber
		{
			get
			{
				return this.routingNumberField;
			}
			set
			{
				this.routingNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string accountNumberField;
		public string AccountNumber
		{
			get
			{
				return this.accountNumberField;
			}
			set
			{
				this.accountNumberField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BankAccountDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Name != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Name>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Name));
				sb.Append("</").Append(PreferredPrefix).Append(":Name>");
			}
			if(Type != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Type>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.Type)));
				sb.Append("</").Append(PreferredPrefix).Append(":Type>");
			}
			if(RoutingNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":RoutingNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.RoutingNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":RoutingNumber>");
			}
			if(AccountNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AccountNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.AccountNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":AccountNumber>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Status of merchant's onboarding process:
      *CompletedCancelledPending Character length and limitations:
      *Eight alphabetic characters 
      */
	public partial class GetBoardingDetailsResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BoardingStatusType? statusField;
		public BoardingStatusType? Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		

		/**
          *
		  */
		private string startDateField;
		public string StartDate
		{
			get
			{
				return this.startDateField;
			}
			set
			{
				this.startDateField = value;
			}
		}
		

		/**
          *
		  */
		private string lastUpdatedField;
		public string LastUpdated
		{
			get
			{
				return this.lastUpdatedField;
			}
			set
			{
				this.lastUpdatedField = value;
			}
		}
		

		/**
          *
		  */
		private string reasonField;
		public string Reason
		{
			get
			{
				return this.reasonField;
			}
			set
			{
				this.reasonField = value;
			}
		}
		

		/**
          *
		  */
		private string programNameField;
		public string ProgramName
		{
			get
			{
				return this.programNameField;
			}
			set
			{
				this.programNameField = value;
			}
		}
		

		/**
          *
		  */
		private string programCodeField;
		public string ProgramCode
		{
			get
			{
				return this.programCodeField;
			}
			set
			{
				this.programCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string campaignIDField;
		public string CampaignID
		{
			get
			{
				return this.campaignIDField;
			}
			set
			{
				this.campaignIDField = value;
			}
		}
		

		/**
          *
		  */
		private UserWithdrawalLimitTypeType? userWithdrawalLimitField;
		public UserWithdrawalLimitTypeType? UserWithdrawalLimit
		{
			get
			{
				return this.userWithdrawalLimitField;
			}
			set
			{
				this.userWithdrawalLimitField = value;
			}
		}
		

		/**
          *
		  */
		private string partnerCustomField;
		public string PartnerCustom
		{
			get
			{
				return this.partnerCustomField;
			}
			set
			{
				this.partnerCustomField = value;
			}
		}
		

		/**
          *
		  */
		private PayerInfoType accountOwnerField;
		public PayerInfoType AccountOwner
		{
			get
			{
				return this.accountOwnerField;
			}
			set
			{
				this.accountOwnerField = value;
			}
		}
		

		/**
          *
		  */
		private APICredentialsType credentialsField;
		public APICredentialsType Credentials
		{
			get
			{
				return this.credentialsField;
			}
			set
			{
				this.credentialsField = value;
			}
		}
		

		/**
          *
		  */
		private string configureAPIsField;
		public string ConfigureAPIs
		{
			get
			{
				return this.configureAPIsField;
			}
			set
			{
				this.configureAPIsField = value;
			}
		}
		

		/**
          *
		  */
		private string emailVerificationStatusField;
		public string EmailVerificationStatus
		{
			get
			{
				return this.emailVerificationStatusField;
			}
			set
			{
				this.emailVerificationStatusField = value;
			}
		}
		

		/**
          *
		  */
		private string vettingStatusField;
		public string VettingStatus
		{
			get
			{
				return this.vettingStatusField;
			}
			set
			{
				this.vettingStatusField = value;
			}
		}
		

		/**
          *
		  */
		private string bankAccountVerificationStatusField;
		public string BankAccountVerificationStatus
		{
			get
			{
				return this.bankAccountVerificationStatusField;
			}
			set
			{
				this.bankAccountVerificationStatusField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetBoardingDetailsResponseDetailsType()
	 	{
		}


		public GetBoardingDetailsResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Status']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Status = (BoardingStatusType)EnumUtils.GetValue(ChildNode.InnerText,typeof(BoardingStatusType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'StartDate']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.StartDate = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'LastUpdated']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.LastUpdated = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Reason']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Reason = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ProgramName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ProgramName = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ProgramCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ProgramCode = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CampaignID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CampaignID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'UserWithdrawalLimit']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.UserWithdrawalLimit = (UserWithdrawalLimitTypeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(UserWithdrawalLimitTypeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PartnerCustom']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PartnerCustom = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AccountOwner']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AccountOwner =  new PayerInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Credentials']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Credentials =  new APICredentialsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ConfigureAPIs']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ConfigureAPIs = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'EmailVerificationStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.EmailVerificationStatus = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'VettingStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.VettingStatus = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BankAccountVerificationStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BankAccountVerificationStatus = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *APICredentialsType 
      */
	public partial class APICredentialsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string usernameField;
		public string Username
		{
			get
			{
				return this.usernameField;
			}
			set
			{
				this.usernameField = value;
			}
		}
		

		/**
          *
		  */
		private string passwordField;
		public string Password
		{
			get
			{
				return this.passwordField;
			}
			set
			{
				this.passwordField = value;
			}
		}
		

		/**
          *
		  */
		private string signatureField;
		public string Signature
		{
			get
			{
				return this.signatureField;
			}
			set
			{
				this.signatureField = value;
			}
		}
		

		/**
          *
		  */
		private string certificateField;
		public string Certificate
		{
			get
			{
				return this.certificateField;
			}
			set
			{
				this.certificateField = value;
			}
		}
		

		/**
          *
		  */
		private APIAuthenticationType? typeField;
		public APIAuthenticationType? Type
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
		

		/**
	 	  * Default Constructor
	 	  */
	 	public APICredentialsType()
	 	{
		}


		public APICredentialsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Username']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Username = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Password']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Password = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Signature']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Signature = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Certificate']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Certificate = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Type']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Type = (APIAuthenticationType)EnumUtils.GetValue(ChildNode.InnerText,typeof(APIAuthenticationType));
			}
	
		}
	}




	/**
      *The phone number of the buyer's mobile device, if available.
      *Optional 
      */
	public partial class SetMobileCheckoutRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private PhoneNumberType buyerPhoneField;
		public PhoneNumberType BuyerPhone
		{
			get
			{
				return this.buyerPhoneField;
			}
			set
			{
				this.buyerPhoneField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType itemAmountField;
		public BasicAmountType ItemAmount
		{
			get
			{
				return this.itemAmountField;
			}
			set
			{
				this.itemAmountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType taxField;
		public BasicAmountType Tax
		{
			get
			{
				return this.taxField;
			}
			set
			{
				this.taxField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType shippingField;
		public BasicAmountType Shipping
		{
			get
			{
				return this.shippingField;
			}
			set
			{
				this.shippingField = value;
			}
		}
		

		/**
          *
		  */
		private string itemNameField;
		public string ItemName
		{
			get
			{
				return this.itemNameField;
			}
			set
			{
				this.itemNameField = value;
			}
		}
		

		/**
          *
		  */
		private string itemNumberField;
		public string ItemNumber
		{
			get
			{
				return this.itemNumberField;
			}
			set
			{
				this.itemNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string customField;
		public string Custom
		{
			get
			{
				return this.customField;
			}
			set
			{
				this.customField = value;
			}
		}
		

		/**
          *
		  */
		private string invoiceIDField;
		public string InvoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/**
          *
		  */
		private string returnURLField;
		public string ReturnURL
		{
			get
			{
				return this.returnURLField;
			}
			set
			{
				this.returnURLField = value;
			}
		}
		

		/**
          *
		  */
		private string cancelURLField;
		public string CancelURL
		{
			get
			{
				return this.cancelURLField;
			}
			set
			{
				this.cancelURLField = value;
			}
		}
		

		/**
          *
		  */
		private int? addressDisplayOptionsField;
		public int? AddressDisplayOptions
		{
			get
			{
				return this.addressDisplayOptionsField;
			}
			set
			{
				this.addressDisplayOptionsField = value;
			}
		}
		

		/**
          *
		  */
		private int? sharePhoneField;
		public int? SharePhone
		{
			get
			{
				return this.sharePhoneField;
			}
			set
			{
				this.sharePhoneField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType shipToAddressField;
		public AddressType ShipToAddress
		{
			get
			{
				return this.shipToAddressField;
			}
			set
			{
				this.shipToAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string buyerEmailField;
		public string BuyerEmail
		{
			get
			{
				return this.buyerEmailField;
			}
			set
			{
				this.buyerEmailField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public SetMobileCheckoutRequestDetailsType(BasicAmountType itemAmount, string itemName, string returnURL)
	 	{
			this.ItemAmount = itemAmount;
			this.ItemName = itemName;
			this.ReturnURL = returnURL;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public SetMobileCheckoutRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BuyerPhone != null)
			{
				sb.Append(BuyerPhone.ToXMLString(PreferredPrefix,"BuyerPhone"));
			}
			if(ItemAmount != null)
			{
				sb.Append(ItemAmount.ToXMLString(PreferredPrefix,"ItemAmount"));
			}
			if(Tax != null)
			{
				sb.Append(Tax.ToXMLString(PreferredPrefix,"Tax"));
			}
			if(Shipping != null)
			{
				sb.Append(Shipping.ToXMLString(PreferredPrefix,"Shipping"));
			}
			if(ItemName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ItemName));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemName>");
			}
			if(ItemNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ItemNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemNumber>");
			}
			if(Custom != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Custom>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Custom));
				sb.Append("</").Append(PreferredPrefix).Append(":Custom>");
			}
			if(InvoiceID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":InvoiceID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.InvoiceID));
				sb.Append("</").Append(PreferredPrefix).Append(":InvoiceID>");
			}
			if(ReturnURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReturnURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReturnURL));
				sb.Append("</").Append(PreferredPrefix).Append(":ReturnURL>");
			}
			if(CancelURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CancelURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CancelURL));
				sb.Append("</").Append(PreferredPrefix).Append(":CancelURL>");
			}
			if(AddressDisplayOptions != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AddressDisplayOptions>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.AddressDisplayOptions));
				sb.Append("</").Append(PreferredPrefix).Append(":AddressDisplayOptions>");
			}
			if(SharePhone != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SharePhone>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SharePhone));
				sb.Append("</").Append(PreferredPrefix).Append(":SharePhone>");
			}
			if(ShipToAddress != null)
			{
				sb.Append(ShipToAddress.ToXMLString(PreferredPrefix,"ShipToAddress"));
			}
			if(BuyerEmail != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BuyerEmail>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BuyerEmail));
				sb.Append("</").Append(PreferredPrefix).Append(":BuyerEmail>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *A free-form field for your own use, such as a tracking
      *number or other value you want returned to you in IPN.
      *Optional Character length and limitations: 256 single-byte
      *alphanumeric characters 
      */
	public partial class DoMobileCheckoutPaymentResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string customField;
		public string Custom
		{
			get
			{
				return this.customField;
			}
			set
			{
				this.customField = value;
			}
		}
		

		/**
          *
		  */
		private string invoiceIDField;
		public string InvoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/**
          *
		  */
		private PayerInfoType payerInfoField;
		public PayerInfoType PayerInfo
		{
			get
			{
				return this.payerInfoField;
			}
			set
			{
				this.payerInfoField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentInfoType paymentInfoField;
		public PaymentInfoType PaymentInfo
		{
			get
			{
				return this.paymentInfoField;
			}
			set
			{
				this.paymentInfoField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoMobileCheckoutPaymentResponseDetailsType()
	 	{
		}


		public DoMobileCheckoutPaymentResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Custom']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Custom = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'InvoiceID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.InvoiceID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PayerInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PayerInfo =  new PayerInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentInfo =  new PaymentInfoType(ChildNode);
			}
	
		}
	}




	/**
      *UATP Card Details Type 
      */
	public partial class UATPDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string uATPNumberField;
		public string UATPNumber
		{
			get
			{
				return this.uATPNumberField;
			}
			set
			{
				this.uATPNumberField = value;
			}
		}
		

		/**
          *
		  */
		private int? expMonthField;
		public int? ExpMonth
		{
			get
			{
				return this.expMonthField;
			}
			set
			{
				this.expMonthField = value;
			}
		}
		

		/**
          *
		  */
		private int? expYearField;
		public int? ExpYear
		{
			get
			{
				return this.expYearField;
			}
			set
			{
				this.expYearField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public UATPDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(UATPNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":UATPNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.UATPNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":UATPNumber>");
			}
			if(ExpMonth != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ExpMonth>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ExpMonth));
				sb.Append("</").Append(PreferredPrefix).Append(":ExpMonth>");
			}
			if(ExpYear != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ExpYear>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ExpYear));
				sb.Append("</").Append(PreferredPrefix).Append(":ExpYear>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public UATPDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'UATPNumber']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.UATPNumber = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ExpMonth']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ExpMonth = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ExpYear']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ExpYear = System.Convert.ToInt32(ChildNode.InnerText);
			}
	
		}
	}




	/**
      *
      */
	public partial class RecurringPaymentsSummaryType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string nextBillingDateField;
		public string NextBillingDate
		{
			get
			{
				return this.nextBillingDateField;
			}
			set
			{
				this.nextBillingDateField = value;
			}
		}
		

		/**
          *
		  */
		private int? numberCyclesCompletedField;
		public int? NumberCyclesCompleted
		{
			get
			{
				return this.numberCyclesCompletedField;
			}
			set
			{
				this.numberCyclesCompletedField = value;
			}
		}
		

		/**
          *
		  */
		private int? numberCyclesRemainingField;
		public int? NumberCyclesRemaining
		{
			get
			{
				return this.numberCyclesRemainingField;
			}
			set
			{
				this.numberCyclesRemainingField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType outstandingBalanceField;
		public BasicAmountType OutstandingBalance
		{
			get
			{
				return this.outstandingBalanceField;
			}
			set
			{
				this.outstandingBalanceField = value;
			}
		}
		

		/**
          *
		  */
		private int? failedPaymentCountField;
		public int? FailedPaymentCount
		{
			get
			{
				return this.failedPaymentCountField;
			}
			set
			{
				this.failedPaymentCountField = value;
			}
		}
		

		/**
          *
		  */
		private string lastPaymentDateField;
		public string LastPaymentDate
		{
			get
			{
				return this.lastPaymentDateField;
			}
			set
			{
				this.lastPaymentDateField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType lastPaymentAmountField;
		public BasicAmountType LastPaymentAmount
		{
			get
			{
				return this.lastPaymentAmountField;
			}
			set
			{
				this.lastPaymentAmountField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public RecurringPaymentsSummaryType()
	 	{
		}


		public RecurringPaymentsSummaryType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'NextBillingDate']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.NextBillingDate = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'NumberCyclesCompleted']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.NumberCyclesCompleted = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'NumberCyclesRemaining']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.NumberCyclesRemaining = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OutstandingBalance']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OutstandingBalance =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'FailedPaymentCount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.FailedPaymentCount = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'LastPaymentDate']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.LastPaymentDate = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'LastPaymentAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.LastPaymentAmount =  new BasicAmountType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class ActivationDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BasicAmountType initialAmountField;
		public BasicAmountType InitialAmount
		{
			get
			{
				return this.initialAmountField;
			}
			set
			{
				this.initialAmountField = value;
			}
		}
		

		/**
          *
		  */
		private FailedPaymentActionType? failedInitialAmountActionField;
		public FailedPaymentActionType? FailedInitialAmountAction
		{
			get
			{
				return this.failedInitialAmountActionField;
			}
			set
			{
				this.failedInitialAmountActionField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public ActivationDetailsType(BasicAmountType initialAmount)
	 	{
			this.InitialAmount = initialAmount;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public ActivationDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(InitialAmount != null)
			{
				sb.Append(InitialAmount.ToXMLString(PreferredPrefix,"InitialAmount"));
			}
			if(FailedInitialAmountAction != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":FailedInitialAmountAction>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.FailedInitialAmountAction)));
				sb.Append("</").Append(PreferredPrefix).Append(":FailedInitialAmountAction>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Unit of meausre for billing cycle 
      */
	public partial class BillingPeriodDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BillingPeriodType? billingPeriodField;
		public BillingPeriodType? BillingPeriod
		{
			get
			{
				return this.billingPeriodField;
			}
			set
			{
				this.billingPeriodField = value;
			}
		}
		

		/**
          *
		  */
		private int? billingFrequencyField;
		public int? BillingFrequency
		{
			get
			{
				return this.billingFrequencyField;
			}
			set
			{
				this.billingFrequencyField = value;
			}
		}
		

		/**
          *
		  */
		private int? totalBillingCyclesField;
		public int? TotalBillingCycles
		{
			get
			{
				return this.totalBillingCyclesField;
			}
			set
			{
				this.totalBillingCyclesField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType shippingAmountField;
		public BasicAmountType ShippingAmount
		{
			get
			{
				return this.shippingAmountField;
			}
			set
			{
				this.shippingAmountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType taxAmountField;
		public BasicAmountType TaxAmount
		{
			get
			{
				return this.taxAmountField;
			}
			set
			{
				this.taxAmountField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public BillingPeriodDetailsType(BillingPeriodType? billingPeriod, int? billingFrequency, BasicAmountType amount)
	 	{
			this.BillingPeriod = billingPeriod;
			this.BillingFrequency = billingFrequency;
			this.Amount = amount;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public BillingPeriodDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BillingPeriod != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BillingPeriod>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.BillingPeriod)));
				sb.Append("</").Append(PreferredPrefix).Append(":BillingPeriod>");
			}
			if(BillingFrequency != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BillingFrequency>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BillingFrequency));
				sb.Append("</").Append(PreferredPrefix).Append(":BillingFrequency>");
			}
			if(TotalBillingCycles != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TotalBillingCycles>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TotalBillingCycles));
				sb.Append("</").Append(PreferredPrefix).Append(":TotalBillingCycles>");
			}
			if(Amount != null)
			{
				sb.Append(Amount.ToXMLString(PreferredPrefix,"Amount"));
			}
			if(ShippingAmount != null)
			{
				sb.Append(ShippingAmount.ToXMLString(PreferredPrefix,"ShippingAmount"));
			}
			if(TaxAmount != null)
			{
				sb.Append(TaxAmount.ToXMLString(PreferredPrefix,"TaxAmount"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public BillingPeriodDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillingPeriod']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillingPeriod = (BillingPeriodType)EnumUtils.GetValue(ChildNode.InnerText,typeof(BillingPeriodType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillingFrequency']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillingFrequency = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TotalBillingCycles']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TotalBillingCycles = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Amount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Amount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ShippingAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ShippingAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TaxAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TaxAmount =  new BasicAmountType(ChildNode);
			}
	
		}
	}




	/**
      *Unit of meausre for billing cycle 
      */
	public partial class BillingPeriodDetailsType_Update	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BillingPeriodType? billingPeriodField;
		public BillingPeriodType? BillingPeriod
		{
			get
			{
				return this.billingPeriodField;
			}
			set
			{
				this.billingPeriodField = value;
			}
		}
		

		/**
          *
		  */
		private int? billingFrequencyField;
		public int? BillingFrequency
		{
			get
			{
				return this.billingFrequencyField;
			}
			set
			{
				this.billingFrequencyField = value;
			}
		}
		

		/**
          *
		  */
		private int? totalBillingCyclesField;
		public int? TotalBillingCycles
		{
			get
			{
				return this.totalBillingCyclesField;
			}
			set
			{
				this.totalBillingCyclesField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType shippingAmountField;
		public BasicAmountType ShippingAmount
		{
			get
			{
				return this.shippingAmountField;
			}
			set
			{
				this.shippingAmountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType taxAmountField;
		public BasicAmountType TaxAmount
		{
			get
			{
				return this.taxAmountField;
			}
			set
			{
				this.taxAmountField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BillingPeriodDetailsType_Update()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BillingPeriod != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BillingPeriod>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.BillingPeriod)));
				sb.Append("</").Append(PreferredPrefix).Append(":BillingPeriod>");
			}
			if(BillingFrequency != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BillingFrequency>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BillingFrequency));
				sb.Append("</").Append(PreferredPrefix).Append(":BillingFrequency>");
			}
			if(TotalBillingCycles != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TotalBillingCycles>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TotalBillingCycles));
				sb.Append("</").Append(PreferredPrefix).Append(":TotalBillingCycles>");
			}
			if(Amount != null)
			{
				sb.Append(Amount.ToXMLString(PreferredPrefix,"Amount"));
			}
			if(ShippingAmount != null)
			{
				sb.Append(ShippingAmount.ToXMLString(PreferredPrefix,"ShippingAmount"));
			}
			if(TaxAmount != null)
			{
				sb.Append(TaxAmount.ToXMLString(PreferredPrefix,"TaxAmount"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Schedule details for the Recurring Payment 
      */
	public partial class ScheduleDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string descriptionField;
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		

		/**
          *
		  */
		private BillingPeriodDetailsType trialPeriodField;
		public BillingPeriodDetailsType TrialPeriod
		{
			get
			{
				return this.trialPeriodField;
			}
			set
			{
				this.trialPeriodField = value;
			}
		}
		

		/**
          *
		  */
		private BillingPeriodDetailsType paymentPeriodField;
		public BillingPeriodDetailsType PaymentPeriod
		{
			get
			{
				return this.paymentPeriodField;
			}
			set
			{
				this.paymentPeriodField = value;
			}
		}
		

		/**
          *
		  */
		private int? maxFailedPaymentsField;
		public int? MaxFailedPayments
		{
			get
			{
				return this.maxFailedPaymentsField;
			}
			set
			{
				this.maxFailedPaymentsField = value;
			}
		}
		

		/**
          *
		  */
		private ActivationDetailsType activationDetailsField;
		public ActivationDetailsType ActivationDetails
		{
			get
			{
				return this.activationDetailsField;
			}
			set
			{
				this.activationDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private AutoBillType? autoBillOutstandingAmountField;
		public AutoBillType? AutoBillOutstandingAmount
		{
			get
			{
				return this.autoBillOutstandingAmountField;
			}
			set
			{
				this.autoBillOutstandingAmountField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public ScheduleDetailsType(string description, BillingPeriodDetailsType paymentPeriod)
	 	{
			this.Description = description;
			this.PaymentPeriod = paymentPeriod;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public ScheduleDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Description != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Description>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Description));
				sb.Append("</").Append(PreferredPrefix).Append(":Description>");
			}
			if(TrialPeriod != null)
			{
				sb.Append(TrialPeriod.ToXMLString(PreferredPrefix,"TrialPeriod"));
			}
			if(PaymentPeriod != null)
			{
				sb.Append(PaymentPeriod.ToXMLString(PreferredPrefix,"PaymentPeriod"));
			}
			if(MaxFailedPayments != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MaxFailedPayments>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.MaxFailedPayments));
				sb.Append("</").Append(PreferredPrefix).Append(":MaxFailedPayments>");
			}
			if(ActivationDetails != null)
			{
				sb.Append(ActivationDetails.ToXMLString(PreferredPrefix,"ActivationDetails"));
			}
			if(AutoBillOutstandingAmount != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AutoBillOutstandingAmount>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.AutoBillOutstandingAmount)));
				sb.Append("</").Append(PreferredPrefix).Append(":AutoBillOutstandingAmount>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Subscriber name - if missing, will use name in buyer's
      *account 
      */
	public partial class RecurringPaymentsProfileDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string subscriberNameField;
		public string SubscriberName
		{
			get
			{
				return this.subscriberNameField;
			}
			set
			{
				this.subscriberNameField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType subscriberShippingAddressField;
		public AddressType SubscriberShippingAddress
		{
			get
			{
				return this.subscriberShippingAddressField;
			}
			set
			{
				this.subscriberShippingAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string billingStartDateField;
		public string BillingStartDate
		{
			get
			{
				return this.billingStartDateField;
			}
			set
			{
				this.billingStartDateField = value;
			}
		}
		

		/**
          *
		  */
		private string profileReferenceField;
		public string ProfileReference
		{
			get
			{
				return this.profileReferenceField;
			}
			set
			{
				this.profileReferenceField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public RecurringPaymentsProfileDetailsType(string billingStartDate)
	 	{
			this.BillingStartDate = billingStartDate;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public RecurringPaymentsProfileDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(SubscriberName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SubscriberName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SubscriberName));
				sb.Append("</").Append(PreferredPrefix).Append(":SubscriberName>");
			}
			if(SubscriberShippingAddress != null)
			{
				sb.Append(SubscriberShippingAddress.ToXMLString(PreferredPrefix,"SubscriberShippingAddress"));
			}
			if(BillingStartDate != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BillingStartDate>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BillingStartDate));
				sb.Append("</").Append(PreferredPrefix).Append(":BillingStartDate>");
			}
			if(ProfileReference != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ProfileReference>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ProfileReference));
				sb.Append("</").Append(PreferredPrefix).Append(":ProfileReference>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public RecurringPaymentsProfileDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SubscriberName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SubscriberName = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SubscriberShippingAddress']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SubscriberShippingAddress =  new AddressType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillingStartDate']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillingStartDate = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ProfileReference']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ProfileReference = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Billing Agreement token (required if Express Checkout) 
      */
	public partial class CreateRecurringPaymentsProfileRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
          *
		  */
		private CreditCardDetailsType creditCardField;
		public CreditCardDetailsType CreditCard
		{
			get
			{
				return this.creditCardField;
			}
			set
			{
				this.creditCardField = value;
			}
		}
		

		/**
          *
		  */
		private RecurringPaymentsProfileDetailsType recurringPaymentsProfileDetailsField;
		public RecurringPaymentsProfileDetailsType RecurringPaymentsProfileDetails
		{
			get
			{
				return this.recurringPaymentsProfileDetailsField;
			}
			set
			{
				this.recurringPaymentsProfileDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private ScheduleDetailsType scheduleDetailsField;
		public ScheduleDetailsType ScheduleDetails
		{
			get
			{
				return this.scheduleDetailsField;
			}
			set
			{
				this.scheduleDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private List<PaymentDetailsItemType> paymentDetailsItemField = new List<PaymentDetailsItemType>();
		public List<PaymentDetailsItemType> PaymentDetailsItem
		{
			get
			{
				return this.paymentDetailsItemField;
			}
			set
			{
				this.paymentDetailsItemField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public CreateRecurringPaymentsProfileRequestDetailsType(RecurringPaymentsProfileDetailsType recurringPaymentsProfileDetails, ScheduleDetailsType scheduleDetails)
	 	{
			this.RecurringPaymentsProfileDetails = recurringPaymentsProfileDetails;
			this.ScheduleDetails = scheduleDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public CreateRecurringPaymentsProfileRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Token != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Token>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Token));
				sb.Append("</").Append(PreferredPrefix).Append(":Token>");
			}
			if(CreditCard != null)
			{
				sb.Append(CreditCard.ToXMLString(PreferredPrefix,"CreditCard"));
			}
			if(RecurringPaymentsProfileDetails != null)
			{
				sb.Append(RecurringPaymentsProfileDetails.ToXMLString(PreferredPrefix,"RecurringPaymentsProfileDetails"));
			}
			if(ScheduleDetails != null)
			{
				sb.Append(ScheduleDetails.ToXMLString(PreferredPrefix,"ScheduleDetails"));
			}
			if(PaymentDetailsItem != null)
			{
				for(int i = 0; i < PaymentDetailsItem.Count; i++)
				{
					sb.Append(PaymentDetailsItem[i].ToXMLString(PreferredPrefix,"PaymentDetailsItem"));
				}
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Recurring Billing Profile ID 
      */
	public partial class CreateRecurringPaymentsProfileResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string profileIDField;
		public string ProfileID
		{
			get
			{
				return this.profileIDField;
			}
			set
			{
				this.profileIDField = value;
			}
		}
		

		/**
          *
		  */
		private RecurringPaymentsProfileStatusType? profileStatusField;
		public RecurringPaymentsProfileStatusType? ProfileStatus
		{
			get
			{
				return this.profileStatusField;
			}
			set
			{
				this.profileStatusField = value;
			}
		}
		

		/**
          *
		  */
		private string transactionIDField;
		public string TransactionID
		{
			get
			{
				return this.transactionIDField;
			}
			set
			{
				this.transactionIDField = value;
			}
		}
		

		/**
          *
		  */
		private string dCCProcessorResponseField;
		public string DCCProcessorResponse
		{
			get
			{
				return this.dCCProcessorResponseField;
			}
			set
			{
				this.dCCProcessorResponseField = value;
			}
		}
		

		/**
          *
		  */
		private string dCCReturnCodeField;
		public string DCCReturnCode
		{
			get
			{
				return this.dCCReturnCodeField;
			}
			set
			{
				this.dCCReturnCodeField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CreateRecurringPaymentsProfileResponseDetailsType()
	 	{
		}


		public CreateRecurringPaymentsProfileResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ProfileID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ProfileID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ProfileStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ProfileStatus = (RecurringPaymentsProfileStatusType)EnumUtils.GetValue(ChildNode.InnerText,typeof(RecurringPaymentsProfileStatusType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TransactionID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TransactionID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'DCCProcessorResponse']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.DCCProcessorResponse = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'DCCReturnCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.DCCReturnCode = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Recurring Billing Profile ID 
      */
	public partial class GetRecurringPaymentsProfileDetailsResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string profileIDField;
		public string ProfileID
		{
			get
			{
				return this.profileIDField;
			}
			set
			{
				this.profileIDField = value;
			}
		}
		

		/**
          *
		  */
		private RecurringPaymentsProfileStatusType? profileStatusField;
		public RecurringPaymentsProfileStatusType? ProfileStatus
		{
			get
			{
				return this.profileStatusField;
			}
			set
			{
				this.profileStatusField = value;
			}
		}
		

		/**
          *
		  */
		private string descriptionField;
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		

		/**
          *
		  */
		private AutoBillType? autoBillOutstandingAmountField;
		public AutoBillType? AutoBillOutstandingAmount
		{
			get
			{
				return this.autoBillOutstandingAmountField;
			}
			set
			{
				this.autoBillOutstandingAmountField = value;
			}
		}
		

		/**
          *
		  */
		private int? maxFailedPaymentsField;
		public int? MaxFailedPayments
		{
			get
			{
				return this.maxFailedPaymentsField;
			}
			set
			{
				this.maxFailedPaymentsField = value;
			}
		}
		

		/**
          *
		  */
		private RecurringPaymentsProfileDetailsType recurringPaymentsProfileDetailsField;
		public RecurringPaymentsProfileDetailsType RecurringPaymentsProfileDetails
		{
			get
			{
				return this.recurringPaymentsProfileDetailsField;
			}
			set
			{
				this.recurringPaymentsProfileDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private BillingPeriodDetailsType currentRecurringPaymentsPeriodField;
		public BillingPeriodDetailsType CurrentRecurringPaymentsPeriod
		{
			get
			{
				return this.currentRecurringPaymentsPeriodField;
			}
			set
			{
				this.currentRecurringPaymentsPeriodField = value;
			}
		}
		

		/**
          *
		  */
		private RecurringPaymentsSummaryType recurringPaymentsSummaryField;
		public RecurringPaymentsSummaryType RecurringPaymentsSummary
		{
			get
			{
				return this.recurringPaymentsSummaryField;
			}
			set
			{
				this.recurringPaymentsSummaryField = value;
			}
		}
		

		/**
          *
		  */
		private CreditCardDetailsType creditCardField;
		public CreditCardDetailsType CreditCard
		{
			get
			{
				return this.creditCardField;
			}
			set
			{
				this.creditCardField = value;
			}
		}
		

		/**
          *
		  */
		private BillingPeriodDetailsType trialRecurringPaymentsPeriodField;
		public BillingPeriodDetailsType TrialRecurringPaymentsPeriod
		{
			get
			{
				return this.trialRecurringPaymentsPeriodField;
			}
			set
			{
				this.trialRecurringPaymentsPeriodField = value;
			}
		}
		

		/**
          *
		  */
		private BillingPeriodDetailsType regularRecurringPaymentsPeriodField;
		public BillingPeriodDetailsType RegularRecurringPaymentsPeriod
		{
			get
			{
				return this.regularRecurringPaymentsPeriodField;
			}
			set
			{
				this.regularRecurringPaymentsPeriodField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType trialAmountPaidField;
		public BasicAmountType TrialAmountPaid
		{
			get
			{
				return this.trialAmountPaidField;
			}
			set
			{
				this.trialAmountPaidField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType regularAmountPaidField;
		public BasicAmountType RegularAmountPaid
		{
			get
			{
				return this.regularAmountPaidField;
			}
			set
			{
				this.regularAmountPaidField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType aggregateAmountField;
		public BasicAmountType AggregateAmount
		{
			get
			{
				return this.aggregateAmountField;
			}
			set
			{
				this.aggregateAmountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType aggregateOptionalAmountField;
		public BasicAmountType AggregateOptionalAmount
		{
			get
			{
				return this.aggregateOptionalAmountField;
			}
			set
			{
				this.aggregateOptionalAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string finalPaymentDueDateField;
		public string FinalPaymentDueDate
		{
			get
			{
				return this.finalPaymentDueDateField;
			}
			set
			{
				this.finalPaymentDueDateField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetRecurringPaymentsProfileDetailsResponseDetailsType()
	 	{
		}


		public GetRecurringPaymentsProfileDetailsResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ProfileID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ProfileID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ProfileStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ProfileStatus = (RecurringPaymentsProfileStatusType)EnumUtils.GetValue(ChildNode.InnerText,typeof(RecurringPaymentsProfileStatusType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Description']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Description = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AutoBillOutstandingAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AutoBillOutstandingAmount = (AutoBillType)EnumUtils.GetValue(ChildNode.InnerText,typeof(AutoBillType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'MaxFailedPayments']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.MaxFailedPayments = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RecurringPaymentsProfileDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RecurringPaymentsProfileDetails =  new RecurringPaymentsProfileDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CurrentRecurringPaymentsPeriod']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CurrentRecurringPaymentsPeriod =  new BillingPeriodDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RecurringPaymentsSummary']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RecurringPaymentsSummary =  new RecurringPaymentsSummaryType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CreditCard']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CreditCard =  new CreditCardDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TrialRecurringPaymentsPeriod']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TrialRecurringPaymentsPeriod =  new BillingPeriodDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RegularRecurringPaymentsPeriod']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RegularRecurringPaymentsPeriod =  new BillingPeriodDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TrialAmountPaid']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TrialAmountPaid =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RegularAmountPaid']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RegularAmountPaid =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AggregateAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AggregateAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AggregateOptionalAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AggregateOptionalAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'FinalPaymentDueDate']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.FinalPaymentDueDate = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class ManageRecurringPaymentsProfileStatusRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string profileIDField;
		public string ProfileID
		{
			get
			{
				return this.profileIDField;
			}
			set
			{
				this.profileIDField = value;
			}
		}
		

		/**
          *
		  */
		private StatusChangeActionType? actionField;
		public StatusChangeActionType? Action
		{
			get
			{
				return this.actionField;
			}
			set
			{
				this.actionField = value;
			}
		}
		

		/**
          *
		  */
		private string noteField;
		public string Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public ManageRecurringPaymentsProfileStatusRequestDetailsType(string profileID, StatusChangeActionType? action)
	 	{
			this.ProfileID = profileID;
			this.Action = action;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public ManageRecurringPaymentsProfileStatusRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ProfileID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ProfileID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ProfileID));
				sb.Append("</").Append(PreferredPrefix).Append(":ProfileID>");
			}
			if(Action != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Action>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.Action)));
				sb.Append("</").Append(PreferredPrefix).Append(":Action>");
			}
			if(Note != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Note>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Note));
				sb.Append("</").Append(PreferredPrefix).Append(":Note>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class ManageRecurringPaymentsProfileStatusResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string profileIDField;
		public string ProfileID
		{
			get
			{
				return this.profileIDField;
			}
			set
			{
				this.profileIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ManageRecurringPaymentsProfileStatusResponseDetailsType()
	 	{
		}


		public ManageRecurringPaymentsProfileStatusResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ProfileID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ProfileID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class BillOutstandingAmountRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string profileIDField;
		public string ProfileID
		{
			get
			{
				return this.profileIDField;
			}
			set
			{
				this.profileIDField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private string noteField;
		public string Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public BillOutstandingAmountRequestDetailsType(string profileID)
	 	{
			this.ProfileID = profileID;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public BillOutstandingAmountRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ProfileID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ProfileID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ProfileID));
				sb.Append("</").Append(PreferredPrefix).Append(":ProfileID>");
			}
			if(Amount != null)
			{
				sb.Append(Amount.ToXMLString(PreferredPrefix,"Amount"));
			}
			if(Note != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Note>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Note));
				sb.Append("</").Append(PreferredPrefix).Append(":Note>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class BillOutstandingAmountResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string profileIDField;
		public string ProfileID
		{
			get
			{
				return this.profileIDField;
			}
			set
			{
				this.profileIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BillOutstandingAmountResponseDetailsType()
	 	{
		}


		public BillOutstandingAmountResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ProfileID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ProfileID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class UpdateRecurringPaymentsProfileRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string profileIDField;
		public string ProfileID
		{
			get
			{
				return this.profileIDField;
			}
			set
			{
				this.profileIDField = value;
			}
		}
		

		/**
          *
		  */
		private string noteField;
		public string Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}
		

		/**
          *
		  */
		private string descriptionField;
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		

		/**
          *
		  */
		private string subscriberNameField;
		public string SubscriberName
		{
			get
			{
				return this.subscriberNameField;
			}
			set
			{
				this.subscriberNameField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType subscriberShippingAddressField;
		public AddressType SubscriberShippingAddress
		{
			get
			{
				return this.subscriberShippingAddressField;
			}
			set
			{
				this.subscriberShippingAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string profileReferenceField;
		public string ProfileReference
		{
			get
			{
				return this.profileReferenceField;
			}
			set
			{
				this.profileReferenceField = value;
			}
		}
		

		/**
          *
		  */
		private int? additionalBillingCyclesField;
		public int? AdditionalBillingCycles
		{
			get
			{
				return this.additionalBillingCyclesField;
			}
			set
			{
				this.additionalBillingCyclesField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType shippingAmountField;
		public BasicAmountType ShippingAmount
		{
			get
			{
				return this.shippingAmountField;
			}
			set
			{
				this.shippingAmountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType taxAmountField;
		public BasicAmountType TaxAmount
		{
			get
			{
				return this.taxAmountField;
			}
			set
			{
				this.taxAmountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType outstandingBalanceField;
		public BasicAmountType OutstandingBalance
		{
			get
			{
				return this.outstandingBalanceField;
			}
			set
			{
				this.outstandingBalanceField = value;
			}
		}
		

		/**
          *
		  */
		private AutoBillType? autoBillOutstandingAmountField;
		public AutoBillType? AutoBillOutstandingAmount
		{
			get
			{
				return this.autoBillOutstandingAmountField;
			}
			set
			{
				this.autoBillOutstandingAmountField = value;
			}
		}
		

		/**
          *
		  */
		private int? maxFailedPaymentsField;
		public int? MaxFailedPayments
		{
			get
			{
				return this.maxFailedPaymentsField;
			}
			set
			{
				this.maxFailedPaymentsField = value;
			}
		}
		

		/**
          *
		  */
		private CreditCardDetailsType creditCardField;
		public CreditCardDetailsType CreditCard
		{
			get
			{
				return this.creditCardField;
			}
			set
			{
				this.creditCardField = value;
			}
		}
		

		/**
          *
		  */
		private string billingStartDateField;
		public string BillingStartDate
		{
			get
			{
				return this.billingStartDateField;
			}
			set
			{
				this.billingStartDateField = value;
			}
		}
		

		/**
          *
		  */
		private BillingPeriodDetailsType_Update trialPeriodField;
		public BillingPeriodDetailsType_Update TrialPeriod
		{
			get
			{
				return this.trialPeriodField;
			}
			set
			{
				this.trialPeriodField = value;
			}
		}
		

		/**
          *
		  */
		private BillingPeriodDetailsType_Update paymentPeriodField;
		public BillingPeriodDetailsType_Update PaymentPeriod
		{
			get
			{
				return this.paymentPeriodField;
			}
			set
			{
				this.paymentPeriodField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public UpdateRecurringPaymentsProfileRequestDetailsType(string profileID)
	 	{
			this.ProfileID = profileID;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public UpdateRecurringPaymentsProfileRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ProfileID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ProfileID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ProfileID));
				sb.Append("</").Append(PreferredPrefix).Append(":ProfileID>");
			}
			if(Note != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Note>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Note));
				sb.Append("</").Append(PreferredPrefix).Append(":Note>");
			}
			if(Description != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Description>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Description));
				sb.Append("</").Append(PreferredPrefix).Append(":Description>");
			}
			if(SubscriberName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SubscriberName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SubscriberName));
				sb.Append("</").Append(PreferredPrefix).Append(":SubscriberName>");
			}
			if(SubscriberShippingAddress != null)
			{
				sb.Append(SubscriberShippingAddress.ToXMLString(PreferredPrefix,"SubscriberShippingAddress"));
			}
			if(ProfileReference != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ProfileReference>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ProfileReference));
				sb.Append("</").Append(PreferredPrefix).Append(":ProfileReference>");
			}
			if(AdditionalBillingCycles != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AdditionalBillingCycles>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.AdditionalBillingCycles));
				sb.Append("</").Append(PreferredPrefix).Append(":AdditionalBillingCycles>");
			}
			if(Amount != null)
			{
				sb.Append(Amount.ToXMLString(PreferredPrefix,"Amount"));
			}
			if(ShippingAmount != null)
			{
				sb.Append(ShippingAmount.ToXMLString(PreferredPrefix,"ShippingAmount"));
			}
			if(TaxAmount != null)
			{
				sb.Append(TaxAmount.ToXMLString(PreferredPrefix,"TaxAmount"));
			}
			if(OutstandingBalance != null)
			{
				sb.Append(OutstandingBalance.ToXMLString(PreferredPrefix,"OutstandingBalance"));
			}
			if(AutoBillOutstandingAmount != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AutoBillOutstandingAmount>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.AutoBillOutstandingAmount)));
				sb.Append("</").Append(PreferredPrefix).Append(":AutoBillOutstandingAmount>");
			}
			if(MaxFailedPayments != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MaxFailedPayments>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.MaxFailedPayments));
				sb.Append("</").Append(PreferredPrefix).Append(":MaxFailedPayments>");
			}
			if(CreditCard != null)
			{
				sb.Append(CreditCard.ToXMLString(PreferredPrefix,"CreditCard"));
			}
			if(BillingStartDate != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BillingStartDate>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BillingStartDate));
				sb.Append("</").Append(PreferredPrefix).Append(":BillingStartDate>");
			}
			if(TrialPeriod != null)
			{
				sb.Append(TrialPeriod.ToXMLString(PreferredPrefix,"TrialPeriod"));
			}
			if(PaymentPeriod != null)
			{
				sb.Append(PaymentPeriod.ToXMLString(PreferredPrefix,"PaymentPeriod"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class UpdateRecurringPaymentsProfileResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string profileIDField;
		public string ProfileID
		{
			get
			{
				return this.profileIDField;
			}
			set
			{
				this.profileIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public UpdateRecurringPaymentsProfileResponseDetailsType()
	 	{
		}


		public UpdateRecurringPaymentsProfileResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ProfileID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ProfileID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Details of Risk Filter. 
      */
	public partial class RiskFilterDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private int? idField;
		public int? Id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}
		

		/**
          *
		  */
		private string nameField;
		public string Name
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
		

		/**
          *
		  */
		private string descriptionField;
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public RiskFilterDetailsType()
	 	{
		}


		public RiskFilterDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Id']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Id = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Name']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Name = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Description']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Description = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Details of Risk Filter. 
      */
	public partial class RiskFilterListType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private List<RiskFilterDetailsType> filtersField = new List<RiskFilterDetailsType>();
		public List<RiskFilterDetailsType> Filters
		{
			get
			{
				return this.filtersField;
			}
			set
			{
				this.filtersField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public RiskFilterListType()
	 	{
		}


		public RiskFilterListType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'Filters']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.Filters.Add(new RiskFilterDetailsType(subNode));
				}
			}
	
		}
	}




	/**
      *Thes are filters that could result in accept/deny/pending
      *action. 
      */
	public partial class FMFDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private RiskFilterListType acceptFiltersField;
		public RiskFilterListType AcceptFilters
		{
			get
			{
				return this.acceptFiltersField;
			}
			set
			{
				this.acceptFiltersField = value;
			}
		}
		

		/**
          *
		  */
		private RiskFilterListType pendingFiltersField;
		public RiskFilterListType PendingFilters
		{
			get
			{
				return this.pendingFiltersField;
			}
			set
			{
				this.pendingFiltersField = value;
			}
		}
		

		/**
          *
		  */
		private RiskFilterListType denyFiltersField;
		public RiskFilterListType DenyFilters
		{
			get
			{
				return this.denyFiltersField;
			}
			set
			{
				this.denyFiltersField = value;
			}
		}
		

		/**
          *
		  */
		private RiskFilterListType reportFiltersField;
		public RiskFilterListType ReportFilters
		{
			get
			{
				return this.reportFiltersField;
			}
			set
			{
				this.reportFiltersField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public FMFDetailsType()
	 	{
		}


		public FMFDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AcceptFilters']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AcceptFilters =  new RiskFilterListType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PendingFilters']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PendingFilters =  new RiskFilterListType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'DenyFilters']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.DenyFilters =  new RiskFilterListType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ReportFilters']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ReportFilters =  new RiskFilterListType(ChildNode);
			}
	
		}
	}




	/**
      *Enhanced Data Information. Example: AID for Airlines 
      */
	public partial class EnhancedDataType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private AirlineItineraryType airlineItineraryField;
		public AirlineItineraryType AirlineItinerary
		{
			get
			{
				return this.airlineItineraryField;
			}
			set
			{
				this.airlineItineraryField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public EnhancedDataType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(AirlineItinerary != null)
			{
				sb.Append(AirlineItinerary.ToXMLString(PreferredPrefix,"AirlineItinerary"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *AID for Airlines 
      */
	public partial class AirlineItineraryType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string passengerNameField;
		public string PassengerName
		{
			get
			{
				return this.passengerNameField;
			}
			set
			{
				this.passengerNameField = value;
			}
		}
		

		/**
          *
		  */
		private string issueDateField;
		public string IssueDate
		{
			get
			{
				return this.issueDateField;
			}
			set
			{
				this.issueDateField = value;
			}
		}
		

		/**
          *
		  */
		private string travelAgencyNameField;
		public string TravelAgencyName
		{
			get
			{
				return this.travelAgencyNameField;
			}
			set
			{
				this.travelAgencyNameField = value;
			}
		}
		

		/**
          *
		  */
		private string travelAgencyCodeField;
		public string TravelAgencyCode
		{
			get
			{
				return this.travelAgencyCodeField;
			}
			set
			{
				this.travelAgencyCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string ticketNumberField;
		public string TicketNumber
		{
			get
			{
				return this.ticketNumberField;
			}
			set
			{
				this.ticketNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string issuingCarrierCodeField;
		public string IssuingCarrierCode
		{
			get
			{
				return this.issuingCarrierCodeField;
			}
			set
			{
				this.issuingCarrierCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string customerCodeField;
		public string CustomerCode
		{
			get
			{
				return this.customerCodeField;
			}
			set
			{
				this.customerCodeField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType totalFareField;
		public BasicAmountType TotalFare
		{
			get
			{
				return this.totalFareField;
			}
			set
			{
				this.totalFareField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType totalTaxesField;
		public BasicAmountType TotalTaxes
		{
			get
			{
				return this.totalTaxesField;
			}
			set
			{
				this.totalTaxesField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType totalFeeField;
		public BasicAmountType TotalFee
		{
			get
			{
				return this.totalFeeField;
			}
			set
			{
				this.totalFeeField = value;
			}
		}
		

		/**
          *
		  */
		private string restrictedTicketField;
		public string RestrictedTicket
		{
			get
			{
				return this.restrictedTicketField;
			}
			set
			{
				this.restrictedTicketField = value;
			}
		}
		

		/**
          *
		  */
		private string clearingSequenceField;
		public string ClearingSequence
		{
			get
			{
				return this.clearingSequenceField;
			}
			set
			{
				this.clearingSequenceField = value;
			}
		}
		

		/**
          *
		  */
		private string clearingCountField;
		public string ClearingCount
		{
			get
			{
				return this.clearingCountField;
			}
			set
			{
				this.clearingCountField = value;
			}
		}
		

		/**
          *
		  */
		private List<FlightDetailsType> flightDetailsField = new List<FlightDetailsType>();
		public List<FlightDetailsType> FlightDetails
		{
			get
			{
				return this.flightDetailsField;
			}
			set
			{
				this.flightDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public AirlineItineraryType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(PassengerName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PassengerName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PassengerName));
				sb.Append("</").Append(PreferredPrefix).Append(":PassengerName>");
			}
			if(IssueDate != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":IssueDate>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.IssueDate));
				sb.Append("</").Append(PreferredPrefix).Append(":IssueDate>");
			}
			if(TravelAgencyName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TravelAgencyName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TravelAgencyName));
				sb.Append("</").Append(PreferredPrefix).Append(":TravelAgencyName>");
			}
			if(TravelAgencyCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TravelAgencyCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TravelAgencyCode));
				sb.Append("</").Append(PreferredPrefix).Append(":TravelAgencyCode>");
			}
			if(TicketNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TicketNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TicketNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":TicketNumber>");
			}
			if(IssuingCarrierCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":IssuingCarrierCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.IssuingCarrierCode));
				sb.Append("</").Append(PreferredPrefix).Append(":IssuingCarrierCode>");
			}
			if(CustomerCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CustomerCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CustomerCode));
				sb.Append("</").Append(PreferredPrefix).Append(":CustomerCode>");
			}
			if(TotalFare != null)
			{
				sb.Append(TotalFare.ToXMLString(PreferredPrefix,"TotalFare"));
			}
			if(TotalTaxes != null)
			{
				sb.Append(TotalTaxes.ToXMLString(PreferredPrefix,"TotalTaxes"));
			}
			if(TotalFee != null)
			{
				sb.Append(TotalFee.ToXMLString(PreferredPrefix,"TotalFee"));
			}
			if(RestrictedTicket != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":RestrictedTicket>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.RestrictedTicket));
				sb.Append("</").Append(PreferredPrefix).Append(":RestrictedTicket>");
			}
			if(ClearingSequence != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ClearingSequence>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ClearingSequence));
				sb.Append("</").Append(PreferredPrefix).Append(":ClearingSequence>");
			}
			if(ClearingCount != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ClearingCount>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ClearingCount));
				sb.Append("</").Append(PreferredPrefix).Append(":ClearingCount>");
			}
			if(FlightDetails != null)
			{
				for(int i = 0; i < FlightDetails.Count; i++)
				{
					sb.Append(FlightDetails[i].ToXMLString(PreferredPrefix,"FlightDetails"));
				}
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Details of leg information 
      */
	public partial class FlightDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string conjuctionTicketField;
		public string ConjuctionTicket
		{
			get
			{
				return this.conjuctionTicketField;
			}
			set
			{
				this.conjuctionTicketField = value;
			}
		}
		

		/**
          *
		  */
		private string exchangeTicketField;
		public string ExchangeTicket
		{
			get
			{
				return this.exchangeTicketField;
			}
			set
			{
				this.exchangeTicketField = value;
			}
		}
		

		/**
          *
		  */
		private string couponNumberField;
		public string CouponNumber
		{
			get
			{
				return this.couponNumberField;
			}
			set
			{
				this.couponNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string serviceClassField;
		public string ServiceClass
		{
			get
			{
				return this.serviceClassField;
			}
			set
			{
				this.serviceClassField = value;
			}
		}
		

		/**
          *
		  */
		private string travelDateField;
		public string TravelDate
		{
			get
			{
				return this.travelDateField;
			}
			set
			{
				this.travelDateField = value;
			}
		}
		

		/**
          *
		  */
		private string carrierCodeField;
		public string CarrierCode
		{
			get
			{
				return this.carrierCodeField;
			}
			set
			{
				this.carrierCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string stopOverPermittedField;
		public string StopOverPermitted
		{
			get
			{
				return this.stopOverPermittedField;
			}
			set
			{
				this.stopOverPermittedField = value;
			}
		}
		

		/**
          *
		  */
		private string departureAirportField;
		public string DepartureAirport
		{
			get
			{
				return this.departureAirportField;
			}
			set
			{
				this.departureAirportField = value;
			}
		}
		

		/**
          *
		  */
		private string arrivalAirportField;
		public string ArrivalAirport
		{
			get
			{
				return this.arrivalAirportField;
			}
			set
			{
				this.arrivalAirportField = value;
			}
		}
		

		/**
          *
		  */
		private string flightNumberField;
		public string FlightNumber
		{
			get
			{
				return this.flightNumberField;
			}
			set
			{
				this.flightNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string departureTimeField;
		public string DepartureTime
		{
			get
			{
				return this.departureTimeField;
			}
			set
			{
				this.departureTimeField = value;
			}
		}
		

		/**
          *
		  */
		private string arrivalTimeField;
		public string ArrivalTime
		{
			get
			{
				return this.arrivalTimeField;
			}
			set
			{
				this.arrivalTimeField = value;
			}
		}
		

		/**
          *
		  */
		private string fareBasisCodeField;
		public string FareBasisCode
		{
			get
			{
				return this.fareBasisCodeField;
			}
			set
			{
				this.fareBasisCodeField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType fareField;
		public BasicAmountType Fare
		{
			get
			{
				return this.fareField;
			}
			set
			{
				this.fareField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType taxesField;
		public BasicAmountType Taxes
		{
			get
			{
				return this.taxesField;
			}
			set
			{
				this.taxesField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType feeField;
		public BasicAmountType Fee
		{
			get
			{
				return this.feeField;
			}
			set
			{
				this.feeField = value;
			}
		}
		

		/**
          *
		  */
		private string endorsementOrRestrictionsField;
		public string EndorsementOrRestrictions
		{
			get
			{
				return this.endorsementOrRestrictionsField;
			}
			set
			{
				this.endorsementOrRestrictionsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public FlightDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ConjuctionTicket != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ConjuctionTicket>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ConjuctionTicket));
				sb.Append("</").Append(PreferredPrefix).Append(":ConjuctionTicket>");
			}
			if(ExchangeTicket != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ExchangeTicket>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ExchangeTicket));
				sb.Append("</").Append(PreferredPrefix).Append(":ExchangeTicket>");
			}
			if(CouponNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CouponNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CouponNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":CouponNumber>");
			}
			if(ServiceClass != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ServiceClass>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ServiceClass));
				sb.Append("</").Append(PreferredPrefix).Append(":ServiceClass>");
			}
			if(TravelDate != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TravelDate>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TravelDate));
				sb.Append("</").Append(PreferredPrefix).Append(":TravelDate>");
			}
			if(CarrierCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CarrierCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CarrierCode));
				sb.Append("</").Append(PreferredPrefix).Append(":CarrierCode>");
			}
			if(StopOverPermitted != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":StopOverPermitted>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.StopOverPermitted));
				sb.Append("</").Append(PreferredPrefix).Append(":StopOverPermitted>");
			}
			if(DepartureAirport != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":DepartureAirport>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.DepartureAirport));
				sb.Append("</").Append(PreferredPrefix).Append(":DepartureAirport>");
			}
			if(ArrivalAirport != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ArrivalAirport>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ArrivalAirport));
				sb.Append("</").Append(PreferredPrefix).Append(":ArrivalAirport>");
			}
			if(FlightNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":FlightNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.FlightNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":FlightNumber>");
			}
			if(DepartureTime != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":DepartureTime>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.DepartureTime));
				sb.Append("</").Append(PreferredPrefix).Append(":DepartureTime>");
			}
			if(ArrivalTime != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ArrivalTime>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ArrivalTime));
				sb.Append("</").Append(PreferredPrefix).Append(":ArrivalTime>");
			}
			if(FareBasisCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":FareBasisCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.FareBasisCode));
				sb.Append("</").Append(PreferredPrefix).Append(":FareBasisCode>");
			}
			if(Fare != null)
			{
				sb.Append(Fare.ToXMLString(PreferredPrefix,"Fare"));
			}
			if(Taxes != null)
			{
				sb.Append(Taxes.ToXMLString(PreferredPrefix,"Taxes"));
			}
			if(Fee != null)
			{
				sb.Append(Fee.ToXMLString(PreferredPrefix,"Fee"));
			}
			if(EndorsementOrRestrictions != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":EndorsementOrRestrictions>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.EndorsementOrRestrictions));
				sb.Append("</").Append(PreferredPrefix).Append(":EndorsementOrRestrictions>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Authorization details 
      */
	public partial class AuthorizationInfoType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private PaymentStatusCodeType? paymentStatusField;
		public PaymentStatusCodeType? PaymentStatus
		{
			get
			{
				return this.paymentStatusField;
			}
			set
			{
				this.paymentStatusField = value;
			}
		}
		

		/**
          *
		  */
		private PendingStatusCodeType? pendingReasonField;
		public PendingStatusCodeType? PendingReason
		{
			get
			{
				return this.pendingReasonField;
			}
			set
			{
				this.pendingReasonField = value;
			}
		}
		

		/**
          *
		  */
		private string protectionEligibilityField;
		public string ProtectionEligibility
		{
			get
			{
				return this.protectionEligibilityField;
			}
			set
			{
				this.protectionEligibilityField = value;
			}
		}
		

		/**
          *
		  */
		private string protectionEligibilityTypeField;
		public string ProtectionEligibilityType
		{
			get
			{
				return this.protectionEligibilityTypeField;
			}
			set
			{
				this.protectionEligibilityTypeField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public AuthorizationInfoType()
	 	{
		}


		public AuthorizationInfoType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentStatus = (PaymentStatusCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(PaymentStatusCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PendingReason']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PendingReason = (PendingStatusCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(PendingStatusCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ProtectionEligibility']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ProtectionEligibility = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ProtectionEligibilityType']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ProtectionEligibilityType = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Option Number. Optional 
      */
	public partial class OptionTrackingDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string optionNumberField;
		public string OptionNumber
		{
			get
			{
				return this.optionNumberField;
			}
			set
			{
				this.optionNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string optionQtyField;
		public string OptionQty
		{
			get
			{
				return this.optionQtyField;
			}
			set
			{
				this.optionQtyField = value;
			}
		}
		

		/**
          *
		  */
		private string optionSelectField;
		public string OptionSelect
		{
			get
			{
				return this.optionSelectField;
			}
			set
			{
				this.optionSelectField = value;
			}
		}
		

		/**
          *
		  */
		private string optionQtyDeltaField;
		public string OptionQtyDelta
		{
			get
			{
				return this.optionQtyDeltaField;
			}
			set
			{
				this.optionQtyDeltaField = value;
			}
		}
		

		/**
          *
		  */
		private string optionAlertField;
		public string OptionAlert
		{
			get
			{
				return this.optionAlertField;
			}
			set
			{
				this.optionAlertField = value;
			}
		}
		

		/**
          *
		  */
		private string optionCostField;
		public string OptionCost
		{
			get
			{
				return this.optionCostField;
			}
			set
			{
				this.optionCostField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public OptionTrackingDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(OptionNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OptionNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OptionNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":OptionNumber>");
			}
			if(OptionQty != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OptionQty>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OptionQty));
				sb.Append("</").Append(PreferredPrefix).Append(":OptionQty>");
			}
			if(OptionSelect != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OptionSelect>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OptionSelect));
				sb.Append("</").Append(PreferredPrefix).Append(":OptionSelect>");
			}
			if(OptionQtyDelta != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OptionQtyDelta>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OptionQtyDelta));
				sb.Append("</").Append(PreferredPrefix).Append(":OptionQtyDelta>");
			}
			if(OptionAlert != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OptionAlert>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OptionAlert));
				sb.Append("</").Append(PreferredPrefix).Append(":OptionAlert>");
			}
			if(OptionCost != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OptionCost>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OptionCost));
				sb.Append("</").Append(PreferredPrefix).Append(":OptionCost>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public OptionTrackingDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OptionNumber']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OptionNumber = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OptionQty']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OptionQty = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OptionSelect']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OptionSelect = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OptionQtyDelta']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OptionQtyDelta = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OptionAlert']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OptionAlert = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OptionCost']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OptionCost = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Item Number. Required 
      */
	public partial class ItemTrackingDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string itemNumberField;
		public string ItemNumber
		{
			get
			{
				return this.itemNumberField;
			}
			set
			{
				this.itemNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string itemQtyField;
		public string ItemQty
		{
			get
			{
				return this.itemQtyField;
			}
			set
			{
				this.itemQtyField = value;
			}
		}
		

		/**
          *
		  */
		private string itemQtyDeltaField;
		public string ItemQtyDelta
		{
			get
			{
				return this.itemQtyDeltaField;
			}
			set
			{
				this.itemQtyDeltaField = value;
			}
		}
		

		/**
          *
		  */
		private string itemAlertField;
		public string ItemAlert
		{
			get
			{
				return this.itemAlertField;
			}
			set
			{
				this.itemAlertField = value;
			}
		}
		

		/**
          *
		  */
		private string itemCostField;
		public string ItemCost
		{
			get
			{
				return this.itemCostField;
			}
			set
			{
				this.itemCostField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ItemTrackingDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ItemNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ItemNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemNumber>");
			}
			if(ItemQty != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemQty>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ItemQty));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemQty>");
			}
			if(ItemQtyDelta != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemQtyDelta>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ItemQtyDelta));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemQtyDelta>");
			}
			if(ItemAlert != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemAlert>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ItemAlert));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemAlert>");
			}
			if(ItemCost != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemCost>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ItemCost));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemCost>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public ItemTrackingDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemNumber']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemNumber = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemQty']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemQty = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemQtyDelta']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemQtyDelta = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemAlert']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemAlert = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemCost']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemCost = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class ButtonSearchResultType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string hostedButtonIDField;
		public string HostedButtonID
		{
			get
			{
				return this.hostedButtonIDField;
			}
			set
			{
				this.hostedButtonIDField = value;
			}
		}
		

		/**
          *
		  */
		private string buttonTypeField;
		public string ButtonType
		{
			get
			{
				return this.buttonTypeField;
			}
			set
			{
				this.buttonTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string itemNameField;
		public string ItemName
		{
			get
			{
				return this.itemNameField;
			}
			set
			{
				this.itemNameField = value;
			}
		}
		

		/**
          *
		  */
		private string modifyDateField;
		public string ModifyDate
		{
			get
			{
				return this.modifyDateField;
			}
			set
			{
				this.modifyDateField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ButtonSearchResultType()
	 	{
		}


		public ButtonSearchResultType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'HostedButtonID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.HostedButtonID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ButtonType']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ButtonType = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemName = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ModifyDate']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ModifyDate = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Identifier of the transaction to reverse. Required Character
      *length and limitations: 17 single-byte alphanumeric
      *characters 
      */
	public partial class ReverseTransactionRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string transactionIDField;
		public string TransactionID
		{
			get
			{
				return this.transactionIDField;
			}
			set
			{
				this.transactionIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ReverseTransactionRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(TransactionID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TransactionID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TransactionID));
				sb.Append("</").Append(PreferredPrefix).Append(":TransactionID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Unique transaction identifier of the reversal transaction
      *created. Character length and limitations:17 single-byte
      *characters 
      */
	public partial class ReverseTransactionResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string reverseTransactionIDField;
		public string ReverseTransactionID
		{
			get
			{
				return this.reverseTransactionIDField;
			}
			set
			{
				this.reverseTransactionIDField = value;
			}
		}
		

		/**
          *
		  */
		private string statusField;
		public string Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ReverseTransactionResponseDetailsType()
	 	{
		}


		public ReverseTransactionResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ReverseTransactionID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ReverseTransactionID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Status']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Status = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Details of incentive application on individual bucket. 
      */
	public partial class IncentiveInfoType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string incentiveCodeField;
		public string IncentiveCode
		{
			get
			{
				return this.incentiveCodeField;
			}
			set
			{
				this.incentiveCodeField = value;
			}
		}
		

		/**
          *
		  */
		private List<IncentiveApplyIndicationType> applyIndicationField = new List<IncentiveApplyIndicationType>();
		public List<IncentiveApplyIndicationType> ApplyIndication
		{
			get
			{
				return this.applyIndicationField;
			}
			set
			{
				this.applyIndicationField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public IncentiveInfoType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(IncentiveCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":IncentiveCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.IncentiveCode));
				sb.Append("</").Append(PreferredPrefix).Append(":IncentiveCode>");
			}
			if(ApplyIndication != null)
			{
				for(int i = 0; i < ApplyIndication.Count; i++)
				{
					sb.Append(ApplyIndication[i].ToXMLString(PreferredPrefix,"ApplyIndication"));
				}
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Defines which bucket or item that the incentive should be
      *applied to. 
      */
	public partial class IncentiveApplyIndicationType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string paymentRequestIDField;
		public string PaymentRequestID
		{
			get
			{
				return this.paymentRequestIDField;
			}
			set
			{
				this.paymentRequestIDField = value;
			}
		}
		

		/**
          *
		  */
		private string itemIdField;
		public string ItemId
		{
			get
			{
				return this.itemIdField;
			}
			set
			{
				this.itemIdField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public IncentiveApplyIndicationType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(PaymentRequestID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PaymentRequestID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PaymentRequestID));
				sb.Append("</").Append(PreferredPrefix).Append(":PaymentRequestID>");
			}
			if(ItemId != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemId>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ItemId));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemId>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Contains payment request information for each bucket in the
      *cart.  
      */
	public partial class PaymentRequestInfoType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string transactionIdField;
		public string TransactionId
		{
			get
			{
				return this.transactionIdField;
			}
			set
			{
				this.transactionIdField = value;
			}
		}
		

		/**
          *
		  */
		private string paymentRequestIDField;
		public string PaymentRequestID
		{
			get
			{
				return this.paymentRequestIDField;
			}
			set
			{
				this.paymentRequestIDField = value;
			}
		}
		

		/**
          *
		  */
		private ErrorType paymentErrorField;
		public ErrorType PaymentError
		{
			get
			{
				return this.paymentErrorField;
			}
			set
			{
				this.paymentErrorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PaymentRequestInfoType()
	 	{
		}


		public PaymentRequestInfoType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TransactionId']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TransactionId = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentRequestID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentRequestID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentError']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentError =  new ErrorType(ChildNode);
			}
	
		}
	}




	/**
      *E-mail address or secure merchant account ID of merchant to
      *associate with new external remember-me. 
      */
	public partial class ExternalRememberMeOwnerDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string externalRememberMeOwnerIDTypeField;
		public string ExternalRememberMeOwnerIDType
		{
			get
			{
				return this.externalRememberMeOwnerIDTypeField;
			}
			set
			{
				this.externalRememberMeOwnerIDTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string externalRememberMeOwnerIDField;
		public string ExternalRememberMeOwnerID
		{
			get
			{
				return this.externalRememberMeOwnerIDField;
			}
			set
			{
				this.externalRememberMeOwnerIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ExternalRememberMeOwnerDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ExternalRememberMeOwnerIDType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ExternalRememberMeOwnerIDType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ExternalRememberMeOwnerIDType));
				sb.Append("</").Append(PreferredPrefix).Append(":ExternalRememberMeOwnerIDType>");
			}
			if(ExternalRememberMeOwnerID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ExternalRememberMeOwnerID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ExternalRememberMeOwnerID));
				sb.Append("</").Append(PreferredPrefix).Append(":ExternalRememberMeOwnerID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *This element contains information that allows the merchant
      *to request to opt into external remember me on behalf of the
      *buyer or to request login bypass using external remember me.
      *
      */
	public partial class ExternalRememberMeOptInDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string externalRememberMeOptInField;
		public string ExternalRememberMeOptIn
		{
			get
			{
				return this.externalRememberMeOptInField;
			}
			set
			{
				this.externalRememberMeOptInField = value;
			}
		}
		

		/**
          *
		  */
		private ExternalRememberMeOwnerDetailsType externalRememberMeOwnerDetailsField;
		public ExternalRememberMeOwnerDetailsType ExternalRememberMeOwnerDetails
		{
			get
			{
				return this.externalRememberMeOwnerDetailsField;
			}
			set
			{
				this.externalRememberMeOwnerDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ExternalRememberMeOptInDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ExternalRememberMeOptIn != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ExternalRememberMeOptIn>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ExternalRememberMeOptIn));
				sb.Append("</").Append(PreferredPrefix).Append(":ExternalRememberMeOptIn>");
			}
			if(ExternalRememberMeOwnerDetails != null)
			{
				sb.Append(ExternalRememberMeOwnerDetails.ToXMLString(PreferredPrefix,"ExternalRememberMeOwnerDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *An optional set of values related to flow-specific details. 
      */
	public partial class FlowControlDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string errorURLField;
		public string ErrorURL
		{
			get
			{
				return this.errorURLField;
			}
			set
			{
				this.errorURLField = value;
			}
		}
		

		/**
          *
		  */
		private string inContextReturnURLField;
		public string InContextReturnURL
		{
			get
			{
				return this.inContextReturnURLField;
			}
			set
			{
				this.inContextReturnURLField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public FlowControlDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ErrorURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ErrorURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ErrorURL));
				sb.Append("</").Append(PreferredPrefix).Append(":ErrorURL>");
			}
			if(InContextReturnURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":InContextReturnURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.InContextReturnURL));
				sb.Append("</").Append(PreferredPrefix).Append(":InContextReturnURL>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Response information resulting from opt-in operation or
      *current login bypass status. 
      */
	public partial class ExternalRememberMeStatusDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private int? externalRememberMeStatusField;
		public int? ExternalRememberMeStatus
		{
			get
			{
				return this.externalRememberMeStatusField;
			}
			set
			{
				this.externalRememberMeStatusField = value;
			}
		}
		

		/**
          *
		  */
		private string externalRememberMeIDField;
		public string ExternalRememberMeID
		{
			get
			{
				return this.externalRememberMeIDField;
			}
			set
			{
				this.externalRememberMeIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ExternalRememberMeStatusDetailsType()
	 	{
		}


		public ExternalRememberMeStatusDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ExternalRememberMeStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ExternalRememberMeStatus = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ExternalRememberMeID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ExternalRememberMeID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Response information resulting from opt-in operation or
      *current login bypass status. 
      */
	public partial class RefreshTokenStatusDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private int? refreshTokenStatusField;
		public int? RefreshTokenStatus
		{
			get
			{
				return this.refreshTokenStatusField;
			}
			set
			{
				this.refreshTokenStatusField = value;
			}
		}
		

		/**
          *
		  */
		private string refreshTokenField;
		public string RefreshToken
		{
			get
			{
				return this.refreshTokenField;
			}
			set
			{
				this.refreshTokenField = value;
			}
		}
		

		/**
          *
		  */
		private string immutableIDField;
		public string ImmutableID
		{
			get
			{
				return this.immutableIDField;
			}
			set
			{
				this.immutableIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public RefreshTokenStatusDetailsType()
	 	{
		}


		public RefreshTokenStatusDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RefreshTokenStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RefreshTokenStatus = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RefreshToken']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RefreshToken = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ImmutableID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ImmutableID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Contains elements that allows customization of display (user
      *interface) elements. 
      */
	public partial class DisplayControlDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string inContextPaymentButtonImageField;
		public string InContextPaymentButtonImage
		{
			get
			{
				return this.inContextPaymentButtonImageField;
			}
			set
			{
				this.inContextPaymentButtonImageField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DisplayControlDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(InContextPaymentButtonImage != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":InContextPaymentButtonImage>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.InContextPaymentButtonImage));
				sb.Append("</").Append(PreferredPrefix).Append(":InContextPaymentButtonImage>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Contains elements that allow tracking for an external
      *partner. 
      */
	public partial class ExternalPartnerTrackingDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string externalPartnerSegmentIDField;
		public string ExternalPartnerSegmentID
		{
			get
			{
				return this.externalPartnerSegmentIDField;
			}
			set
			{
				this.externalPartnerSegmentIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ExternalPartnerTrackingDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ExternalPartnerSegmentID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ExternalPartnerSegmentID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ExternalPartnerSegmentID));
				sb.Append("</").Append(PreferredPrefix).Append(":ExternalPartnerSegmentID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Store IDOptional Character length and limits: 50 single-byte
      *characters 
      */
	public partial class MerchantStoreDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string storeIDField;
		public string StoreID
		{
			get
			{
				return this.storeIDField;
			}
			set
			{
				this.storeIDField = value;
			}
		}
		

		/**
          *
		  */
		private string terminalIDField;
		public string TerminalID
		{
			get
			{
				return this.terminalIDField;
			}
			set
			{
				this.terminalIDField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public MerchantStoreDetailsType(string storeID)
	 	{
			this.StoreID = storeID;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public MerchantStoreDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(StoreID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":StoreID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.StoreID));
				sb.Append("</").Append(PreferredPrefix).Append(":StoreID>");
			}
			if(TerminalID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TerminalID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TerminalID));
				sb.Append("</").Append(PreferredPrefix).Append(":TerminalID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class AdditionalFeeType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string typeField;
		public string Type
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
		

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public AdditionalFeeType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Type != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Type>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Type));
				sb.Append("</").Append(PreferredPrefix).Append(":Type>");
			}
			if(Amount != null)
			{
				sb.Append(Amount.ToXMLString(PreferredPrefix,"Amount"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public AdditionalFeeType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Type']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Type = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Amount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Amount =  new BasicAmountType(ChildNode);
			}
	
		}
	}




	/**
      *Describes discount information 
      */
	public partial class DiscountType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string nameField;
		public string Name
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
		

		/**
          *
		  */
		private string descriptionField;
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private RedeemedOfferType? redeemedOfferTypeField;
		public RedeemedOfferType? RedeemedOfferType
		{
			get
			{
				return this.redeemedOfferTypeField;
			}
			set
			{
				this.redeemedOfferTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string redeemedOfferIDField;
		public string RedeemedOfferID
		{
			get
			{
				return this.redeemedOfferIDField;
			}
			set
			{
				this.redeemedOfferIDField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public DiscountType(BasicAmountType amount)
	 	{
			this.Amount = amount;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public DiscountType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Name != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Name>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Name));
				sb.Append("</").Append(PreferredPrefix).Append(":Name>");
			}
			if(Description != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Description>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Description));
				sb.Append("</").Append(PreferredPrefix).Append(":Description>");
			}
			if(Amount != null)
			{
				sb.Append(Amount.ToXMLString(PreferredPrefix,"Amount"));
			}
			if(RedeemedOfferType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":RedeemedOfferType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.RedeemedOfferType)));
				sb.Append("</").Append(PreferredPrefix).Append(":RedeemedOfferType>");
			}
			if(RedeemedOfferID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":RedeemedOfferID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.RedeemedOfferID));
				sb.Append("</").Append(PreferredPrefix).Append(":RedeemedOfferID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public DiscountType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Name']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Name = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Description']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Description = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Amount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Amount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RedeemedOfferType']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RedeemedOfferType = (RedeemedOfferType)EnumUtils.GetValue(ChildNode.InnerText,typeof(RedeemedOfferType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RedeemedOfferID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RedeemedOfferID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Describes an individual item for an invoice. 
      */
	public partial class InvoiceItemType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string nameField;
		public string Name
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
		

		/**
          *
		  */
		private string descriptionField;
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		

		/**
          *
		  */
		private string eANField;
		public string EAN
		{
			get
			{
				return this.eANField;
			}
			set
			{
				this.eANField = value;
			}
		}
		

		/**
          *
		  */
		private string sKUField;
		public string SKU
		{
			get
			{
				return this.sKUField;
			}
			set
			{
				this.sKUField = value;
			}
		}
		

		/**
          *
		  */
		private string returnPolicyIdentifierField;
		public string ReturnPolicyIdentifier
		{
			get
			{
				return this.returnPolicyIdentifierField;
			}
			set
			{
				this.returnPolicyIdentifierField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType priceField;
		public BasicAmountType Price
		{
			get
			{
				return this.priceField;
			}
			set
			{
				this.priceField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType itemPriceField;
		public BasicAmountType ItemPrice
		{
			get
			{
				return this.itemPriceField;
			}
			set
			{
				this.itemPriceField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? itemCountField;
		public decimal? ItemCount
		{
			get
			{
				return this.itemCountField;
			}
			set
			{
				this.itemCountField = value;
			}
		}
		

		/**
          *
		  */
		private UnitOfMeasure? itemCountUnitField;
		public UnitOfMeasure? ItemCountUnit
		{
			get
			{
				return this.itemCountUnitField;
			}
			set
			{
				this.itemCountUnitField = value;
			}
		}
		

		/**
          *
		  */
		private List<DiscountType> discountField = new List<DiscountType>();
		public List<DiscountType> Discount
		{
			get
			{
				return this.discountField;
			}
			set
			{
				this.discountField = value;
			}
		}
		

		/**
          *
		  */
		private bool? taxableField;
		public bool? Taxable
		{
			get
			{
				return this.taxableField;
			}
			set
			{
				this.taxableField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? taxRateField;
		public decimal? TaxRate
		{
			get
			{
				return this.taxRateField;
			}
			set
			{
				this.taxRateField = value;
			}
		}
		

		/**
          *
		  */
		private List<AdditionalFeeType> additionalFeesField = new List<AdditionalFeeType>();
		public List<AdditionalFeeType> AdditionalFees
		{
			get
			{
				return this.additionalFeesField;
			}
			set
			{
				this.additionalFeesField = value;
			}
		}
		

		/**
          *
		  */
		private bool? reimbursableField;
		public bool? Reimbursable
		{
			get
			{
				return this.reimbursableField;
			}
			set
			{
				this.reimbursableField = value;
			}
		}
		

		/**
          *
		  */
		private string mPNField;
		public string MPN
		{
			get
			{
				return this.mPNField;
			}
			set
			{
				this.mPNField = value;
			}
		}
		

		/**
          *
		  */
		private string iSBNField;
		public string ISBN
		{
			get
			{
				return this.iSBNField;
			}
			set
			{
				this.iSBNField = value;
			}
		}
		

		/**
          *
		  */
		private string pLUField;
		public string PLU
		{
			get
			{
				return this.pLUField;
			}
			set
			{
				this.pLUField = value;
			}
		}
		

		/**
          *
		  */
		private string modelNumberField;
		public string ModelNumber
		{
			get
			{
				return this.modelNumberField;
			}
			set
			{
				this.modelNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string styleNumberField;
		public string StyleNumber
		{
			get
			{
				return this.styleNumberField;
			}
			set
			{
				this.styleNumberField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public InvoiceItemType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(Name != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Name>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Name));
				sb.Append("</").Append(PreferredPrefix).Append(":Name>");
			}
			if(Description != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Description>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Description));
				sb.Append("</").Append(PreferredPrefix).Append(":Description>");
			}
			if(EAN != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":EAN>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.EAN));
				sb.Append("</").Append(PreferredPrefix).Append(":EAN>");
			}
			if(SKU != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SKU>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SKU));
				sb.Append("</").Append(PreferredPrefix).Append(":SKU>");
			}
			if(ReturnPolicyIdentifier != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReturnPolicyIdentifier>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReturnPolicyIdentifier));
				sb.Append("</").Append(PreferredPrefix).Append(":ReturnPolicyIdentifier>");
			}
			if(Price != null)
			{
				sb.Append(Price.ToXMLString(PreferredPrefix,"Price"));
			}
			if(ItemPrice != null)
			{
				sb.Append(ItemPrice.ToXMLString(PreferredPrefix,"ItemPrice"));
			}
			if(ItemCount != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemCount>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(Convert.ToString(this.ItemCount, DefaultCulture)));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemCount>");
			}
			if(ItemCountUnit != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ItemCountUnit>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ItemCountUnit)));
				sb.Append("</").Append(PreferredPrefix).Append(":ItemCountUnit>");
			}
			if(Discount != null)
			{
				for(int i = 0; i < Discount.Count; i++)
				{
					sb.Append(Discount[i].ToXMLString(PreferredPrefix,"Discount"));
				}
			}
			if(Taxable != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Taxable>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Taxable.ToString().ToLower()));
				sb.Append("</").Append(PreferredPrefix).Append(":Taxable>");
			}
			if(TaxRate != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TaxRate>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(Convert.ToString(this.TaxRate, DefaultCulture)));
				sb.Append("</").Append(PreferredPrefix).Append(":TaxRate>");
			}
			if(AdditionalFees != null)
			{
				for(int i = 0; i < AdditionalFees.Count; i++)
				{
					sb.Append(AdditionalFees[i].ToXMLString(PreferredPrefix,"AdditionalFees"));
				}
			}
			if(Reimbursable != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Reimbursable>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Reimbursable.ToString().ToLower()));
				sb.Append("</").Append(PreferredPrefix).Append(":Reimbursable>");
			}
			if(MPN != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MPN>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.MPN));
				sb.Append("</").Append(PreferredPrefix).Append(":MPN>");
			}
			if(ISBN != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ISBN>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ISBN));
				sb.Append("</").Append(PreferredPrefix).Append(":ISBN>");
			}
			if(PLU != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PLU>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PLU));
				sb.Append("</").Append(PreferredPrefix).Append(":PLU>");
			}
			if(ModelNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ModelNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ModelNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":ModelNumber>");
			}
			if(StyleNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":StyleNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.StyleNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":StyleNumber>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public InvoiceItemType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Name']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Name = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Description']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Description = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'EAN']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.EAN = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SKU']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SKU = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ReturnPolicyIdentifier']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ReturnPolicyIdentifier = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Price']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Price =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemPrice']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemPrice =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemCount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemCount = System.Convert.ToDecimal(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemCountUnit']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemCountUnit = (UnitOfMeasure)EnumUtils.GetValue(ChildNode.InnerText,typeof(UnitOfMeasure));
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'Discount']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.Discount.Add(new DiscountType(subNode));
				}
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Taxable']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Taxable = System.Convert.ToBoolean(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TaxRate']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TaxRate = System.Convert.ToDecimal(ChildNode.InnerText);
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'AdditionalFees']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.AdditionalFees.Add(new AdditionalFeeType(subNode));
				}
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Reimbursable']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Reimbursable = System.Convert.ToBoolean(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'MPN']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.MPN = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ISBN']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ISBN = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PLU']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PLU = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ModelNumber']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ModelNumber = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'StyleNumber']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.StyleNumber = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Holds refunds payment status information 
      */
	public partial class RefundInfoType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private PaymentStatusCodeType? refundStatusField;
		public PaymentStatusCodeType? RefundStatus
		{
			get
			{
				return this.refundStatusField;
			}
			set
			{
				this.refundStatusField = value;
			}
		}
		

		/**
          *
		  */
		private PendingStatusCodeType? pendingReasonField;
		public PendingStatusCodeType? PendingReason
		{
			get
			{
				return this.pendingReasonField;
			}
			set
			{
				this.pendingReasonField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public RefundInfoType()
	 	{
		}


		public RefundInfoType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RefundStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RefundStatus = (PaymentStatusCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(PaymentStatusCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PendingReason']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PendingReason = (PendingStatusCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(PendingStatusCodeType));
			}
	
		}
	}




	/**
      *Defines relationship between buckets 
      */
	public partial class CoupledBucketsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:eBLBaseComponents";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ebl";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private CoupleType? coupleTypeField;
		public CoupleType? CoupleType
		{
			get
			{
				return this.coupleTypeField;
			}
			set
			{
				this.coupleTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string coupledPaymentRequestIDField;
		public string CoupledPaymentRequestID
		{
			get
			{
				return this.coupledPaymentRequestIDField;
			}
			set
			{
				this.coupledPaymentRequestIDField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> paymentRequestIDField = new List<string>();
		public List<string> PaymentRequestID
		{
			get
			{
				return this.paymentRequestIDField;
			}
			set
			{
				this.paymentRequestIDField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public CoupledBucketsType(List<string> paymentRequestID)
	 	{
			this.PaymentRequestID = paymentRequestID;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public CoupledBucketsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(CoupleType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CoupleType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.CoupleType)));
				sb.Append("</").Append(PreferredPrefix).Append(":CoupleType>");
			}
			if(CoupledPaymentRequestID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CoupledPaymentRequestID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CoupledPaymentRequestID));
				sb.Append("</").Append(PreferredPrefix).Append(":CoupledPaymentRequestID>");
			}
			if(PaymentRequestID != null)
			{
				for(int i = 0; i < PaymentRequestID.Count; i++)
				{
					sb.Append("<").Append(PreferredPrefix).Append(":PaymentRequestID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PaymentRequestID[i]));
					sb.Append("</").Append(PreferredPrefix).Append(":PaymentRequestID>");
				}
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Information about Coupled Payment transactions. 
      */
	public partial class CoupledPaymentInfoType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string coupledPaymentRequestIDField;
		public string CoupledPaymentRequestID
		{
			get
			{
				return this.coupledPaymentRequestIDField;
			}
			set
			{
				this.coupledPaymentRequestIDField = value;
			}
		}
		

		/**
          *
		  */
		private string coupledPaymentIDField;
		public string CoupledPaymentID
		{
			get
			{
				return this.coupledPaymentIDField;
			}
			set
			{
				this.coupledPaymentIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CoupledPaymentInfoType()
	 	{
		}


		public CoupledPaymentInfoType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CoupledPaymentRequestID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CoupledPaymentRequestID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CoupledPaymentID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CoupledPaymentID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class EnhancedCheckoutDataType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:EnhancedDataTypes";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ed";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public EnhancedCheckoutDataType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class EnhancedPaymentDataType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:EnhancedDataTypes";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ed";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public EnhancedPaymentDataType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public EnhancedPaymentDataType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
	
		}
	}




	/**
      *
      */
	public partial class EnhancedItemDataType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:EnhancedDataTypes";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ed";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public EnhancedItemDataType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public EnhancedItemDataType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
	
		}
	}




	/**
      *
      */
	public partial class EnhancedPaymentInfoType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public EnhancedPaymentInfoType()
	 	{
		}


		public EnhancedPaymentInfoType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
	
		}
	}




	/**
      *
      */
	public partial class EnhancedInitiateRecoupRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:EnhancedDataTypes";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ed";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public EnhancedInitiateRecoupRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class EnhancedCompleteRecoupRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:EnhancedDataTypes";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ed";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public EnhancedCompleteRecoupRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class EnhancedCompleteRecoupResponseDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public EnhancedCompleteRecoupResponseDetailsType()
	 	{
		}


		public EnhancedCompleteRecoupResponseDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
	
		}
	}




	/**
      *
      */
	public partial class EnhancedCancelRecoupRequestDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:EnhancedDataTypes";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ed";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public EnhancedCancelRecoupRequestDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class EnhancedPayerInfoType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:apis:EnhancedDataTypes";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ed";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public EnhancedPayerInfoType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public EnhancedPayerInfoType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
	
		}
	}




	/**
      *Installment Period. Optional 
      */
	public partial class InstallmentDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BillingPeriodType? billingPeriodField;
		public BillingPeriodType? BillingPeriod
		{
			get
			{
				return this.billingPeriodField;
			}
			set
			{
				this.billingPeriodField = value;
			}
		}
		

		/**
          *
		  */
		private int? billingFrequencyField;
		public int? BillingFrequency
		{
			get
			{
				return this.billingFrequencyField;
			}
			set
			{
				this.billingFrequencyField = value;
			}
		}
		

		/**
          *
		  */
		private int? totalBillingCyclesField;
		public int? TotalBillingCycles
		{
			get
			{
				return this.totalBillingCyclesField;
			}
			set
			{
				this.totalBillingCyclesField = value;
			}
		}
		

		/**
          *
		  */
		private string amountField;
		public string Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private string shippingAmountField;
		public string ShippingAmount
		{
			get
			{
				return this.shippingAmountField;
			}
			set
			{
				this.shippingAmountField = value;
			}
		}
		

		/**
          *
		  */
		private string taxAmountField;
		public string TaxAmount
		{
			get
			{
				return this.taxAmountField;
			}
			set
			{
				this.taxAmountField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public InstallmentDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BillingPeriod != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BillingPeriod>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.BillingPeriod)));
				sb.Append("</").Append(PreferredPrefix).Append(":BillingPeriod>");
			}
			if(BillingFrequency != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BillingFrequency>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BillingFrequency));
				sb.Append("</").Append(PreferredPrefix).Append(":BillingFrequency>");
			}
			if(TotalBillingCycles != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TotalBillingCycles>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TotalBillingCycles));
				sb.Append("</").Append(PreferredPrefix).Append(":TotalBillingCycles>");
			}
			if(Amount != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Amount>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Amount));
				sb.Append("</").Append(PreferredPrefix).Append(":Amount>");
			}
			if(ShippingAmount != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ShippingAmount>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ShippingAmount));
				sb.Append("</").Append(PreferredPrefix).Append(":ShippingAmount>");
			}
			if(TaxAmount != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TaxAmount>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TaxAmount));
				sb.Append("</").Append(PreferredPrefix).Append(":TaxAmount>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public InstallmentDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillingPeriod']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillingPeriod = (BillingPeriodType)EnumUtils.GetValue(ChildNode.InnerText,typeof(BillingPeriodType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillingFrequency']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillingFrequency = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TotalBillingCycles']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TotalBillingCycles = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Amount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Amount = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ShippingAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ShippingAmount = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TaxAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TaxAmount = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *Option Selection. Required Character length and limitations:
      *12 single-byte alphanumeric characters 
      */
	public partial class OptionSelectionDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string optionSelectionField;
		public string OptionSelection
		{
			get
			{
				return this.optionSelectionField;
			}
			set
			{
				this.optionSelectionField = value;
			}
		}
		

		/**
          *
		  */
		private string priceField;
		public string Price
		{
			get
			{
				return this.priceField;
			}
			set
			{
				this.priceField = value;
			}
		}
		

		/**
          *
		  */
		private OptionTypeListType? optionTypeField;
		public OptionTypeListType? OptionType
		{
			get
			{
				return this.optionTypeField;
			}
			set
			{
				this.optionTypeField = value;
			}
		}
		

		/**
          *
		  */
		private List<InstallmentDetailsType> paymentPeriodField = new List<InstallmentDetailsType>();
		public List<InstallmentDetailsType> PaymentPeriod
		{
			get
			{
				return this.paymentPeriodField;
			}
			set
			{
				this.paymentPeriodField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public OptionSelectionDetailsType(string optionSelection)
	 	{
			this.OptionSelection = optionSelection;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public OptionSelectionDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(OptionSelection != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OptionSelection>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OptionSelection));
				sb.Append("</").Append(PreferredPrefix).Append(":OptionSelection>");
			}
			if(Price != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Price>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Price));
				sb.Append("</").Append(PreferredPrefix).Append(":Price>");
			}
			if(OptionType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OptionType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.OptionType)));
				sb.Append("</").Append(PreferredPrefix).Append(":OptionType>");
			}
			if(PaymentPeriod != null)
			{
				for(int i = 0; i < PaymentPeriod.Count; i++)
				{
					sb.Append(PaymentPeriod[i].ToXMLString(PreferredPrefix,"PaymentPeriod"));
				}
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public OptionSelectionDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OptionSelection']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OptionSelection = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Price']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Price = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OptionType']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OptionType = (OptionTypeListType)EnumUtils.GetValue(ChildNode.InnerText,typeof(OptionTypeListType));
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'PaymentPeriod']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.PaymentPeriod.Add(new InstallmentDetailsType(subNode));
				}
			}
	
		}
	}




	/**
      *Option Name. Optional 
      */
	public partial class OptionDetailsType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string optionNameField;
		public string OptionName
		{
			get
			{
				return this.optionNameField;
			}
			set
			{
				this.optionNameField = value;
			}
		}
		

		/**
          *
		  */
		private List<OptionSelectionDetailsType> optionSelectionDetailsField = new List<OptionSelectionDetailsType>();
		public List<OptionSelectionDetailsType> OptionSelectionDetails
		{
			get
			{
				return this.optionSelectionDetailsField;
			}
			set
			{
				this.optionSelectionDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public OptionDetailsType(string optionName)
	 	{
			this.OptionName = optionName;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public OptionDetailsType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(OptionName != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OptionName>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OptionName));
				sb.Append("</").Append(PreferredPrefix).Append(":OptionName>");
			}
			if(OptionSelectionDetails != null)
			{
				for(int i = 0; i < OptionSelectionDetails.Count; i++)
				{
					sb.Append(OptionSelectionDetails[i].ToXMLString(PreferredPrefix,"OptionSelectionDetails"));
				}
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

		public OptionDetailsType(XmlNode xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OptionName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OptionName = ChildNode.InnerText;
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'OptionSelectionDetails']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.OptionSelectionDetails.Add(new OptionSelectionDetailsType(subNode));
				}
			}
	
		}
	}




	/**
      *
      */
	public partial class BMCreateButtonReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BMCreateButtonRequestType bMCreateButtonRequestField;
		public BMCreateButtonRequestType BMCreateButtonRequest
		{
			get
			{
				return this.bMCreateButtonRequestField;
			}
			set
			{
				this.bMCreateButtonRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BMCreateButtonReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BMCreateButtonRequest != null)
			{
				sb.Append(BMCreateButtonRequest.ToXMLString(null,"BMCreateButtonRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Type of Button to create.  Required Must be one of the
      *following: BUYNOW, CART, GIFTCERTIFICATE. SUBSCRIBE,
      *PAYMENTPLAN, AUTOBILLING, DONATE, VIEWCART or UNSUBSCRIBE  
      */
	public partial class BMCreateButtonRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private ButtonTypeType? buttonTypeField;
		public ButtonTypeType? ButtonType
		{
			get
			{
				return this.buttonTypeField;
			}
			set
			{
				this.buttonTypeField = value;
			}
		}
		

		/**
          *
		  */
		private ButtonCodeType? buttonCodeField;
		public ButtonCodeType? ButtonCode
		{
			get
			{
				return this.buttonCodeField;
			}
			set
			{
				this.buttonCodeField = value;
			}
		}
		

		/**
          *
		  */
		private ButtonSubTypeType? buttonSubTypeField;
		public ButtonSubTypeType? ButtonSubType
		{
			get
			{
				return this.buttonSubTypeField;
			}
			set
			{
				this.buttonSubTypeField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> buttonVarField = new List<string>();
		public List<string> ButtonVar
		{
			get
			{
				return this.buttonVarField;
			}
			set
			{
				this.buttonVarField = value;
			}
		}
		

		/**
          *
		  */
		private List<OptionDetailsType> optionDetailsField = new List<OptionDetailsType>();
		public List<OptionDetailsType> OptionDetails
		{
			get
			{
				return this.optionDetailsField;
			}
			set
			{
				this.optionDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> textBoxField = new List<string>();
		public List<string> TextBox
		{
			get
			{
				return this.textBoxField;
			}
			set
			{
				this.textBoxField = value;
			}
		}
		

		/**
          *
		  */
		private ButtonImageType? buttonImageField;
		public ButtonImageType? ButtonImage
		{
			get
			{
				return this.buttonImageField;
			}
			set
			{
				this.buttonImageField = value;
			}
		}
		

		/**
          *
		  */
		private string buttonImageURLField;
		public string ButtonImageURL
		{
			get
			{
				return this.buttonImageURLField;
			}
			set
			{
				this.buttonImageURLField = value;
			}
		}
		

		/**
          *
		  */
		private BuyNowTextType? buyNowTextField;
		public BuyNowTextType? BuyNowText
		{
			get
			{
				return this.buyNowTextField;
			}
			set
			{
				this.buyNowTextField = value;
			}
		}
		

		/**
          *
		  */
		private SubscribeTextType? subscribeTextField;
		public SubscribeTextType? SubscribeText
		{
			get
			{
				return this.subscribeTextField;
			}
			set
			{
				this.subscribeTextField = value;
			}
		}
		

		/**
          *
		  */
		private CountryCodeType? buttonCountryField;
		public CountryCodeType? ButtonCountry
		{
			get
			{
				return this.buttonCountryField;
			}
			set
			{
				this.buttonCountryField = value;
			}
		}
		

		/**
          *
		  */
		private string buttonLanguageField;
		public string ButtonLanguage
		{
			get
			{
				return this.buttonLanguageField;
			}
			set
			{
				this.buttonLanguageField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BMCreateButtonRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(ButtonType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ButtonType)));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonType>");
			}
			if(ButtonCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ButtonCode)));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonCode>");
			}
			if(ButtonSubType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonSubType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ButtonSubType)));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonSubType>");
			}
			if(ButtonVar != null)
			{
				for(int i = 0; i < ButtonVar.Count; i++)
				{
					sb.Append("<").Append(PreferredPrefix).Append(":ButtonVar>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ButtonVar[i]));
					sb.Append("</").Append(PreferredPrefix).Append(":ButtonVar>");
				}
			}
			if(OptionDetails != null)
			{
				for(int i = 0; i < OptionDetails.Count; i++)
				{
					sb.Append(OptionDetails[i].ToXMLString(PreferredPrefix,"OptionDetails"));
				}
			}
			if(TextBox != null)
			{
				for(int i = 0; i < TextBox.Count; i++)
				{
					sb.Append("<").Append(PreferredPrefix).Append(":TextBox>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TextBox[i]));
					sb.Append("</").Append(PreferredPrefix).Append(":TextBox>");
				}
			}
			if(ButtonImage != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonImage>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ButtonImage)));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonImage>");
			}
			if(ButtonImageURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonImageURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ButtonImageURL));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonImageURL>");
			}
			if(BuyNowText != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BuyNowText>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.BuyNowText)));
				sb.Append("</").Append(PreferredPrefix).Append(":BuyNowText>");
			}
			if(SubscribeText != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SubscribeText>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.SubscribeText)));
				sb.Append("</").Append(PreferredPrefix).Append(":SubscribeText>");
			}
			if(ButtonCountry != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonCountry>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ButtonCountry)));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonCountry>");
			}
			if(ButtonLanguage != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonLanguage>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ButtonLanguage));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonLanguage>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class BMCreateButtonResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string websiteField;
		public string Website
		{
			get
			{
				return this.websiteField;
			}
			set
			{
				this.websiteField = value;
			}
		}
		

		/**
          *
		  */
		private string emailField;
		public string Email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
			}
		}
		

		/**
          *
		  */
		private string mobileField;
		public string Mobile
		{
			get
			{
				return this.mobileField;
			}
			set
			{
				this.mobileField = value;
			}
		}
		

		/**
          *
		  */
		private string hostedButtonIDField;
		public string HostedButtonID
		{
			get
			{
				return this.hostedButtonIDField;
			}
			set
			{
				this.hostedButtonIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BMCreateButtonResponseType()
	 	{
		}


		public BMCreateButtonResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Website']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Website = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Email']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Email = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Mobile']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Mobile = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'HostedButtonID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.HostedButtonID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class BMUpdateButtonReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BMUpdateButtonRequestType bMUpdateButtonRequestField;
		public BMUpdateButtonRequestType BMUpdateButtonRequest
		{
			get
			{
				return this.bMUpdateButtonRequestField;
			}
			set
			{
				this.bMUpdateButtonRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BMUpdateButtonReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BMUpdateButtonRequest != null)
			{
				sb.Append(BMUpdateButtonRequest.ToXMLString(null,"BMUpdateButtonRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Hosted Button id of the button to update.  Required
      *Character length and limitations: 10 single-byte numeric
      *characters  
      */
	public partial class BMUpdateButtonRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string hostedButtonIDField;
		public string HostedButtonID
		{
			get
			{
				return this.hostedButtonIDField;
			}
			set
			{
				this.hostedButtonIDField = value;
			}
		}
		

		/**
          *
		  */
		private ButtonTypeType? buttonTypeField;
		public ButtonTypeType? ButtonType
		{
			get
			{
				return this.buttonTypeField;
			}
			set
			{
				this.buttonTypeField = value;
			}
		}
		

		/**
          *
		  */
		private ButtonCodeType? buttonCodeField;
		public ButtonCodeType? ButtonCode
		{
			get
			{
				return this.buttonCodeField;
			}
			set
			{
				this.buttonCodeField = value;
			}
		}
		

		/**
          *
		  */
		private ButtonSubTypeType? buttonSubTypeField;
		public ButtonSubTypeType? ButtonSubType
		{
			get
			{
				return this.buttonSubTypeField;
			}
			set
			{
				this.buttonSubTypeField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> buttonVarField = new List<string>();
		public List<string> ButtonVar
		{
			get
			{
				return this.buttonVarField;
			}
			set
			{
				this.buttonVarField = value;
			}
		}
		

		/**
          *
		  */
		private List<OptionDetailsType> optionDetailsField = new List<OptionDetailsType>();
		public List<OptionDetailsType> OptionDetails
		{
			get
			{
				return this.optionDetailsField;
			}
			set
			{
				this.optionDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> textBoxField = new List<string>();
		public List<string> TextBox
		{
			get
			{
				return this.textBoxField;
			}
			set
			{
				this.textBoxField = value;
			}
		}
		

		/**
          *
		  */
		private ButtonImageType? buttonImageField;
		public ButtonImageType? ButtonImage
		{
			get
			{
				return this.buttonImageField;
			}
			set
			{
				this.buttonImageField = value;
			}
		}
		

		/**
          *
		  */
		private string buttonImageURLField;
		public string ButtonImageURL
		{
			get
			{
				return this.buttonImageURLField;
			}
			set
			{
				this.buttonImageURLField = value;
			}
		}
		

		/**
          *
		  */
		private BuyNowTextType? buyNowTextField;
		public BuyNowTextType? BuyNowText
		{
			get
			{
				return this.buyNowTextField;
			}
			set
			{
				this.buyNowTextField = value;
			}
		}
		

		/**
          *
		  */
		private SubscribeTextType? subscribeTextField;
		public SubscribeTextType? SubscribeText
		{
			get
			{
				return this.subscribeTextField;
			}
			set
			{
				this.subscribeTextField = value;
			}
		}
		

		/**
          *
		  */
		private CountryCodeType? buttonCountryField;
		public CountryCodeType? ButtonCountry
		{
			get
			{
				return this.buttonCountryField;
			}
			set
			{
				this.buttonCountryField = value;
			}
		}
		

		/**
          *
		  */
		private string buttonLanguageField;
		public string ButtonLanguage
		{
			get
			{
				return this.buttonLanguageField;
			}
			set
			{
				this.buttonLanguageField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public BMUpdateButtonRequestType(string hostedButtonID)
	 	{
			this.HostedButtonID = hostedButtonID;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public BMUpdateButtonRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(HostedButtonID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":HostedButtonID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.HostedButtonID));
				sb.Append("</").Append(PreferredPrefix).Append(":HostedButtonID>");
			}
			if(ButtonType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ButtonType)));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonType>");
			}
			if(ButtonCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ButtonCode)));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonCode>");
			}
			if(ButtonSubType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonSubType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ButtonSubType)));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonSubType>");
			}
			if(ButtonVar != null)
			{
				for(int i = 0; i < ButtonVar.Count; i++)
				{
					sb.Append("<").Append(PreferredPrefix).Append(":ButtonVar>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ButtonVar[i]));
					sb.Append("</").Append(PreferredPrefix).Append(":ButtonVar>");
				}
			}
			if(OptionDetails != null)
			{
				for(int i = 0; i < OptionDetails.Count; i++)
				{
					sb.Append(OptionDetails[i].ToXMLString(PreferredPrefix,"OptionDetails"));
				}
			}
			if(TextBox != null)
			{
				for(int i = 0; i < TextBox.Count; i++)
				{
					sb.Append("<").Append(PreferredPrefix).Append(":TextBox>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TextBox[i]));
					sb.Append("</").Append(PreferredPrefix).Append(":TextBox>");
				}
			}
			if(ButtonImage != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonImage>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ButtonImage)));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonImage>");
			}
			if(ButtonImageURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonImageURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ButtonImageURL));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonImageURL>");
			}
			if(BuyNowText != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BuyNowText>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.BuyNowText)));
				sb.Append("</").Append(PreferredPrefix).Append(":BuyNowText>");
			}
			if(SubscribeText != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SubscribeText>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.SubscribeText)));
				sb.Append("</").Append(PreferredPrefix).Append(":SubscribeText>");
			}
			if(ButtonCountry != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonCountry>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ButtonCountry)));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonCountry>");
			}
			if(ButtonLanguage != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonLanguage>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ButtonLanguage));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonLanguage>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class BMUpdateButtonResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string websiteField;
		public string Website
		{
			get
			{
				return this.websiteField;
			}
			set
			{
				this.websiteField = value;
			}
		}
		

		/**
          *
		  */
		private string emailField;
		public string Email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
			}
		}
		

		/**
          *
		  */
		private string mobileField;
		public string Mobile
		{
			get
			{
				return this.mobileField;
			}
			set
			{
				this.mobileField = value;
			}
		}
		

		/**
          *
		  */
		private string hostedButtonIDField;
		public string HostedButtonID
		{
			get
			{
				return this.hostedButtonIDField;
			}
			set
			{
				this.hostedButtonIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BMUpdateButtonResponseType()
	 	{
		}


		public BMUpdateButtonResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Website']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Website = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Email']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Email = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Mobile']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Mobile = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'HostedButtonID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.HostedButtonID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class BMManageButtonStatusReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BMManageButtonStatusRequestType bMManageButtonStatusRequestField;
		public BMManageButtonStatusRequestType BMManageButtonStatusRequest
		{
			get
			{
				return this.bMManageButtonStatusRequestField;
			}
			set
			{
				this.bMManageButtonStatusRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BMManageButtonStatusReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BMManageButtonStatusRequest != null)
			{
				sb.Append(BMManageButtonStatusRequest.ToXMLString(null,"BMManageButtonStatusRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Button ID of Hosted button.  Required Character length and
      *limitations: 10 single-byte numeric characters  
      */
	public partial class BMManageButtonStatusRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string hostedButtonIDField;
		public string HostedButtonID
		{
			get
			{
				return this.hostedButtonIDField;
			}
			set
			{
				this.hostedButtonIDField = value;
			}
		}
		

		/**
          *
		  */
		private ButtonStatusType? buttonStatusField;
		public ButtonStatusType? ButtonStatus
		{
			get
			{
				return this.buttonStatusField;
			}
			set
			{
				this.buttonStatusField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BMManageButtonStatusRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(HostedButtonID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":HostedButtonID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.HostedButtonID));
				sb.Append("</").Append(PreferredPrefix).Append(":HostedButtonID>");
			}
			if(ButtonStatus != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonStatus>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ButtonStatus)));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonStatus>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class BMManageButtonStatusResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public BMManageButtonStatusResponseType()
	 	{
		}


		public BMManageButtonStatusResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
	
		}
	}




	/**
      *
      */
	public partial class BMGetButtonDetailsReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BMGetButtonDetailsRequestType bMGetButtonDetailsRequestField;
		public BMGetButtonDetailsRequestType BMGetButtonDetailsRequest
		{
			get
			{
				return this.bMGetButtonDetailsRequestField;
			}
			set
			{
				this.bMGetButtonDetailsRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BMGetButtonDetailsReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BMGetButtonDetailsRequest != null)
			{
				sb.Append(BMGetButtonDetailsRequest.ToXMLString(null,"BMGetButtonDetailsRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Button ID of button to return.  Required Character length
      *and limitations: 10 single-byte numeric characters  
      */
	public partial class BMGetButtonDetailsRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string hostedButtonIDField;
		public string HostedButtonID
		{
			get
			{
				return this.hostedButtonIDField;
			}
			set
			{
				this.hostedButtonIDField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public BMGetButtonDetailsRequestType(string hostedButtonID)
	 	{
			this.HostedButtonID = hostedButtonID;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public BMGetButtonDetailsRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(HostedButtonID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":HostedButtonID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.HostedButtonID));
				sb.Append("</").Append(PreferredPrefix).Append(":HostedButtonID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Type of button. One of the following: BUYNOW, CART,
      *GIFTCERTIFICATE. SUBSCRIBE, PAYMENTPLAN, AUTOBILLING,
      *DONATE, VIEWCART or UNSUBSCRIBE 
      */
	public partial class BMGetButtonDetailsResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string websiteField;
		public string Website
		{
			get
			{
				return this.websiteField;
			}
			set
			{
				this.websiteField = value;
			}
		}
		

		/**
          *
		  */
		private string emailField;
		public string Email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
			}
		}
		

		/**
          *
		  */
		private string mobileField;
		public string Mobile
		{
			get
			{
				return this.mobileField;
			}
			set
			{
				this.mobileField = value;
			}
		}
		

		/**
          *
		  */
		private string hostedButtonIDField;
		public string HostedButtonID
		{
			get
			{
				return this.hostedButtonIDField;
			}
			set
			{
				this.hostedButtonIDField = value;
			}
		}
		

		/**
          *
		  */
		private ButtonTypeType? buttonTypeField;
		public ButtonTypeType? ButtonType
		{
			get
			{
				return this.buttonTypeField;
			}
			set
			{
				this.buttonTypeField = value;
			}
		}
		

		/**
          *
		  */
		private ButtonCodeType? buttonCodeField;
		public ButtonCodeType? ButtonCode
		{
			get
			{
				return this.buttonCodeField;
			}
			set
			{
				this.buttonCodeField = value;
			}
		}
		

		/**
          *
		  */
		private ButtonSubTypeType? buttonSubTypeField;
		public ButtonSubTypeType? ButtonSubType
		{
			get
			{
				return this.buttonSubTypeField;
			}
			set
			{
				this.buttonSubTypeField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> buttonVarField = new List<string>();
		public List<string> ButtonVar
		{
			get
			{
				return this.buttonVarField;
			}
			set
			{
				this.buttonVarField = value;
			}
		}
		

		/**
          *
		  */
		private List<OptionDetailsType> optionDetailsField = new List<OptionDetailsType>();
		public List<OptionDetailsType> OptionDetails
		{
			get
			{
				return this.optionDetailsField;
			}
			set
			{
				this.optionDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> textBoxField = new List<string>();
		public List<string> TextBox
		{
			get
			{
				return this.textBoxField;
			}
			set
			{
				this.textBoxField = value;
			}
		}
		

		/**
          *
		  */
		private ButtonImageType? buttonImageField;
		public ButtonImageType? ButtonImage
		{
			get
			{
				return this.buttonImageField;
			}
			set
			{
				this.buttonImageField = value;
			}
		}
		

		/**
          *
		  */
		private string buttonImageURLField;
		public string ButtonImageURL
		{
			get
			{
				return this.buttonImageURLField;
			}
			set
			{
				this.buttonImageURLField = value;
			}
		}
		

		/**
          *
		  */
		private BuyNowTextType? buyNowTextField;
		public BuyNowTextType? BuyNowText
		{
			get
			{
				return this.buyNowTextField;
			}
			set
			{
				this.buyNowTextField = value;
			}
		}
		

		/**
          *
		  */
		private SubscribeTextType? subscribeTextField;
		public SubscribeTextType? SubscribeText
		{
			get
			{
				return this.subscribeTextField;
			}
			set
			{
				this.subscribeTextField = value;
			}
		}
		

		/**
          *
		  */
		private CountryCodeType? buttonCountryField;
		public CountryCodeType? ButtonCountry
		{
			get
			{
				return this.buttonCountryField;
			}
			set
			{
				this.buttonCountryField = value;
			}
		}
		

		/**
          *
		  */
		private string buttonLanguageField;
		public string ButtonLanguage
		{
			get
			{
				return this.buttonLanguageField;
			}
			set
			{
				this.buttonLanguageField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BMGetButtonDetailsResponseType()
	 	{
		}


		public BMGetButtonDetailsResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Website']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Website = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Email']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Email = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Mobile']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Mobile = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'HostedButtonID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.HostedButtonID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ButtonType']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ButtonType = (ButtonTypeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(ButtonTypeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ButtonCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ButtonCode = (ButtonCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(ButtonCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ButtonSubType']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ButtonSubType = (ButtonSubTypeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(ButtonSubTypeType));
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'ButtonVar']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					string value = ChildNodeList[i].InnerText;
					this.ButtonVar.Add(value);
				}
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'OptionDetails']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.OptionDetails.Add(new OptionDetailsType(subNode));
				}
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'TextBox']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					string value = ChildNodeList[i].InnerText;
					this.TextBox.Add(value);
				}
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ButtonImage']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ButtonImage = (ButtonImageType)EnumUtils.GetValue(ChildNode.InnerText,typeof(ButtonImageType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ButtonImageURL']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ButtonImageURL = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BuyNowText']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BuyNowText = (BuyNowTextType)EnumUtils.GetValue(ChildNode.InnerText,typeof(BuyNowTextType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SubscribeText']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SubscribeText = (SubscribeTextType)EnumUtils.GetValue(ChildNode.InnerText,typeof(SubscribeTextType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ButtonCountry']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ButtonCountry = (CountryCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(CountryCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ButtonLanguage']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ButtonLanguage = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class BMSetInventoryReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BMSetInventoryRequestType bMSetInventoryRequestField;
		public BMSetInventoryRequestType BMSetInventoryRequest
		{
			get
			{
				return this.bMSetInventoryRequestField;
			}
			set
			{
				this.bMSetInventoryRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BMSetInventoryReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BMSetInventoryRequest != null)
			{
				sb.Append(BMSetInventoryRequest.ToXMLString(null,"BMSetInventoryRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Hosted Button ID of button you wish to change.  Required
      *Character length and limitations: 10 single-byte numeric
      *characters  
      */
	public partial class BMSetInventoryRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string hostedButtonIDField;
		public string HostedButtonID
		{
			get
			{
				return this.hostedButtonIDField;
			}
			set
			{
				this.hostedButtonIDField = value;
			}
		}
		

		/**
          *
		  */
		private string trackInvField;
		public string TrackInv
		{
			get
			{
				return this.trackInvField;
			}
			set
			{
				this.trackInvField = value;
			}
		}
		

		/**
          *
		  */
		private string trackPnlField;
		public string TrackPnl
		{
			get
			{
				return this.trackPnlField;
			}
			set
			{
				this.trackPnlField = value;
			}
		}
		

		/**
          *
		  */
		private ItemTrackingDetailsType itemTrackingDetailsField;
		public ItemTrackingDetailsType ItemTrackingDetails
		{
			get
			{
				return this.itemTrackingDetailsField;
			}
			set
			{
				this.itemTrackingDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string optionIndexField;
		public string OptionIndex
		{
			get
			{
				return this.optionIndexField;
			}
			set
			{
				this.optionIndexField = value;
			}
		}
		

		/**
          *
		  */
		private List<OptionTrackingDetailsType> optionTrackingDetailsField = new List<OptionTrackingDetailsType>();
		public List<OptionTrackingDetailsType> OptionTrackingDetails
		{
			get
			{
				return this.optionTrackingDetailsField;
			}
			set
			{
				this.optionTrackingDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string soldoutURLField;
		public string SoldoutURL
		{
			get
			{
				return this.soldoutURLField;
			}
			set
			{
				this.soldoutURLField = value;
			}
		}
		

		/**
          *
		  */
		private string reuseDigitalDownloadKeysField;
		public string ReuseDigitalDownloadKeys
		{
			get
			{
				return this.reuseDigitalDownloadKeysField;
			}
			set
			{
				this.reuseDigitalDownloadKeysField = value;
			}
		}
		

		/**
          *
		  */
		private string appendDigitalDownloadKeysField;
		public string AppendDigitalDownloadKeys
		{
			get
			{
				return this.appendDigitalDownloadKeysField;
			}
			set
			{
				this.appendDigitalDownloadKeysField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> digitalDownloadKeysField = new List<string>();
		public List<string> DigitalDownloadKeys
		{
			get
			{
				return this.digitalDownloadKeysField;
			}
			set
			{
				this.digitalDownloadKeysField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public BMSetInventoryRequestType(string hostedButtonID, string trackInv, string trackPnl)
	 	{
			this.HostedButtonID = hostedButtonID;
			this.TrackInv = trackInv;
			this.TrackPnl = trackPnl;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public BMSetInventoryRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(HostedButtonID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":HostedButtonID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.HostedButtonID));
				sb.Append("</").Append(PreferredPrefix).Append(":HostedButtonID>");
			}
			if(TrackInv != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TrackInv>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TrackInv));
				sb.Append("</").Append(PreferredPrefix).Append(":TrackInv>");
			}
			if(TrackPnl != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TrackPnl>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TrackPnl));
				sb.Append("</").Append(PreferredPrefix).Append(":TrackPnl>");
			}
			if(ItemTrackingDetails != null)
			{
				sb.Append(ItemTrackingDetails.ToXMLString(null,"ItemTrackingDetails"));
			}
			if(OptionIndex != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":OptionIndex>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.OptionIndex));
				sb.Append("</").Append(PreferredPrefix).Append(":OptionIndex>");
			}
			if(OptionTrackingDetails != null)
			{
				for(int i = 0; i < OptionTrackingDetails.Count; i++)
				{
					sb.Append(OptionTrackingDetails[i].ToXMLString(null,"OptionTrackingDetails"));
				}
			}
			if(SoldoutURL != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":SoldoutURL>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.SoldoutURL));
				sb.Append("</").Append(PreferredPrefix).Append(":SoldoutURL>");
			}
			if(ReuseDigitalDownloadKeys != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReuseDigitalDownloadKeys>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReuseDigitalDownloadKeys));
				sb.Append("</").Append(PreferredPrefix).Append(":ReuseDigitalDownloadKeys>");
			}
			if(AppendDigitalDownloadKeys != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AppendDigitalDownloadKeys>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.AppendDigitalDownloadKeys));
				sb.Append("</").Append(PreferredPrefix).Append(":AppendDigitalDownloadKeys>");
			}
			if(DigitalDownloadKeys != null)
			{
				for(int i = 0; i < DigitalDownloadKeys.Count; i++)
				{
					sb.Append("<").Append(PreferredPrefix).Append(":DigitalDownloadKeys>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.DigitalDownloadKeys[i]));
					sb.Append("</").Append(PreferredPrefix).Append(":DigitalDownloadKeys>");
				}
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class BMSetInventoryResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public BMSetInventoryResponseType()
	 	{
		}


		public BMSetInventoryResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
	
		}
	}




	/**
      *
      */
	public partial class BMGetInventoryReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BMGetInventoryRequestType bMGetInventoryRequestField;
		public BMGetInventoryRequestType BMGetInventoryRequest
		{
			get
			{
				return this.bMGetInventoryRequestField;
			}
			set
			{
				this.bMGetInventoryRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BMGetInventoryReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BMGetInventoryRequest != null)
			{
				sb.Append(BMGetInventoryRequest.ToXMLString(null,"BMGetInventoryRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Hosted Button ID of the button to return inventory for. 
      *Required Character length and limitations: 10 single-byte
      *numeric characters  
      */
	public partial class BMGetInventoryRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string hostedButtonIDField;
		public string HostedButtonID
		{
			get
			{
				return this.hostedButtonIDField;
			}
			set
			{
				this.hostedButtonIDField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public BMGetInventoryRequestType(string hostedButtonID)
	 	{
			this.HostedButtonID = hostedButtonID;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public BMGetInventoryRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(HostedButtonID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":HostedButtonID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.HostedButtonID));
				sb.Append("</").Append(PreferredPrefix).Append(":HostedButtonID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class BMGetInventoryResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string hostedButtonIDField;
		public string HostedButtonID
		{
			get
			{
				return this.hostedButtonIDField;
			}
			set
			{
				this.hostedButtonIDField = value;
			}
		}
		

		/**
          *
		  */
		private string trackInvField;
		public string TrackInv
		{
			get
			{
				return this.trackInvField;
			}
			set
			{
				this.trackInvField = value;
			}
		}
		

		/**
          *
		  */
		private string trackPnlField;
		public string TrackPnl
		{
			get
			{
				return this.trackPnlField;
			}
			set
			{
				this.trackPnlField = value;
			}
		}
		

		/**
          *
		  */
		private ItemTrackingDetailsType itemTrackingDetailsField;
		public ItemTrackingDetailsType ItemTrackingDetails
		{
			get
			{
				return this.itemTrackingDetailsField;
			}
			set
			{
				this.itemTrackingDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string optionIndexField;
		public string OptionIndex
		{
			get
			{
				return this.optionIndexField;
			}
			set
			{
				this.optionIndexField = value;
			}
		}
		

		/**
          *
		  */
		private string optionNameField;
		public string OptionName
		{
			get
			{
				return this.optionNameField;
			}
			set
			{
				this.optionNameField = value;
			}
		}
		

		/**
          *
		  */
		private List<OptionTrackingDetailsType> optionTrackingDetailsField = new List<OptionTrackingDetailsType>();
		public List<OptionTrackingDetailsType> OptionTrackingDetails
		{
			get
			{
				return this.optionTrackingDetailsField;
			}
			set
			{
				this.optionTrackingDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string soldoutURLField;
		public string SoldoutURL
		{
			get
			{
				return this.soldoutURLField;
			}
			set
			{
				this.soldoutURLField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> digitalDownloadKeysField = new List<string>();
		public List<string> DigitalDownloadKeys
		{
			get
			{
				return this.digitalDownloadKeysField;
			}
			set
			{
				this.digitalDownloadKeysField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BMGetInventoryResponseType()
	 	{
		}


		public BMGetInventoryResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'HostedButtonID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.HostedButtonID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TrackInv']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TrackInv = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TrackPnl']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TrackPnl = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ItemTrackingDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ItemTrackingDetails =  new ItemTrackingDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OptionIndex']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OptionIndex = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'OptionName']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.OptionName = ChildNode.InnerText;
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'OptionTrackingDetails']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.OptionTrackingDetails.Add(new OptionTrackingDetailsType(subNode));
				}
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'SoldoutURL']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.SoldoutURL = ChildNode.InnerText;
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'DigitalDownloadKeys']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					string value = ChildNodeList[i].InnerText;
					this.DigitalDownloadKeys.Add(value);
				}
			}
	
		}
	}




	/**
      *
      */
	public partial class BMButtonSearchReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BMButtonSearchRequestType bMButtonSearchRequestField;
		public BMButtonSearchRequestType BMButtonSearchRequest
		{
			get
			{
				return this.bMButtonSearchRequestField;
			}
			set
			{
				this.bMButtonSearchRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BMButtonSearchReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BMButtonSearchRequest != null)
			{
				sb.Append(BMButtonSearchRequest.ToXMLString(null,"BMButtonSearchRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *The earliest transaction date at which to start the search.
      *No wildcards are allowed. Required 
      */
	public partial class BMButtonSearchRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string startDateField;
		public string StartDate
		{
			get
			{
				return this.startDateField;
			}
			set
			{
				this.startDateField = value;
			}
		}
		

		/**
          *
		  */
		private string endDateField;
		public string EndDate
		{
			get
			{
				return this.endDateField;
			}
			set
			{
				this.endDateField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BMButtonSearchRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(StartDate != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":StartDate>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.StartDate));
				sb.Append("</").Append(PreferredPrefix).Append(":StartDate>");
			}
			if(EndDate != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":EndDate>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.EndDate));
				sb.Append("</").Append(PreferredPrefix).Append(":EndDate>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class BMButtonSearchResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private List<ButtonSearchResultType> buttonSearchResultField = new List<ButtonSearchResultType>();
		public List<ButtonSearchResultType> ButtonSearchResult
		{
			get
			{
				return this.buttonSearchResultField;
			}
			set
			{
				this.buttonSearchResultField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BMButtonSearchResponseType()
	 	{
		}


		public BMButtonSearchResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'ButtonSearchResult']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.ButtonSearchResult.Add(new ButtonSearchResultType(subNode));
				}
			}
	
		}
	}




	/**
      *
      */
	public partial class RefundTransactionReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private RefundTransactionRequestType refundTransactionRequestField;
		public RefundTransactionRequestType RefundTransactionRequest
		{
			get
			{
				return this.refundTransactionRequestField;
			}
			set
			{
				this.refundTransactionRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public RefundTransactionReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(RefundTransactionRequest != null)
			{
				sb.Append(RefundTransactionRequest.ToXMLString(null,"RefundTransactionRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Unique identifier of the transaction you are refunding.
      *Optional Character length and limitations: 17 single-byte
      *alphanumeric characters 
      */
	public partial class RefundTransactionRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string transactionIDField;
		public string TransactionID
		{
			get
			{
				return this.transactionIDField;
			}
			set
			{
				this.transactionIDField = value;
			}
		}
		

		/**
          *
		  */
		private string payerIDField;
		public string PayerID
		{
			get
			{
				return this.payerIDField;
			}
			set
			{
				this.payerIDField = value;
			}
		}
		

		/**
          *
		  */
		private string invoiceIDField;
		public string InvoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/**
          *
		  */
		private RefundType? refundTypeField;
		public RefundType? RefundType
		{
			get
			{
				return this.refundTypeField;
			}
			set
			{
				this.refundTypeField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private string memoField;
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
			}
		}
		

		/**
          *
		  */
		private string retryUntilField;
		public string RetryUntil
		{
			get
			{
				return this.retryUntilField;
			}
			set
			{
				this.retryUntilField = value;
			}
		}
		

		/**
          *
		  */
		private RefundSourceCodeType? refundSourceField;
		public RefundSourceCodeType? RefundSource
		{
			get
			{
				return this.refundSourceField;
			}
			set
			{
				this.refundSourceField = value;
			}
		}
		

		/**
          *
		  */
		private bool? refundAdviceField;
		public bool? RefundAdvice
		{
			get
			{
				return this.refundAdviceField;
			}
			set
			{
				this.refundAdviceField = value;
			}
		}
		

		/**
          *
		  */
		private MerchantStoreDetailsType merchantStoreDetailsField;
		public MerchantStoreDetailsType MerchantStoreDetails
		{
			get
			{
				return this.merchantStoreDetailsField;
			}
			set
			{
				this.merchantStoreDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private List<InvoiceItemType> refundItemDetailsField = new List<InvoiceItemType>();
		public List<InvoiceItemType> RefundItemDetails
		{
			get
			{
				return this.refundItemDetailsField;
			}
			set
			{
				this.refundItemDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string msgSubIDField;
		public string MsgSubID
		{
			get
			{
				return this.msgSubIDField;
			}
			set
			{
				this.msgSubIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public RefundTransactionRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(TransactionID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TransactionID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TransactionID));
				sb.Append("</").Append(PreferredPrefix).Append(":TransactionID>");
			}
			if(PayerID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PayerID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PayerID));
				sb.Append("</").Append(PreferredPrefix).Append(":PayerID>");
			}
			if(InvoiceID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":InvoiceID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.InvoiceID));
				sb.Append("</").Append(PreferredPrefix).Append(":InvoiceID>");
			}
			if(RefundType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":RefundType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.RefundType)));
				sb.Append("</").Append(PreferredPrefix).Append(":RefundType>");
			}
			if(Amount != null)
			{
				sb.Append(Amount.ToXMLString(PreferredPrefix,"Amount"));
			}
			if(Memo != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Memo>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Memo));
				sb.Append("</").Append(PreferredPrefix).Append(":Memo>");
			}
			if(RetryUntil != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":RetryUntil>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.RetryUntil));
				sb.Append("</").Append(PreferredPrefix).Append(":RetryUntil>");
			}
			if(RefundSource != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":RefundSource>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.RefundSource)));
				sb.Append("</").Append(PreferredPrefix).Append(":RefundSource>");
			}
			if(RefundAdvice != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":RefundAdvice>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.RefundAdvice.ToString().ToLower()));
				sb.Append("</").Append(PreferredPrefix).Append(":RefundAdvice>");
			}
			if(MerchantStoreDetails != null)
			{
				sb.Append(MerchantStoreDetails.ToXMLString(null,"MerchantStoreDetails"));
			}
			if(RefundItemDetails != null)
			{
				for(int i = 0; i < RefundItemDetails.Count; i++)
				{
					sb.Append(RefundItemDetails[i].ToXMLString(null,"RefundItemDetails"));
				}
			}
			if(MsgSubID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MsgSubID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.MsgSubID));
				sb.Append("</").Append(PreferredPrefix).Append(":MsgSubID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Unique transaction ID of the refund. Character length and
      *limitations:17 single-byte characters 
      */
	public partial class RefundTransactionResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string refundTransactionIDField;
		public string RefundTransactionID
		{
			get
			{
				return this.refundTransactionIDField;
			}
			set
			{
				this.refundTransactionIDField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType netRefundAmountField;
		public BasicAmountType NetRefundAmount
		{
			get
			{
				return this.netRefundAmountField;
			}
			set
			{
				this.netRefundAmountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType feeRefundAmountField;
		public BasicAmountType FeeRefundAmount
		{
			get
			{
				return this.feeRefundAmountField;
			}
			set
			{
				this.feeRefundAmountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType grossRefundAmountField;
		public BasicAmountType GrossRefundAmount
		{
			get
			{
				return this.grossRefundAmountField;
			}
			set
			{
				this.grossRefundAmountField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType totalRefundedAmountField;
		public BasicAmountType TotalRefundedAmount
		{
			get
			{
				return this.totalRefundedAmountField;
			}
			set
			{
				this.totalRefundedAmountField = value;
			}
		}
		

		/**
          *
		  */
		private RefundInfoType refundInfoField;
		public RefundInfoType RefundInfo
		{
			get
			{
				return this.refundInfoField;
			}
			set
			{
				this.refundInfoField = value;
			}
		}
		

		/**
          *
		  */
		private string receiptDataField;
		public string ReceiptData
		{
			get
			{
				return this.receiptDataField;
			}
			set
			{
				this.receiptDataField = value;
			}
		}
		

		/**
          *
		  */
		private string msgSubIDField;
		public string MsgSubID
		{
			get
			{
				return this.msgSubIDField;
			}
			set
			{
				this.msgSubIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public RefundTransactionResponseType()
	 	{
		}


		public RefundTransactionResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RefundTransactionID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RefundTransactionID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'NetRefundAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.NetRefundAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'FeeRefundAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.FeeRefundAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GrossRefundAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GrossRefundAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TotalRefundedAmount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TotalRefundedAmount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'RefundInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.RefundInfo =  new RefundInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ReceiptData']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ReceiptData = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'MsgSubID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.MsgSubID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class InitiateRecoupReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private InitiateRecoupRequestType initiateRecoupRequestField;
		public InitiateRecoupRequestType InitiateRecoupRequest
		{
			get
			{
				return this.initiateRecoupRequestField;
			}
			set
			{
				this.initiateRecoupRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public InitiateRecoupReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(InitiateRecoupRequest != null)
			{
				sb.Append(InitiateRecoupRequest.ToXMLString(null,"InitiateRecoupRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class InitiateRecoupRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private EnhancedInitiateRecoupRequestDetailsType enhancedInitiateRecoupRequestDetailsField;
		public EnhancedInitiateRecoupRequestDetailsType EnhancedInitiateRecoupRequestDetails
		{
			get
			{
				return this.enhancedInitiateRecoupRequestDetailsField;
			}
			set
			{
				this.enhancedInitiateRecoupRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public InitiateRecoupRequestType(EnhancedInitiateRecoupRequestDetailsType enhancedInitiateRecoupRequestDetails)
	 	{
			this.EnhancedInitiateRecoupRequestDetails = enhancedInitiateRecoupRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public InitiateRecoupRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(EnhancedInitiateRecoupRequestDetails != null)
			{
				sb.Append(EnhancedInitiateRecoupRequestDetails.ToXMLString(null,"EnhancedInitiateRecoupRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class InitiateRecoupResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public InitiateRecoupResponseType()
	 	{
		}


		public InitiateRecoupResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
	
		}
	}




	/**
      *
      */
	public partial class CompleteRecoupReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private CompleteRecoupRequestType completeRecoupRequestField;
		public CompleteRecoupRequestType CompleteRecoupRequest
		{
			get
			{
				return this.completeRecoupRequestField;
			}
			set
			{
				this.completeRecoupRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CompleteRecoupReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(CompleteRecoupRequest != null)
			{
				sb.Append(CompleteRecoupRequest.ToXMLString(null,"CompleteRecoupRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class CompleteRecoupRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private EnhancedCompleteRecoupRequestDetailsType enhancedCompleteRecoupRequestDetailsField;
		public EnhancedCompleteRecoupRequestDetailsType EnhancedCompleteRecoupRequestDetails
		{
			get
			{
				return this.enhancedCompleteRecoupRequestDetailsField;
			}
			set
			{
				this.enhancedCompleteRecoupRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public CompleteRecoupRequestType(EnhancedCompleteRecoupRequestDetailsType enhancedCompleteRecoupRequestDetails)
	 	{
			this.EnhancedCompleteRecoupRequestDetails = enhancedCompleteRecoupRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public CompleteRecoupRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(EnhancedCompleteRecoupRequestDetails != null)
			{
				sb.Append(EnhancedCompleteRecoupRequestDetails.ToXMLString(null,"EnhancedCompleteRecoupRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class CompleteRecoupResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private EnhancedCompleteRecoupResponseDetailsType enhancedCompleteRecoupResponseDetailsField;
		public EnhancedCompleteRecoupResponseDetailsType EnhancedCompleteRecoupResponseDetails
		{
			get
			{
				return this.enhancedCompleteRecoupResponseDetailsField;
			}
			set
			{
				this.enhancedCompleteRecoupResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CompleteRecoupResponseType()
	 	{
		}


		public CompleteRecoupResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'EnhancedCompleteRecoupResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.EnhancedCompleteRecoupResponseDetails =  new EnhancedCompleteRecoupResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class CancelRecoupReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private CancelRecoupRequestType cancelRecoupRequestField;
		public CancelRecoupRequestType CancelRecoupRequest
		{
			get
			{
				return this.cancelRecoupRequestField;
			}
			set
			{
				this.cancelRecoupRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CancelRecoupReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(CancelRecoupRequest != null)
			{
				sb.Append(CancelRecoupRequest.ToXMLString(null,"CancelRecoupRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class CancelRecoupRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private EnhancedCancelRecoupRequestDetailsType enhancedCancelRecoupRequestDetailsField;
		public EnhancedCancelRecoupRequestDetailsType EnhancedCancelRecoupRequestDetails
		{
			get
			{
				return this.enhancedCancelRecoupRequestDetailsField;
			}
			set
			{
				this.enhancedCancelRecoupRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public CancelRecoupRequestType(EnhancedCancelRecoupRequestDetailsType enhancedCancelRecoupRequestDetails)
	 	{
			this.EnhancedCancelRecoupRequestDetails = enhancedCancelRecoupRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public CancelRecoupRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(EnhancedCancelRecoupRequestDetails != null)
			{
				sb.Append(EnhancedCancelRecoupRequestDetails.ToXMLString(null,"EnhancedCancelRecoupRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class CancelRecoupResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public CancelRecoupResponseType()
	 	{
		}


		public CancelRecoupResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
	
		}
	}




	/**
      *
      */
	public partial class GetTransactionDetailsReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetTransactionDetailsRequestType getTransactionDetailsRequestField;
		public GetTransactionDetailsRequestType GetTransactionDetailsRequest
		{
			get
			{
				return this.getTransactionDetailsRequestField;
			}
			set
			{
				this.getTransactionDetailsRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetTransactionDetailsReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(GetTransactionDetailsRequest != null)
			{
				sb.Append(GetTransactionDetailsRequest.ToXMLString(null,"GetTransactionDetailsRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Unique identifier of a transaction. RequiredThe details for
      *some kinds of transactions cannot be retrieved with
      *GetTransactionDetailsRequest. You cannot obtain details of
      *bank transfer withdrawals, for example. Character length and
      *limitations: 17 single-byte alphanumeric characters
      */
	public partial class GetTransactionDetailsRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string transactionIDField;
		public string TransactionID
		{
			get
			{
				return this.transactionIDField;
			}
			set
			{
				this.transactionIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetTransactionDetailsRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(TransactionID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TransactionID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TransactionID));
				sb.Append("</").Append(PreferredPrefix).Append(":TransactionID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetTransactionDetailsResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private PaymentTransactionType paymentTransactionDetailsField;
		public PaymentTransactionType PaymentTransactionDetails
		{
			get
			{
				return this.paymentTransactionDetailsField;
			}
			set
			{
				this.paymentTransactionDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private ThreeDSecureInfoType threeDSecureDetailsField;
		public ThreeDSecureInfoType ThreeDSecureDetails
		{
			get
			{
				return this.threeDSecureDetailsField;
			}
			set
			{
				this.threeDSecureDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetTransactionDetailsResponseType()
	 	{
		}


		public GetTransactionDetailsResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentTransactionDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentTransactionDetails =  new PaymentTransactionType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ThreeDSecureDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ThreeDSecureDetails =  new ThreeDSecureInfoType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class BillUserReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BillUserRequestType billUserRequestField;
		public BillUserRequestType BillUserRequest
		{
			get
			{
				return this.billUserRequestField;
			}
			set
			{
				this.billUserRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BillUserReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BillUserRequest != null)
			{
				sb.Append(BillUserRequest.ToXMLString(null,"BillUserRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *This flag indicates that the response should include
      *FMFDetails 
      */
	public partial class BillUserRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private MerchantPullPaymentType merchantPullPaymentDetailsField;
		public MerchantPullPaymentType MerchantPullPaymentDetails
		{
			get
			{
				return this.merchantPullPaymentDetailsField;
			}
			set
			{
				this.merchantPullPaymentDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private int? returnFMFDetailsField;
		public int? ReturnFMFDetails
		{
			get
			{
				return this.returnFMFDetailsField;
			}
			set
			{
				this.returnFMFDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BillUserRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(MerchantPullPaymentDetails != null)
			{
				sb.Append(MerchantPullPaymentDetails.ToXMLString(null,"MerchantPullPaymentDetails"));
			}
			if(ReturnFMFDetails != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReturnFMFDetails>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReturnFMFDetails));
				sb.Append("</").Append(PreferredPrefix).Append(":ReturnFMFDetails>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class BillUserResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private MerchantPullPaymentResponseType billUserResponseDetailsField;
		public MerchantPullPaymentResponseType BillUserResponseDetails
		{
			get
			{
				return this.billUserResponseDetailsField;
			}
			set
			{
				this.billUserResponseDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private FMFDetailsType fMFDetailsField;
		public FMFDetailsType FMFDetails
		{
			get
			{
				return this.fMFDetailsField;
			}
			set
			{
				this.fMFDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BillUserResponseType()
	 	{
		}


		public BillUserResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillUserResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillUserResponseDetails =  new MerchantPullPaymentResponseType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'FMFDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.FMFDetails =  new FMFDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class TransactionSearchReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private TransactionSearchRequestType transactionSearchRequestField;
		public TransactionSearchRequestType TransactionSearchRequest
		{
			get
			{
				return this.transactionSearchRequestField;
			}
			set
			{
				this.transactionSearchRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public TransactionSearchReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(TransactionSearchRequest != null)
			{
				sb.Append(TransactionSearchRequest.ToXMLString(null,"TransactionSearchRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *The earliest transaction date at which to start the search.
      *No wildcards are allowed. Required
      */
	public partial class TransactionSearchRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string startDateField;
		public string StartDate
		{
			get
			{
				return this.startDateField;
			}
			set
			{
				this.startDateField = value;
			}
		}
		

		/**
          *
		  */
		private string endDateField;
		public string EndDate
		{
			get
			{
				return this.endDateField;
			}
			set
			{
				this.endDateField = value;
			}
		}
		

		/**
          *
		  */
		private string payerField;
		public string Payer
		{
			get
			{
				return this.payerField;
			}
			set
			{
				this.payerField = value;
			}
		}
		

		/**
          *
		  */
		private string receiverField;
		public string Receiver
		{
			get
			{
				return this.receiverField;
			}
			set
			{
				this.receiverField = value;
			}
		}
		

		/**
          *
		  */
		private string receiptIDField;
		public string ReceiptID
		{
			get
			{
				return this.receiptIDField;
			}
			set
			{
				this.receiptIDField = value;
			}
		}
		

		/**
          *
		  */
		private string transactionIDField;
		public string TransactionID
		{
			get
			{
				return this.transactionIDField;
			}
			set
			{
				this.transactionIDField = value;
			}
		}
		

		/**
          *
		  */
		private string profileIDField;
		public string ProfileID
		{
			get
			{
				return this.profileIDField;
			}
			set
			{
				this.profileIDField = value;
			}
		}
		

		/**
          *
		  */
		private PersonNameType payerNameField;
		public PersonNameType PayerName
		{
			get
			{
				return this.payerNameField;
			}
			set
			{
				this.payerNameField = value;
			}
		}
		

		/**
          *
		  */
		private string auctionItemNumberField;
		public string AuctionItemNumber
		{
			get
			{
				return this.auctionItemNumberField;
			}
			set
			{
				this.auctionItemNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string invoiceIDField;
		public string InvoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/**
          *
		  */
		private string cardNumberField;
		public string CardNumber
		{
			get
			{
				return this.cardNumberField;
			}
			set
			{
				this.cardNumberField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentTransactionClassCodeType? transactionClassField;
		public PaymentTransactionClassCodeType? TransactionClass
		{
			get
			{
				return this.transactionClassField;
			}
			set
			{
				this.transactionClassField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private CurrencyCodeType? currencyCodeField;
		public CurrencyCodeType? CurrencyCode
		{
			get
			{
				return this.currencyCodeField;
			}
			set
			{
				this.currencyCodeField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentTransactionStatusCodeType? statusField;
		public PaymentTransactionStatusCodeType? Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public TransactionSearchRequestType(string startDate)
	 	{
			this.StartDate = startDate;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public TransactionSearchRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(StartDate != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":StartDate>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.StartDate));
				sb.Append("</").Append(PreferredPrefix).Append(":StartDate>");
			}
			if(EndDate != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":EndDate>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.EndDate));
				sb.Append("</").Append(PreferredPrefix).Append(":EndDate>");
			}
			if(Payer != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Payer>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Payer));
				sb.Append("</").Append(PreferredPrefix).Append(":Payer>");
			}
			if(Receiver != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Receiver>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Receiver));
				sb.Append("</").Append(PreferredPrefix).Append(":Receiver>");
			}
			if(ReceiptID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReceiptID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReceiptID));
				sb.Append("</").Append(PreferredPrefix).Append(":ReceiptID>");
			}
			if(TransactionID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TransactionID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TransactionID));
				sb.Append("</").Append(PreferredPrefix).Append(":TransactionID>");
			}
			if(ProfileID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ProfileID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ProfileID));
				sb.Append("</").Append(PreferredPrefix).Append(":ProfileID>");
			}
			if(PayerName != null)
			{
				sb.Append(PayerName.ToXMLString(PreferredPrefix,"PayerName"));
			}
			if(AuctionItemNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AuctionItemNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.AuctionItemNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":AuctionItemNumber>");
			}
			if(InvoiceID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":InvoiceID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.InvoiceID));
				sb.Append("</").Append(PreferredPrefix).Append(":InvoiceID>");
			}
			if(CardNumber != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CardNumber>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CardNumber));
				sb.Append("</").Append(PreferredPrefix).Append(":CardNumber>");
			}
			if(TransactionClass != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TransactionClass>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.TransactionClass)));
				sb.Append("</").Append(PreferredPrefix).Append(":TransactionClass>");
			}
			if(Amount != null)
			{
				sb.Append(Amount.ToXMLString(PreferredPrefix,"Amount"));
			}
			if(CurrencyCode != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CurrencyCode>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.CurrencyCode)));
				sb.Append("</").Append(PreferredPrefix).Append(":CurrencyCode>");
			}
			if(Status != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Status>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.Status)));
				sb.Append("</").Append(PreferredPrefix).Append(":Status>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Results of a Transaction Search.
      */
	public partial class TransactionSearchResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private List<PaymentTransactionSearchResultType> paymentTransactionsField = new List<PaymentTransactionSearchResultType>();
		public List<PaymentTransactionSearchResultType> PaymentTransactions
		{
			get
			{
				return this.paymentTransactionsField;
			}
			set
			{
				this.paymentTransactionsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public TransactionSearchResponseType()
	 	{
		}


		public TransactionSearchResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'PaymentTransactions']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.PaymentTransactions.Add(new PaymentTransactionSearchResultType(subNode));
				}
			}
	
		}
	}




	/**
      *
      */
	public partial class MassPayReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private MassPayRequestType massPayRequestField;
		public MassPayRequestType MassPayRequest
		{
			get
			{
				return this.massPayRequestField;
			}
			set
			{
				this.massPayRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public MassPayReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(MassPayRequest != null)
			{
				sb.Append(MassPayRequest.ToXMLString(null,"MassPayRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Subject line of the email sent to all recipients. This
      *subject is not contained in the input file; you must create
      *it with your application. Optional Character length and
      *limitations: 255 single-byte alphanumeric characters 
      */
	public partial class MassPayRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string emailSubjectField;
		public string EmailSubject
		{
			get
			{
				return this.emailSubjectField;
			}
			set
			{
				this.emailSubjectField = value;
			}
		}
		

		/**
          *
		  */
		private ReceiverInfoCodeType? receiverTypeField;
		public ReceiverInfoCodeType? ReceiverType
		{
			get
			{
				return this.receiverTypeField;
			}
			set
			{
				this.receiverTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string buttonSourceField;
		public string ButtonSource
		{
			get
			{
				return this.buttonSourceField;
			}
			set
			{
				this.buttonSourceField = value;
			}
		}
		

		/**
          *
		  */
		private List<MassPayRequestItemType> massPayItemField = new List<MassPayRequestItemType>();
		public List<MassPayRequestItemType> MassPayItem
		{
			get
			{
				return this.massPayItemField;
			}
			set
			{
				this.massPayItemField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public MassPayRequestType(List<MassPayRequestItemType> massPayItem)
	 	{
			this.MassPayItem = massPayItem;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public MassPayRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(EmailSubject != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":EmailSubject>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.EmailSubject));
				sb.Append("</").Append(PreferredPrefix).Append(":EmailSubject>");
			}
			if(ReceiverType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReceiverType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.ReceiverType)));
				sb.Append("</").Append(PreferredPrefix).Append(":ReceiverType>");
			}
			if(ButtonSource != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ButtonSource>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ButtonSource));
				sb.Append("</").Append(PreferredPrefix).Append(":ButtonSource>");
			}
			if(MassPayItem != null)
			{
				for(int i = 0; i < MassPayItem.Count; i++)
				{
					sb.Append(MassPayItem[i].ToXMLString(PreferredPrefix,"MassPayItem"));
				}
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class MassPayResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public MassPayResponseType()
	 	{
		}


		public MassPayResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
	
		}
	}




	/**
      *MassPayRequestItemType 
      */
	public partial class MassPayRequestItemType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string receiverEmailField;
		public string ReceiverEmail
		{
			get
			{
				return this.receiverEmailField;
			}
			set
			{
				this.receiverEmailField = value;
			}
		}
		

		/**
          *
		  */
		private string receiverPhoneField;
		public string ReceiverPhone
		{
			get
			{
				return this.receiverPhoneField;
			}
			set
			{
				this.receiverPhoneField = value;
			}
		}
		

		/**
          *
		  */
		private string receiverIDField;
		public string ReceiverID
		{
			get
			{
				return this.receiverIDField;
			}
			set
			{
				this.receiverIDField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private string uniqueIdField;
		public string UniqueId
		{
			get
			{
				return this.uniqueIdField;
			}
			set
			{
				this.uniqueIdField = value;
			}
		}
		

		/**
          *
		  */
		private string noteField;
		public string Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public MassPayRequestItemType(BasicAmountType amount)
	 	{
			this.Amount = amount;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public MassPayRequestItemType()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ReceiverEmail != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReceiverEmail>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReceiverEmail));
				sb.Append("</").Append(PreferredPrefix).Append(":ReceiverEmail>");
			}
			if(ReceiverPhone != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReceiverPhone>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReceiverPhone));
				sb.Append("</").Append(PreferredPrefix).Append(":ReceiverPhone>");
			}
			if(ReceiverID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReceiverID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReceiverID));
				sb.Append("</").Append(PreferredPrefix).Append(":ReceiverID>");
			}
			if(Amount != null)
			{
				sb.Append(Amount.ToXMLString(PreferredPrefix,"Amount"));
			}
			if(UniqueId != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":UniqueId>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.UniqueId));
				sb.Append("</").Append(PreferredPrefix).Append(":UniqueId>");
			}
			if(Note != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Note>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Note));
				sb.Append("</").Append(PreferredPrefix).Append(":Note>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class BillAgreementUpdateReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BAUpdateRequestType bAUpdateRequestField;
		public BAUpdateRequestType BAUpdateRequest
		{
			get
			{
				return this.bAUpdateRequestField;
			}
			set
			{
				this.bAUpdateRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BillAgreementUpdateReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BAUpdateRequest != null)
			{
				sb.Append(BAUpdateRequest.ToXMLString(null,"BAUpdateRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class BAUpdateRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string referenceIDField;
		public string ReferenceID
		{
			get
			{
				return this.referenceIDField;
			}
			set
			{
				this.referenceIDField = value;
			}
		}
		

		/**
          *
		  */
		private string billingAgreementDescriptionField;
		public string BillingAgreementDescription
		{
			get
			{
				return this.billingAgreementDescriptionField;
			}
			set
			{
				this.billingAgreementDescriptionField = value;
			}
		}
		

		/**
          *
		  */
		private MerchantPullStatusCodeType? billingAgreementStatusField;
		public MerchantPullStatusCodeType? BillingAgreementStatus
		{
			get
			{
				return this.billingAgreementStatusField;
			}
			set
			{
				this.billingAgreementStatusField = value;
			}
		}
		

		/**
          *
		  */
		private string billingAgreementCustomField;
		public string BillingAgreementCustom
		{
			get
			{
				return this.billingAgreementCustomField;
			}
			set
			{
				this.billingAgreementCustomField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public BAUpdateRequestType(string referenceID)
	 	{
			this.ReferenceID = referenceID;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public BAUpdateRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(ReferenceID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReferenceID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReferenceID));
				sb.Append("</").Append(PreferredPrefix).Append(":ReferenceID>");
			}
			if(BillingAgreementDescription != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BillingAgreementDescription>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BillingAgreementDescription));
				sb.Append("</").Append(PreferredPrefix).Append(":BillingAgreementDescription>");
			}
			if(BillingAgreementStatus != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BillingAgreementStatus>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.BillingAgreementStatus)));
				sb.Append("</").Append(PreferredPrefix).Append(":BillingAgreementStatus>");
			}
			if(BillingAgreementCustom != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":BillingAgreementCustom>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.BillingAgreementCustom));
				sb.Append("</").Append(PreferredPrefix).Append(":BillingAgreementCustom>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class BAUpdateResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BAUpdateResponseDetailsType bAUpdateResponseDetailsField;
		public BAUpdateResponseDetailsType BAUpdateResponseDetails
		{
			get
			{
				return this.bAUpdateResponseDetailsField;
			}
			set
			{
				this.bAUpdateResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BAUpdateResponseType()
	 	{
		}


		public BAUpdateResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BAUpdateResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BAUpdateResponseDetails =  new BAUpdateResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class AddressVerifyReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private AddressVerifyRequestType addressVerifyRequestField;
		public AddressVerifyRequestType AddressVerifyRequest
		{
			get
			{
				return this.addressVerifyRequestField;
			}
			set
			{
				this.addressVerifyRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public AddressVerifyReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(AddressVerifyRequest != null)
			{
				sb.Append(AddressVerifyRequest.ToXMLString(null,"AddressVerifyRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Email address of buyer to be verified. Required Maximum
      *string length: 255 single-byte characters Input mask: ?@?.??
      *
      */
	public partial class AddressVerifyRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string emailField;
		public string Email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
			}
		}
		

		/**
          *
		  */
		private string streetField;
		public string Street
		{
			get
			{
				return this.streetField;
			}
			set
			{
				this.streetField = value;
			}
		}
		

		/**
          *
		  */
		private string zipField;
		public string Zip
		{
			get
			{
				return this.zipField;
			}
			set
			{
				this.zipField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public AddressVerifyRequestType(string email, string street, string zip)
	 	{
			this.Email = email;
			this.Street = street;
			this.Zip = zip;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public AddressVerifyRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(Email != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Email>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Email));
				sb.Append("</").Append(PreferredPrefix).Append(":Email>");
			}
			if(Street != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Street>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Street));
				sb.Append("</").Append(PreferredPrefix).Append(":Street>");
			}
			if(Zip != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Zip>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Zip));
				sb.Append("</").Append(PreferredPrefix).Append(":Zip>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Confirmation of a match, with one of the following tokens:
      *None: The input value of the Email object does not match any
      *email address on file at PayPal. Confirmed: If the value of
      *the StreetMatch object is Matched, PayPal responds that the
      *entire postal address is confirmed. Unconfirmed: PayPal
      *responds that the postal address is unconfirmed 
      */
	public partial class AddressVerifyResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private AddressStatusCodeType? confirmationCodeField;
		public AddressStatusCodeType? ConfirmationCode
		{
			get
			{
				return this.confirmationCodeField;
			}
			set
			{
				this.confirmationCodeField = value;
			}
		}
		

		/**
          *
		  */
		private MatchStatusCodeType? streetMatchField;
		public MatchStatusCodeType? StreetMatch
		{
			get
			{
				return this.streetMatchField;
			}
			set
			{
				this.streetMatchField = value;
			}
		}
		

		/**
          *
		  */
		private MatchStatusCodeType? zipMatchField;
		public MatchStatusCodeType? ZipMatch
		{
			get
			{
				return this.zipMatchField;
			}
			set
			{
				this.zipMatchField = value;
			}
		}
		

		/**
          *
		  */
		private CountryCodeType? countryCodeField;
		public CountryCodeType? CountryCode
		{
			get
			{
				return this.countryCodeField;
			}
			set
			{
				this.countryCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string payPalTokenField;
		public string PayPalToken
		{
			get
			{
				return this.payPalTokenField;
			}
			set
			{
				this.payPalTokenField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public AddressVerifyResponseType()
	 	{
		}


		public AddressVerifyResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ConfirmationCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ConfirmationCode = (AddressStatusCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(AddressStatusCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'StreetMatch']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.StreetMatch = (MatchStatusCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(MatchStatusCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ZipMatch']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ZipMatch = (MatchStatusCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(MatchStatusCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CountryCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CountryCode = (CountryCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(CountryCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PayPalToken']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PayPalToken = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class EnterBoardingReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private EnterBoardingRequestType enterBoardingRequestField;
		public EnterBoardingRequestType EnterBoardingRequest
		{
			get
			{
				return this.enterBoardingRequestField;
			}
			set
			{
				this.enterBoardingRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public EnterBoardingReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(EnterBoardingRequest != null)
			{
				sb.Append(EnterBoardingRequest.ToXMLString(null,"EnterBoardingRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class EnterBoardingRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private EnterBoardingRequestDetailsType enterBoardingRequestDetailsField;
		public EnterBoardingRequestDetailsType EnterBoardingRequestDetails
		{
			get
			{
				return this.enterBoardingRequestDetailsField;
			}
			set
			{
				this.enterBoardingRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public EnterBoardingRequestType(EnterBoardingRequestDetailsType enterBoardingRequestDetails)
	 	{
			this.EnterBoardingRequestDetails = enterBoardingRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public EnterBoardingRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(EnterBoardingRequestDetails != null)
			{
				sb.Append(EnterBoardingRequestDetails.ToXMLString(null,"EnterBoardingRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *A unique token that identifies this boarding session. Use
      *this token with the GetBoarding Details API call.Character
      *length and limitations: 64 alphanumeric characters. The
      *token has the following format:OB-61characterstring
      */
	public partial class EnterBoardingResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public EnterBoardingResponseType()
	 	{
		}


		public EnterBoardingResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Token']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Token = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class GetBoardingDetailsReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetBoardingDetailsRequestType getBoardingDetailsRequestField;
		public GetBoardingDetailsRequestType GetBoardingDetailsRequest
		{
			get
			{
				return this.getBoardingDetailsRequestField;
			}
			set
			{
				this.getBoardingDetailsRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetBoardingDetailsReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(GetBoardingDetailsRequest != null)
			{
				sb.Append(GetBoardingDetailsRequest.ToXMLString(null,"GetBoardingDetailsRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *A unique token returned by the EnterBoarding API call that
      *identifies this boarding session. RequiredCharacter length
      *and limitations: 64 alphanumeric characters. The token has
      *the following format:OB-61characterstring
      */
	public partial class GetBoardingDetailsRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetBoardingDetailsRequestType(string token)
	 	{
			this.Token = token;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetBoardingDetailsRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(Token != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Token>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Token));
				sb.Append("</").Append(PreferredPrefix).Append(":Token>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetBoardingDetailsResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetBoardingDetailsResponseDetailsType getBoardingDetailsResponseDetailsField;
		public GetBoardingDetailsResponseDetailsType GetBoardingDetailsResponseDetails
		{
			get
			{
				return this.getBoardingDetailsResponseDetailsField;
			}
			set
			{
				this.getBoardingDetailsResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetBoardingDetailsResponseType()
	 	{
		}


		public GetBoardingDetailsResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GetBoardingDetailsResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GetBoardingDetailsResponseDetails =  new GetBoardingDetailsResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class SetAuthFlowParamReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private SetAuthFlowParamRequestType setAuthFlowParamRequestField;
		public SetAuthFlowParamRequestType SetAuthFlowParamRequest
		{
			get
			{
				return this.setAuthFlowParamRequestField;
			}
			set
			{
				this.setAuthFlowParamRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SetAuthFlowParamReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(SetAuthFlowParamRequest != null)
			{
				sb.Append(SetAuthFlowParamRequest.ToXMLString(null,"SetAuthFlowParamRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class SetAuthFlowParamRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private SetAuthFlowParamRequestDetailsType setAuthFlowParamRequestDetailsField;
		public SetAuthFlowParamRequestDetailsType SetAuthFlowParamRequestDetails
		{
			get
			{
				return this.setAuthFlowParamRequestDetailsField;
			}
			set
			{
				this.setAuthFlowParamRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public SetAuthFlowParamRequestType(SetAuthFlowParamRequestDetailsType setAuthFlowParamRequestDetails)
	 	{
			this.SetAuthFlowParamRequestDetails = setAuthFlowParamRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public SetAuthFlowParamRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(SetAuthFlowParamRequestDetails != null)
			{
				sb.Append(SetAuthFlowParamRequestDetails.ToXMLString(null,"SetAuthFlowParamRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *A timestamped token by which you identify to PayPal that you
      *are processing this user. The token expires after three
      *hours. Character length and limitations: 20 single-byte
      *characters
      */
	public partial class SetAuthFlowParamResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SetAuthFlowParamResponseType()
	 	{
		}


		public SetAuthFlowParamResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Token']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Token = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class GetAuthDetailsReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetAuthDetailsRequestType getAuthDetailsRequestField;
		public GetAuthDetailsRequestType GetAuthDetailsRequest
		{
			get
			{
				return this.getAuthDetailsRequestField;
			}
			set
			{
				this.getAuthDetailsRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetAuthDetailsReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(GetAuthDetailsRequest != null)
			{
				sb.Append(GetAuthDetailsRequest.ToXMLString(null,"GetAuthDetailsRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *A timestamped token, the value of which was returned by
      *SetAuthFlowParam Response. RequiredCharacter length and
      *limitations: 20 single-byte characters
      */
	public partial class GetAuthDetailsRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetAuthDetailsRequestType(string token)
	 	{
			this.Token = token;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetAuthDetailsRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(Token != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Token>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Token));
				sb.Append("</").Append(PreferredPrefix).Append(":Token>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetAuthDetailsResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetAuthDetailsResponseDetailsType getAuthDetailsResponseDetailsField;
		public GetAuthDetailsResponseDetailsType GetAuthDetailsResponseDetails
		{
			get
			{
				return this.getAuthDetailsResponseDetailsField;
			}
			set
			{
				this.getAuthDetailsResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetAuthDetailsResponseType()
	 	{
		}


		public GetAuthDetailsResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GetAuthDetailsResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GetAuthDetailsResponseDetails =  new GetAuthDetailsResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class SetAccessPermissionsReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private SetAccessPermissionsRequestType setAccessPermissionsRequestField;
		public SetAccessPermissionsRequestType SetAccessPermissionsRequest
		{
			get
			{
				return this.setAccessPermissionsRequestField;
			}
			set
			{
				this.setAccessPermissionsRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SetAccessPermissionsReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(SetAccessPermissionsRequest != null)
			{
				sb.Append(SetAccessPermissionsRequest.ToXMLString(null,"SetAccessPermissionsRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class SetAccessPermissionsRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private SetAccessPermissionsRequestDetailsType setAccessPermissionsRequestDetailsField;
		public SetAccessPermissionsRequestDetailsType SetAccessPermissionsRequestDetails
		{
			get
			{
				return this.setAccessPermissionsRequestDetailsField;
			}
			set
			{
				this.setAccessPermissionsRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public SetAccessPermissionsRequestType(SetAccessPermissionsRequestDetailsType setAccessPermissionsRequestDetails)
	 	{
			this.SetAccessPermissionsRequestDetails = setAccessPermissionsRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public SetAccessPermissionsRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(SetAccessPermissionsRequestDetails != null)
			{
				sb.Append(SetAccessPermissionsRequestDetails.ToXMLString(null,"SetAccessPermissionsRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *A timestamped token by which you identify to PayPal that you
      *are processing this user. The token expires after three
      *hours. Character length and limitations: 20 single-byte
      *characters
      */
	public partial class SetAccessPermissionsResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SetAccessPermissionsResponseType()
	 	{
		}


		public SetAccessPermissionsResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Token']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Token = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class UpdateAccessPermissionsReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private UpdateAccessPermissionsRequestType updateAccessPermissionsRequestField;
		public UpdateAccessPermissionsRequestType UpdateAccessPermissionsRequest
		{
			get
			{
				return this.updateAccessPermissionsRequestField;
			}
			set
			{
				this.updateAccessPermissionsRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public UpdateAccessPermissionsReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(UpdateAccessPermissionsRequest != null)
			{
				sb.Append(UpdateAccessPermissionsRequest.ToXMLString(null,"UpdateAccessPermissionsRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Unique PayPal customer account number, the value of which
      *was returned by GetAuthDetails Response. Required Character
      *length and limitations: 20 single-byte characters 
      */
	public partial class UpdateAccessPermissionsRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string payerIDField;
		public string PayerID
		{
			get
			{
				return this.payerIDField;
			}
			set
			{
				this.payerIDField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public UpdateAccessPermissionsRequestType(string payerID)
	 	{
			this.PayerID = payerID;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public UpdateAccessPermissionsRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(PayerID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":PayerID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.PayerID));
				sb.Append("</").Append(PreferredPrefix).Append(":PayerID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *The status of the update call, Success/Failure. Character
      *length and limitations: 20 single-byte characters 
      */
	public partial class UpdateAccessPermissionsResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string statusField;
		public string Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public UpdateAccessPermissionsResponseType()
	 	{
		}


		public UpdateAccessPermissionsResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Status']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Status = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class GetAccessPermissionDetailsReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetAccessPermissionDetailsRequestType getAccessPermissionDetailsRequestField;
		public GetAccessPermissionDetailsRequestType GetAccessPermissionDetailsRequest
		{
			get
			{
				return this.getAccessPermissionDetailsRequestField;
			}
			set
			{
				this.getAccessPermissionDetailsRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetAccessPermissionDetailsReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(GetAccessPermissionDetailsRequest != null)
			{
				sb.Append(GetAccessPermissionDetailsRequest.ToXMLString(null,"GetAccessPermissionDetailsRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *A timestamped token, the value of which was returned by
      *SetAuthFlowParam Response. Required Character length and
      *limitations: 20 single-byte characters 
      */
	public partial class GetAccessPermissionDetailsRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetAccessPermissionDetailsRequestType(string token)
	 	{
			this.Token = token;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetAccessPermissionDetailsRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(Token != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Token>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Token));
				sb.Append("</").Append(PreferredPrefix).Append(":Token>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetAccessPermissionDetailsResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetAccessPermissionDetailsResponseDetailsType getAccessPermissionDetailsResponseDetailsField;
		public GetAccessPermissionDetailsResponseDetailsType GetAccessPermissionDetailsResponseDetails
		{
			get
			{
				return this.getAccessPermissionDetailsResponseDetailsField;
			}
			set
			{
				this.getAccessPermissionDetailsResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetAccessPermissionDetailsResponseType()
	 	{
		}


		public GetAccessPermissionDetailsResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GetAccessPermissionDetailsResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GetAccessPermissionDetailsResponseDetails =  new GetAccessPermissionDetailsResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class GetIncentiveEvaluationReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetIncentiveEvaluationRequestType getIncentiveEvaluationRequestField;
		public GetIncentiveEvaluationRequestType GetIncentiveEvaluationRequest
		{
			get
			{
				return this.getIncentiveEvaluationRequestField;
			}
			set
			{
				this.getIncentiveEvaluationRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetIncentiveEvaluationReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(GetIncentiveEvaluationRequest != null)
			{
				sb.Append(GetIncentiveEvaluationRequest.ToXMLString(null,"GetIncentiveEvaluationRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetIncentiveEvaluationRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetIncentiveEvaluationRequestDetailsType getIncentiveEvaluationRequestDetailsField;
		public GetIncentiveEvaluationRequestDetailsType GetIncentiveEvaluationRequestDetails
		{
			get
			{
				return this.getIncentiveEvaluationRequestDetailsField;
			}
			set
			{
				this.getIncentiveEvaluationRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetIncentiveEvaluationRequestType(GetIncentiveEvaluationRequestDetailsType getIncentiveEvaluationRequestDetails)
	 	{
			this.GetIncentiveEvaluationRequestDetails = getIncentiveEvaluationRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetIncentiveEvaluationRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(GetIncentiveEvaluationRequestDetails != null)
			{
				sb.Append(GetIncentiveEvaluationRequestDetails.ToXMLString(null,"GetIncentiveEvaluationRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetIncentiveEvaluationResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetIncentiveEvaluationResponseDetailsType getIncentiveEvaluationResponseDetailsField;
		public GetIncentiveEvaluationResponseDetailsType GetIncentiveEvaluationResponseDetails
		{
			get
			{
				return this.getIncentiveEvaluationResponseDetailsField;
			}
			set
			{
				this.getIncentiveEvaluationResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetIncentiveEvaluationResponseType()
	 	{
		}


		public GetIncentiveEvaluationResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GetIncentiveEvaluationResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GetIncentiveEvaluationResponseDetails =  new GetIncentiveEvaluationResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class SetExpressCheckoutReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private SetExpressCheckoutRequestType setExpressCheckoutRequestField;
		public SetExpressCheckoutRequestType SetExpressCheckoutRequest
		{
			get
			{
				return this.setExpressCheckoutRequestField;
			}
			set
			{
				this.setExpressCheckoutRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SetExpressCheckoutReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(SetExpressCheckoutRequest != null)
			{
				sb.Append(SetExpressCheckoutRequest.ToXMLString(null,"SetExpressCheckoutRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class SetExpressCheckoutRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private SetExpressCheckoutRequestDetailsType setExpressCheckoutRequestDetailsField;
		public SetExpressCheckoutRequestDetailsType SetExpressCheckoutRequestDetails
		{
			get
			{
				return this.setExpressCheckoutRequestDetailsField;
			}
			set
			{
				this.setExpressCheckoutRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public SetExpressCheckoutRequestType(SetExpressCheckoutRequestDetailsType setExpressCheckoutRequestDetails)
	 	{
			this.SetExpressCheckoutRequestDetails = setExpressCheckoutRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public SetExpressCheckoutRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(SetExpressCheckoutRequestDetails != null)
			{
				sb.Append(SetExpressCheckoutRequestDetails.ToXMLString(null,"SetExpressCheckoutRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *A timestamped token by which you identify to PayPal that you
      *are processing this payment with Express Checkout. The token
      *expires after three hours. If you set Token in the
      *SetExpressCheckoutRequest, the value of Token in the
      *response is identical to the value in the request. Character
      *length and limitations: 20 single-byte characters
      */
	public partial class SetExpressCheckoutResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SetExpressCheckoutResponseType()
	 	{
		}


		public SetExpressCheckoutResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Token']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Token = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class ExecuteCheckoutOperationsReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private ExecuteCheckoutOperationsRequestType executeCheckoutOperationsRequestField;
		public ExecuteCheckoutOperationsRequestType ExecuteCheckoutOperationsRequest
		{
			get
			{
				return this.executeCheckoutOperationsRequestField;
			}
			set
			{
				this.executeCheckoutOperationsRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ExecuteCheckoutOperationsReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ExecuteCheckoutOperationsRequest != null)
			{
				sb.Append(ExecuteCheckoutOperationsRequest.ToXMLString(null,"ExecuteCheckoutOperationsRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class ExecuteCheckoutOperationsRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private ExecuteCheckoutOperationsRequestDetailsType executeCheckoutOperationsRequestDetailsField;
		public ExecuteCheckoutOperationsRequestDetailsType ExecuteCheckoutOperationsRequestDetails
		{
			get
			{
				return this.executeCheckoutOperationsRequestDetailsField;
			}
			set
			{
				this.executeCheckoutOperationsRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public ExecuteCheckoutOperationsRequestType(ExecuteCheckoutOperationsRequestDetailsType executeCheckoutOperationsRequestDetails)
	 	{
			this.ExecuteCheckoutOperationsRequestDetails = executeCheckoutOperationsRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public ExecuteCheckoutOperationsRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(ExecuteCheckoutOperationsRequestDetails != null)
			{
				sb.Append(ExecuteCheckoutOperationsRequestDetails.ToXMLString(null,"ExecuteCheckoutOperationsRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class ExecuteCheckoutOperationsResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private ExecuteCheckoutOperationsResponseDetailsType executeCheckoutOperationsResponseDetailsField;
		public ExecuteCheckoutOperationsResponseDetailsType ExecuteCheckoutOperationsResponseDetails
		{
			get
			{
				return this.executeCheckoutOperationsResponseDetailsField;
			}
			set
			{
				this.executeCheckoutOperationsResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ExecuteCheckoutOperationsResponseType()
	 	{
		}


		public ExecuteCheckoutOperationsResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ExecuteCheckoutOperationsResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ExecuteCheckoutOperationsResponseDetails =  new ExecuteCheckoutOperationsResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class GetExpressCheckoutDetailsReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetExpressCheckoutDetailsRequestType getExpressCheckoutDetailsRequestField;
		public GetExpressCheckoutDetailsRequestType GetExpressCheckoutDetailsRequest
		{
			get
			{
				return this.getExpressCheckoutDetailsRequestField;
			}
			set
			{
				this.getExpressCheckoutDetailsRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetExpressCheckoutDetailsReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(GetExpressCheckoutDetailsRequest != null)
			{
				sb.Append(GetExpressCheckoutDetailsRequest.ToXMLString(null,"GetExpressCheckoutDetailsRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *A timestamped token, the value of which was returned by
      *SetExpressCheckoutResponse. RequiredCharacter length and
      *limitations: 20 single-byte characters
      */
	public partial class GetExpressCheckoutDetailsRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetExpressCheckoutDetailsRequestType(string token)
	 	{
			this.Token = token;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetExpressCheckoutDetailsRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(Token != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Token>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Token));
				sb.Append("</").Append(PreferredPrefix).Append(":Token>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetExpressCheckoutDetailsResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetExpressCheckoutDetailsResponseDetailsType getExpressCheckoutDetailsResponseDetailsField;
		public GetExpressCheckoutDetailsResponseDetailsType GetExpressCheckoutDetailsResponseDetails
		{
			get
			{
				return this.getExpressCheckoutDetailsResponseDetailsField;
			}
			set
			{
				this.getExpressCheckoutDetailsResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetExpressCheckoutDetailsResponseType()
	 	{
		}


		public GetExpressCheckoutDetailsResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GetExpressCheckoutDetailsResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GetExpressCheckoutDetailsResponseDetails =  new GetExpressCheckoutDetailsResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class DoExpressCheckoutPaymentReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoExpressCheckoutPaymentRequestType doExpressCheckoutPaymentRequestField;
		public DoExpressCheckoutPaymentRequestType DoExpressCheckoutPaymentRequest
		{
			get
			{
				return this.doExpressCheckoutPaymentRequestField;
			}
			set
			{
				this.doExpressCheckoutPaymentRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoExpressCheckoutPaymentReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(DoExpressCheckoutPaymentRequest != null)
			{
				sb.Append(DoExpressCheckoutPaymentRequest.ToXMLString(null,"DoExpressCheckoutPaymentRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *This flag indicates that the response should include
      *FMFDetails 
      */
	public partial class DoExpressCheckoutPaymentRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoExpressCheckoutPaymentRequestDetailsType doExpressCheckoutPaymentRequestDetailsField;
		public DoExpressCheckoutPaymentRequestDetailsType DoExpressCheckoutPaymentRequestDetails
		{
			get
			{
				return this.doExpressCheckoutPaymentRequestDetailsField;
			}
			set
			{
				this.doExpressCheckoutPaymentRequestDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private int? returnFMFDetailsField;
		public int? ReturnFMFDetails
		{
			get
			{
				return this.returnFMFDetailsField;
			}
			set
			{
				this.returnFMFDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public DoExpressCheckoutPaymentRequestType(DoExpressCheckoutPaymentRequestDetailsType doExpressCheckoutPaymentRequestDetails)
	 	{
			this.DoExpressCheckoutPaymentRequestDetails = doExpressCheckoutPaymentRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public DoExpressCheckoutPaymentRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(DoExpressCheckoutPaymentRequestDetails != null)
			{
				sb.Append(DoExpressCheckoutPaymentRequestDetails.ToXMLString(null,"DoExpressCheckoutPaymentRequestDetails"));
			}
			if(ReturnFMFDetails != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReturnFMFDetails>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReturnFMFDetails));
				sb.Append("</").Append(PreferredPrefix).Append(":ReturnFMFDetails>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class DoExpressCheckoutPaymentResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoExpressCheckoutPaymentResponseDetailsType doExpressCheckoutPaymentResponseDetailsField;
		public DoExpressCheckoutPaymentResponseDetailsType DoExpressCheckoutPaymentResponseDetails
		{
			get
			{
				return this.doExpressCheckoutPaymentResponseDetailsField;
			}
			set
			{
				this.doExpressCheckoutPaymentResponseDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private FMFDetailsType fMFDetailsField;
		public FMFDetailsType FMFDetails
		{
			get
			{
				return this.fMFDetailsField;
			}
			set
			{
				this.fMFDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoExpressCheckoutPaymentResponseType()
	 	{
		}


		public DoExpressCheckoutPaymentResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'DoExpressCheckoutPaymentResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.DoExpressCheckoutPaymentResponseDetails =  new DoExpressCheckoutPaymentResponseDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'FMFDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.FMFDetails =  new FMFDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class DoUATPExpressCheckoutPaymentReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoUATPExpressCheckoutPaymentRequestType doUATPExpressCheckoutPaymentRequestField;
		public DoUATPExpressCheckoutPaymentRequestType DoUATPExpressCheckoutPaymentRequest
		{
			get
			{
				return this.doUATPExpressCheckoutPaymentRequestField;
			}
			set
			{
				this.doUATPExpressCheckoutPaymentRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoUATPExpressCheckoutPaymentReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(DoUATPExpressCheckoutPaymentRequest != null)
			{
				sb.Append(DoUATPExpressCheckoutPaymentRequest.ToXMLString(null,"DoUATPExpressCheckoutPaymentRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class DoUATPExpressCheckoutPaymentRequestType : DoExpressCheckoutPaymentRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public DoUATPExpressCheckoutPaymentRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class DoUATPExpressCheckoutPaymentResponseType : DoExpressCheckoutPaymentResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private UATPDetailsType uATPDetailsField;
		public UATPDetailsType UATPDetails
		{
			get
			{
				return this.uATPDetailsField;
			}
			set
			{
				this.uATPDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoUATPExpressCheckoutPaymentResponseType()
	 	{
		}


		public DoUATPExpressCheckoutPaymentResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'UATPDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.UATPDetails =  new UATPDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class ManagePendingTransactionStatusReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private ManagePendingTransactionStatusRequestType managePendingTransactionStatusRequestField;
		public ManagePendingTransactionStatusRequestType ManagePendingTransactionStatusRequest
		{
			get
			{
				return this.managePendingTransactionStatusRequestField;
			}
			set
			{
				this.managePendingTransactionStatusRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ManagePendingTransactionStatusReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ManagePendingTransactionStatusRequest != null)
			{
				sb.Append(ManagePendingTransactionStatusRequest.ToXMLString(null,"ManagePendingTransactionStatusRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class ManagePendingTransactionStatusRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string transactionIDField;
		public string TransactionID
		{
			get
			{
				return this.transactionIDField;
			}
			set
			{
				this.transactionIDField = value;
			}
		}
		

		/**
          *
		  */
		private FMFPendingTransactionActionType? actionField;
		public FMFPendingTransactionActionType? Action
		{
			get
			{
				return this.actionField;
			}
			set
			{
				this.actionField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public ManagePendingTransactionStatusRequestType(string transactionID, FMFPendingTransactionActionType? action)
	 	{
			this.TransactionID = transactionID;
			this.Action = action;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public ManagePendingTransactionStatusRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(TransactionID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TransactionID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TransactionID));
				sb.Append("</").Append(PreferredPrefix).Append(":TransactionID>");
			}
			if(Action != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Action>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.Action)));
				sb.Append("</").Append(PreferredPrefix).Append(":Action>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class ManagePendingTransactionStatusResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string transactionIDField;
		public string TransactionID
		{
			get
			{
				return this.transactionIDField;
			}
			set
			{
				this.transactionIDField = value;
			}
		}
		

		/**
          *
		  */
		private string statusField;
		public string Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ManagePendingTransactionStatusResponseType()
	 	{
		}


		public ManagePendingTransactionStatusResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TransactionID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TransactionID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Status']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Status = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class DoDirectPaymentReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoDirectPaymentRequestType doDirectPaymentRequestField;
		public DoDirectPaymentRequestType DoDirectPaymentRequest
		{
			get
			{
				return this.doDirectPaymentRequestField;
			}
			set
			{
				this.doDirectPaymentRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoDirectPaymentReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(DoDirectPaymentRequest != null)
			{
				sb.Append(DoDirectPaymentRequest.ToXMLString(null,"DoDirectPaymentRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *This flag indicates that the response should include
      *FMFDetails 
      */
	public partial class DoDirectPaymentRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoDirectPaymentRequestDetailsType doDirectPaymentRequestDetailsField;
		public DoDirectPaymentRequestDetailsType DoDirectPaymentRequestDetails
		{
			get
			{
				return this.doDirectPaymentRequestDetailsField;
			}
			set
			{
				this.doDirectPaymentRequestDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private int? returnFMFDetailsField;
		public int? ReturnFMFDetails
		{
			get
			{
				return this.returnFMFDetailsField;
			}
			set
			{
				this.returnFMFDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public DoDirectPaymentRequestType(DoDirectPaymentRequestDetailsType doDirectPaymentRequestDetails)
	 	{
			this.DoDirectPaymentRequestDetails = doDirectPaymentRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public DoDirectPaymentRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(DoDirectPaymentRequestDetails != null)
			{
				sb.Append(DoDirectPaymentRequestDetails.ToXMLString(null,"DoDirectPaymentRequestDetails"));
			}
			if(ReturnFMFDetails != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReturnFMFDetails>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReturnFMFDetails));
				sb.Append("</").Append(PreferredPrefix).Append(":ReturnFMFDetails>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *The amount of the payment as specified by you on
      *DoDirectPaymentRequest.
      */
	public partial class DoDirectPaymentResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private string aVSCodeField;
		public string AVSCode
		{
			get
			{
				return this.aVSCodeField;
			}
			set
			{
				this.aVSCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string cVV2CodeField;
		public string CVV2Code
		{
			get
			{
				return this.cVV2CodeField;
			}
			set
			{
				this.cVV2CodeField = value;
			}
		}
		

		/**
          *
		  */
		private string transactionIDField;
		public string TransactionID
		{
			get
			{
				return this.transactionIDField;
			}
			set
			{
				this.transactionIDField = value;
			}
		}
		

		/**
          *
		  */
		private PendingStatusCodeType? pendingReasonField;
		public PendingStatusCodeType? PendingReason
		{
			get
			{
				return this.pendingReasonField;
			}
			set
			{
				this.pendingReasonField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentStatusCodeType? paymentStatusField;
		public PaymentStatusCodeType? PaymentStatus
		{
			get
			{
				return this.paymentStatusField;
			}
			set
			{
				this.paymentStatusField = value;
			}
		}
		

		/**
          *
		  */
		private FMFDetailsType fMFDetailsField;
		public FMFDetailsType FMFDetails
		{
			get
			{
				return this.fMFDetailsField;
			}
			set
			{
				this.fMFDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private ThreeDSecureResponseType threeDSecureResponseField;
		public ThreeDSecureResponseType ThreeDSecureResponse
		{
			get
			{
				return this.threeDSecureResponseField;
			}
			set
			{
				this.threeDSecureResponseField = value;
			}
		}
		

		/**
          *
		  */
		private string paymentAdviceCodeField;
		public string PaymentAdviceCode
		{
			get
			{
				return this.paymentAdviceCodeField;
			}
			set
			{
				this.paymentAdviceCodeField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoDirectPaymentResponseType()
	 	{
		}


		public DoDirectPaymentResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Amount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Amount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AVSCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AVSCode = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CVV2Code']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CVV2Code = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TransactionID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TransactionID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PendingReason']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PendingReason = (PendingStatusCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(PendingStatusCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentStatus']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentStatus = (PaymentStatusCodeType)EnumUtils.GetValue(ChildNode.InnerText,typeof(PaymentStatusCodeType));
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'FMFDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.FMFDetails =  new FMFDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ThreeDSecureResponse']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ThreeDSecureResponse =  new ThreeDSecureResponseType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentAdviceCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentAdviceCode = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class DoCancelReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoCancelRequestType doCancelRequestField;
		public DoCancelRequestType DoCancelRequest
		{
			get
			{
				return this.doCancelRequestField;
			}
			set
			{
				this.doCancelRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoCancelReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(DoCancelRequest != null)
			{
				sb.Append(DoCancelRequest.ToXMLString(null,"DoCancelRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Msg Sub Id that was used for the orginal operation. 
      */
	public partial class DoCancelRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string cancelMsgSubIDField;
		public string CancelMsgSubID
		{
			get
			{
				return this.cancelMsgSubIDField;
			}
			set
			{
				this.cancelMsgSubIDField = value;
			}
		}
		

		/**
          *
		  */
		private APIType? aPITypeField;
		public APIType? APIType
		{
			get
			{
				return this.aPITypeField;
			}
			set
			{
				this.aPITypeField = value;
			}
		}
		

		/**
          *
		  */
		private string msgSubIDField;
		public string MsgSubID
		{
			get
			{
				return this.msgSubIDField;
			}
			set
			{
				this.msgSubIDField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public DoCancelRequestType(string cancelMsgSubID, APIType? aPIType)
	 	{
			this.CancelMsgSubID = cancelMsgSubID;
			this.APIType = aPIType;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public DoCancelRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(CancelMsgSubID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CancelMsgSubID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.CancelMsgSubID));
				sb.Append("</").Append(PreferredPrefix).Append(":CancelMsgSubID>");
			}
			if(APIType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":APIType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.APIType)));
				sb.Append("</").Append(PreferredPrefix).Append(":APIType>");
			}
			if(MsgSubID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MsgSubID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.MsgSubID));
				sb.Append("</").Append(PreferredPrefix).Append(":MsgSubID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Return msgsubid back to merchant 
      */
	public partial class DoCancelResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string msgSubIDField;
		public string MsgSubID
		{
			get
			{
				return this.msgSubIDField;
			}
			set
			{
				this.msgSubIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoCancelResponseType()
	 	{
		}


		public DoCancelResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'MsgSubID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.MsgSubID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class DoCaptureReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoCaptureRequestType doCaptureRequestField;
		public DoCaptureRequestType DoCaptureRequest
		{
			get
			{
				return this.doCaptureRequestField;
			}
			set
			{
				this.doCaptureRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoCaptureReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(DoCaptureRequest != null)
			{
				sb.Append(DoCaptureRequest.ToXMLString(null,"DoCaptureRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *The authorization identification number of the payment you
      *want to capture. Required Character length and limits: 19
      *single-byte characters maximum 
      */
	public partial class DoCaptureRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string authorizationIDField;
		public string AuthorizationID
		{
			get
			{
				return this.authorizationIDField;
			}
			set
			{
				this.authorizationIDField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private CompleteCodeType? completeTypeField;
		public CompleteCodeType? CompleteType
		{
			get
			{
				return this.completeTypeField;
			}
			set
			{
				this.completeTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string noteField;
		public string Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}
		

		/**
          *
		  */
		private string invoiceIDField;
		public string InvoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/**
          *
		  */
		private EnhancedDataType enhancedDataField;
		public EnhancedDataType EnhancedData
		{
			get
			{
				return this.enhancedDataField;
			}
			set
			{
				this.enhancedDataField = value;
			}
		}
		

		/**
          *
		  */
		private string descriptorField;
		public string Descriptor
		{
			get
			{
				return this.descriptorField;
			}
			set
			{
				this.descriptorField = value;
			}
		}
		

		/**
          *
		  */
		private MerchantStoreDetailsType merchantStoreDetailsField;
		public MerchantStoreDetailsType MerchantStoreDetails
		{
			get
			{
				return this.merchantStoreDetailsField;
			}
			set
			{
				this.merchantStoreDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string msgSubIDField;
		public string MsgSubID
		{
			get
			{
				return this.msgSubIDField;
			}
			set
			{
				this.msgSubIDField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public DoCaptureRequestType(string authorizationID, BasicAmountType amount, CompleteCodeType? completeType)
	 	{
			this.AuthorizationID = authorizationID;
			this.Amount = amount;
			this.CompleteType = completeType;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public DoCaptureRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(AuthorizationID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AuthorizationID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.AuthorizationID));
				sb.Append("</").Append(PreferredPrefix).Append(":AuthorizationID>");
			}
			if(Amount != null)
			{
				sb.Append(Amount.ToXMLString(PreferredPrefix,"Amount"));
			}
			if(CompleteType != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":CompleteType>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.CompleteType)));
				sb.Append("</").Append(PreferredPrefix).Append(":CompleteType>");
			}
			if(Note != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Note>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Note));
				sb.Append("</").Append(PreferredPrefix).Append(":Note>");
			}
			if(InvoiceID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":InvoiceID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.InvoiceID));
				sb.Append("</").Append(PreferredPrefix).Append(":InvoiceID>");
			}
			if(EnhancedData != null)
			{
				sb.Append(EnhancedData.ToXMLString(null,"EnhancedData"));
			}
			if(Descriptor != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Descriptor>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Descriptor));
				sb.Append("</").Append(PreferredPrefix).Append(":Descriptor>");
			}
			if(MerchantStoreDetails != null)
			{
				sb.Append(MerchantStoreDetails.ToXMLString(null,"MerchantStoreDetails"));
			}
			if(MsgSubID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MsgSubID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.MsgSubID));
				sb.Append("</").Append(PreferredPrefix).Append(":MsgSubID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class DoCaptureResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoCaptureResponseDetailsType doCaptureResponseDetailsField;
		public DoCaptureResponseDetailsType DoCaptureResponseDetails
		{
			get
			{
				return this.doCaptureResponseDetailsField;
			}
			set
			{
				this.doCaptureResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoCaptureResponseType()
	 	{
		}


		public DoCaptureResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'DoCaptureResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.DoCaptureResponseDetails =  new DoCaptureResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class DoReauthorizationReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoReauthorizationRequestType doReauthorizationRequestField;
		public DoReauthorizationRequestType DoReauthorizationRequest
		{
			get
			{
				return this.doReauthorizationRequestField;
			}
			set
			{
				this.doReauthorizationRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoReauthorizationReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(DoReauthorizationRequest != null)
			{
				sb.Append(DoReauthorizationRequest.ToXMLString(null,"DoReauthorizationRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *The value of a previously authorized transaction
      *identification number returned by a PayPal product. You can
      *obtain a buyer's transaction number from the TransactionID
      *element of the PayerInfo structure returned by
      *GetTransactionDetailsResponse. Required Character length and
      *limits: 19 single-byte characters maximum 
      */
	public partial class DoReauthorizationRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string authorizationIDField;
		public string AuthorizationID
		{
			get
			{
				return this.authorizationIDField;
			}
			set
			{
				this.authorizationIDField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private string msgSubIDField;
		public string MsgSubID
		{
			get
			{
				return this.msgSubIDField;
			}
			set
			{
				this.msgSubIDField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public DoReauthorizationRequestType(string authorizationID, BasicAmountType amount)
	 	{
			this.AuthorizationID = authorizationID;
			this.Amount = amount;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public DoReauthorizationRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(AuthorizationID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AuthorizationID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.AuthorizationID));
				sb.Append("</").Append(PreferredPrefix).Append(":AuthorizationID>");
			}
			if(Amount != null)
			{
				sb.Append(Amount.ToXMLString(PreferredPrefix,"Amount"));
			}
			if(MsgSubID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MsgSubID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.MsgSubID));
				sb.Append("</").Append(PreferredPrefix).Append(":MsgSubID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *A new authorization identification number. Character length
      *and limits: 19 single-byte characters 
      */
	public partial class DoReauthorizationResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string authorizationIDField;
		public string AuthorizationID
		{
			get
			{
				return this.authorizationIDField;
			}
			set
			{
				this.authorizationIDField = value;
			}
		}
		

		/**
          *
		  */
		private AuthorizationInfoType authorizationInfoField;
		public AuthorizationInfoType AuthorizationInfo
		{
			get
			{
				return this.authorizationInfoField;
			}
			set
			{
				this.authorizationInfoField = value;
			}
		}
		

		/**
          *
		  */
		private string msgSubIDField;
		public string MsgSubID
		{
			get
			{
				return this.msgSubIDField;
			}
			set
			{
				this.msgSubIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoReauthorizationResponseType()
	 	{
		}


		public DoReauthorizationResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AuthorizationID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AuthorizationID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AuthorizationInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AuthorizationInfo =  new AuthorizationInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'MsgSubID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.MsgSubID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class DoVoidReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoVoidRequestType doVoidRequestField;
		public DoVoidRequestType DoVoidRequest
		{
			get
			{
				return this.doVoidRequestField;
			}
			set
			{
				this.doVoidRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoVoidReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(DoVoidRequest != null)
			{
				sb.Append(DoVoidRequest.ToXMLString(null,"DoVoidRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *The value of the original authorization identification
      *number returned by a PayPal product. If you are voiding a
      *transaction that has been reauthorized, use the ID from the
      *original authorization, and not the reauthorization.
      *Required Character length and limits: 19 single-byte
      *characters 
      */
	public partial class DoVoidRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string authorizationIDField;
		public string AuthorizationID
		{
			get
			{
				return this.authorizationIDField;
			}
			set
			{
				this.authorizationIDField = value;
			}
		}
		

		/**
          *
		  */
		private string noteField;
		public string Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}
		

		/**
          *
		  */
		private string msgSubIDField;
		public string MsgSubID
		{
			get
			{
				return this.msgSubIDField;
			}
			set
			{
				this.msgSubIDField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public DoVoidRequestType(string authorizationID)
	 	{
			this.AuthorizationID = authorizationID;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public DoVoidRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(AuthorizationID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":AuthorizationID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.AuthorizationID));
				sb.Append("</").Append(PreferredPrefix).Append(":AuthorizationID>");
			}
			if(Note != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Note>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Note));
				sb.Append("</").Append(PreferredPrefix).Append(":Note>");
			}
			if(MsgSubID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MsgSubID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.MsgSubID));
				sb.Append("</").Append(PreferredPrefix).Append(":MsgSubID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *The authorization identification number you specified in the
      *request. Character length and limits: 19 single-byte
      *characters 
      */
	public partial class DoVoidResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string authorizationIDField;
		public string AuthorizationID
		{
			get
			{
				return this.authorizationIDField;
			}
			set
			{
				this.authorizationIDField = value;
			}
		}
		

		/**
          *
		  */
		private string msgSubIDField;
		public string MsgSubID
		{
			get
			{
				return this.msgSubIDField;
			}
			set
			{
				this.msgSubIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoVoidResponseType()
	 	{
		}


		public DoVoidResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AuthorizationID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AuthorizationID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'MsgSubID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.MsgSubID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class DoAuthorizationReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoAuthorizationRequestType doAuthorizationRequestField;
		public DoAuthorizationRequestType DoAuthorizationRequest
		{
			get
			{
				return this.doAuthorizationRequestField;
			}
			set
			{
				this.doAuthorizationRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoAuthorizationReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(DoAuthorizationRequest != null)
			{
				sb.Append(DoAuthorizationRequest.ToXMLString(null,"DoAuthorizationRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *The value of the order’s transaction identification number
      *returned by a PayPal product. Required Character length and
      *limits: 19 single-byte characters maximum 
      */
	public partial class DoAuthorizationRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string transactionIDField;
		public string TransactionID
		{
			get
			{
				return this.transactionIDField;
			}
			set
			{
				this.transactionIDField = value;
			}
		}
		

		/**
          *
		  */
		private TransactionEntityType? transactionEntityField;
		public TransactionEntityType? TransactionEntity
		{
			get
			{
				return this.transactionEntityField;
			}
			set
			{
				this.transactionEntityField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private string msgSubIDField;
		public string MsgSubID
		{
			get
			{
				return this.msgSubIDField;
			}
			set
			{
				this.msgSubIDField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public DoAuthorizationRequestType(string transactionID, BasicAmountType amount)
	 	{
			this.TransactionID = transactionID;
			this.Amount = amount;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public DoAuthorizationRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(TransactionID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TransactionID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.TransactionID));
				sb.Append("</").Append(PreferredPrefix).Append(":TransactionID>");
			}
			if(TransactionEntity != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TransactionEntity>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.TransactionEntity)));
				sb.Append("</").Append(PreferredPrefix).Append(":TransactionEntity>");
			}
			if(Amount != null)
			{
				sb.Append(Amount.ToXMLString(PreferredPrefix,"Amount"));
			}
			if(MsgSubID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MsgSubID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.MsgSubID));
				sb.Append("</").Append(PreferredPrefix).Append(":MsgSubID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *An authorization identification number. Character length and
      *limits: 19 single-byte characters 
      */
	public partial class DoAuthorizationResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string transactionIDField;
		public string TransactionID
		{
			get
			{
				return this.transactionIDField;
			}
			set
			{
				this.transactionIDField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private AuthorizationInfoType authorizationInfoField;
		public AuthorizationInfoType AuthorizationInfo
		{
			get
			{
				return this.authorizationInfoField;
			}
			set
			{
				this.authorizationInfoField = value;
			}
		}
		

		/**
          *
		  */
		private string msgSubIDField;
		public string MsgSubID
		{
			get
			{
				return this.msgSubIDField;
			}
			set
			{
				this.msgSubIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoAuthorizationResponseType()
	 	{
		}


		public DoAuthorizationResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'TransactionID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.TransactionID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Amount']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Amount =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AuthorizationInfo']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AuthorizationInfo =  new AuthorizationInfoType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'MsgSubID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.MsgSubID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class DoUATPAuthorizationReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoUATPAuthorizationRequestType doUATPAuthorizationRequestField;
		public DoUATPAuthorizationRequestType DoUATPAuthorizationRequest
		{
			get
			{
				return this.doUATPAuthorizationRequestField;
			}
			set
			{
				this.doUATPAuthorizationRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoUATPAuthorizationReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(DoUATPAuthorizationRequest != null)
			{
				sb.Append(DoUATPAuthorizationRequest.ToXMLString(null,"DoUATPAuthorizationRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *UATP card details Required 
      */
	public partial class DoUATPAuthorizationRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private UATPDetailsType uATPDetailsField;
		public UATPDetailsType UATPDetails
		{
			get
			{
				return this.uATPDetailsField;
			}
			set
			{
				this.uATPDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private TransactionEntityType? transactionEntityField;
		public TransactionEntityType? TransactionEntity
		{
			get
			{
				return this.transactionEntityField;
			}
			set
			{
				this.transactionEntityField = value;
			}
		}
		

		/**
          *
		  */
		private BasicAmountType amountField;
		public BasicAmountType Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private string invoiceIDField;
		public string InvoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/**
          *
		  */
		private string msgSubIDField;
		public string MsgSubID
		{
			get
			{
				return this.msgSubIDField;
			}
			set
			{
				this.msgSubIDField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public DoUATPAuthorizationRequestType(UATPDetailsType uATPDetails, BasicAmountType amount)
	 	{
			this.UATPDetails = uATPDetails;
			this.Amount = amount;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public DoUATPAuthorizationRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(UATPDetails != null)
			{
				sb.Append(UATPDetails.ToXMLString(null,"UATPDetails"));
			}
			if(TransactionEntity != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":TransactionEntity>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(EnumUtils.GetDescription(this.TransactionEntity)));
				sb.Append("</").Append(PreferredPrefix).Append(":TransactionEntity>");
			}
			if(Amount != null)
			{
				sb.Append(Amount.ToXMLString(PreferredPrefix,"Amount"));
			}
			if(InvoiceID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":InvoiceID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.InvoiceID));
				sb.Append("</").Append(PreferredPrefix).Append(":InvoiceID>");
			}
			if(MsgSubID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":MsgSubID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.MsgSubID));
				sb.Append("</").Append(PreferredPrefix).Append(":MsgSubID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Auth Authorization Code. 
      */
	public partial class DoUATPAuthorizationResponseType : DoAuthorizationResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private UATPDetailsType uATPDetailsField;
		public UATPDetailsType UATPDetails
		{
			get
			{
				return this.uATPDetailsField;
			}
			set
			{
				this.uATPDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string authorizationCodeField;
		public string AuthorizationCode
		{
			get
			{
				return this.authorizationCodeField;
			}
			set
			{
				this.authorizationCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string invoiceIDField;
		public string InvoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/**
          *
		  */
		private string msgSubIDField;
		public string MsgSubID
		{
			get
			{
				return this.msgSubIDField;
			}
			set
			{
				this.msgSubIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoUATPAuthorizationResponseType()
	 	{
		}


		public DoUATPAuthorizationResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'UATPDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.UATPDetails =  new UATPDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'AuthorizationCode']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.AuthorizationCode = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'InvoiceID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.InvoiceID = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'MsgSubID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.MsgSubID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class CreateMobilePaymentReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private CreateMobilePaymentRequestType createMobilePaymentRequestField;
		public CreateMobilePaymentRequestType CreateMobilePaymentRequest
		{
			get
			{
				return this.createMobilePaymentRequestField;
			}
			set
			{
				this.createMobilePaymentRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CreateMobilePaymentReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(CreateMobilePaymentRequest != null)
			{
				sb.Append(CreateMobilePaymentRequest.ToXMLString(null,"CreateMobilePaymentRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class CreateMobilePaymentRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private CreateMobilePaymentRequestDetailsType createMobilePaymentRequestDetailsField;
		public CreateMobilePaymentRequestDetailsType CreateMobilePaymentRequestDetails
		{
			get
			{
				return this.createMobilePaymentRequestDetailsField;
			}
			set
			{
				this.createMobilePaymentRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public CreateMobilePaymentRequestType(CreateMobilePaymentRequestDetailsType createMobilePaymentRequestDetails)
	 	{
			this.CreateMobilePaymentRequestDetails = createMobilePaymentRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public CreateMobilePaymentRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(CreateMobilePaymentRequestDetails != null)
			{
				sb.Append(CreateMobilePaymentRequestDetails.ToXMLString(null,"CreateMobilePaymentRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class CreateMobilePaymentResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public CreateMobilePaymentResponseType()
	 	{
		}


		public CreateMobilePaymentResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
	
		}
	}




	/**
      *
      */
	public partial class GetMobileStatusReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetMobileStatusRequestType getMobileStatusRequestField;
		public GetMobileStatusRequestType GetMobileStatusRequest
		{
			get
			{
				return this.getMobileStatusRequestField;
			}
			set
			{
				this.getMobileStatusRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetMobileStatusReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(GetMobileStatusRequest != null)
			{
				sb.Append(GetMobileStatusRequest.ToXMLString(null,"GetMobileStatusRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetMobileStatusRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetMobileStatusRequestDetailsType getMobileStatusRequestDetailsField;
		public GetMobileStatusRequestDetailsType GetMobileStatusRequestDetails
		{
			get
			{
				return this.getMobileStatusRequestDetailsField;
			}
			set
			{
				this.getMobileStatusRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetMobileStatusRequestType(GetMobileStatusRequestDetailsType getMobileStatusRequestDetails)
	 	{
			this.GetMobileStatusRequestDetails = getMobileStatusRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetMobileStatusRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(GetMobileStatusRequestDetails != null)
			{
				sb.Append(GetMobileStatusRequestDetails.ToXMLString(null,"GetMobileStatusRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *Indicates whether the phone is activated for mobile payments
      *
      */
	public partial class GetMobileStatusResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private int? isActivatedField;
		public int? IsActivated
		{
			get
			{
				return this.isActivatedField;
			}
			set
			{
				this.isActivatedField = value;
			}
		}
		

		/**
          *
		  */
		private int? paymentPendingField;
		public int? PaymentPending
		{
			get
			{
				return this.paymentPendingField;
			}
			set
			{
				this.paymentPendingField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetMobileStatusResponseType()
	 	{
		}


		public GetMobileStatusResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'IsActivated']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.IsActivated = System.Convert.ToInt32(ChildNode.InnerText);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'PaymentPending']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.PaymentPending = System.Convert.ToInt32(ChildNode.InnerText);
			}
	
		}
	}




	/**
      *
      */
	public partial class SetMobileCheckoutReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private SetMobileCheckoutRequestType setMobileCheckoutRequestField;
		public SetMobileCheckoutRequestType SetMobileCheckoutRequest
		{
			get
			{
				return this.setMobileCheckoutRequestField;
			}
			set
			{
				this.setMobileCheckoutRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SetMobileCheckoutReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(SetMobileCheckoutRequest != null)
			{
				sb.Append(SetMobileCheckoutRequest.ToXMLString(null,"SetMobileCheckoutRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class SetMobileCheckoutRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private SetMobileCheckoutRequestDetailsType setMobileCheckoutRequestDetailsField;
		public SetMobileCheckoutRequestDetailsType SetMobileCheckoutRequestDetails
		{
			get
			{
				return this.setMobileCheckoutRequestDetailsField;
			}
			set
			{
				this.setMobileCheckoutRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public SetMobileCheckoutRequestType(SetMobileCheckoutRequestDetailsType setMobileCheckoutRequestDetails)
	 	{
			this.SetMobileCheckoutRequestDetails = setMobileCheckoutRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public SetMobileCheckoutRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(SetMobileCheckoutRequestDetails != null)
			{
				sb.Append(SetMobileCheckoutRequestDetails.ToXMLString(null,"SetMobileCheckoutRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *A timestamped token by which you identify to PayPal that you
      *are processing this payment with Mobile Checkout. The token
      *expires after three hours. Character length and limitations:
      *20 single-byte characters
      */
	public partial class SetMobileCheckoutResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SetMobileCheckoutResponseType()
	 	{
		}


		public SetMobileCheckoutResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Token']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Token = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class DoMobileCheckoutPaymentReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoMobileCheckoutPaymentRequestType doMobileCheckoutPaymentRequestField;
		public DoMobileCheckoutPaymentRequestType DoMobileCheckoutPaymentRequest
		{
			get
			{
				return this.doMobileCheckoutPaymentRequestField;
			}
			set
			{
				this.doMobileCheckoutPaymentRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoMobileCheckoutPaymentReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(DoMobileCheckoutPaymentRequest != null)
			{
				sb.Append(DoMobileCheckoutPaymentRequest.ToXMLString(null,"DoMobileCheckoutPaymentRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *A timestamped token, the value of which was returned by
      *SetMobileCheckoutResponse. RequiredCharacter length and
      *limitations: 20 single-byte characters
      */
	public partial class DoMobileCheckoutPaymentRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public DoMobileCheckoutPaymentRequestType(string token)
	 	{
			this.Token = token;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public DoMobileCheckoutPaymentRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(Token != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Token>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Token));
				sb.Append("</").Append(PreferredPrefix).Append(":Token>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class DoMobileCheckoutPaymentResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoMobileCheckoutPaymentResponseDetailsType doMobileCheckoutPaymentResponseDetailsField;
		public DoMobileCheckoutPaymentResponseDetailsType DoMobileCheckoutPaymentResponseDetails
		{
			get
			{
				return this.doMobileCheckoutPaymentResponseDetailsField;
			}
			set
			{
				this.doMobileCheckoutPaymentResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoMobileCheckoutPaymentResponseType()
	 	{
		}


		public DoMobileCheckoutPaymentResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'DoMobileCheckoutPaymentResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.DoMobileCheckoutPaymentResponseDetails =  new DoMobileCheckoutPaymentResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class GetBalanceReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetBalanceRequestType getBalanceRequestField;
		public GetBalanceRequestType GetBalanceRequest
		{
			get
			{
				return this.getBalanceRequestField;
			}
			set
			{
				this.getBalanceRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetBalanceReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(GetBalanceRequest != null)
			{
				sb.Append(GetBalanceRequest.ToXMLString(null,"GetBalanceRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetBalanceRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string returnAllCurrenciesField;
		public string ReturnAllCurrencies
		{
			get
			{
				return this.returnAllCurrenciesField;
			}
			set
			{
				this.returnAllCurrenciesField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetBalanceRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(ReturnAllCurrencies != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReturnAllCurrencies>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReturnAllCurrencies));
				sb.Append("</").Append(PreferredPrefix).Append(":ReturnAllCurrencies>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetBalanceResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BasicAmountType balanceField;
		public BasicAmountType Balance
		{
			get
			{
				return this.balanceField;
			}
			set
			{
				this.balanceField = value;
			}
		}
		

		/**
          *
		  */
		private string balanceTimeStampField;
		public string BalanceTimeStamp
		{
			get
			{
				return this.balanceTimeStampField;
			}
			set
			{
				this.balanceTimeStampField = value;
			}
		}
		

		/**
          *
		  */
		private List<BasicAmountType> balanceHoldingsField = new List<BasicAmountType>();
		public List<BasicAmountType> BalanceHoldings
		{
			get
			{
				return this.balanceHoldingsField;
			}
			set
			{
				this.balanceHoldingsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetBalanceResponseType()
	 	{
		}


		public GetBalanceResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Balance']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Balance =  new BasicAmountType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BalanceTimeStamp']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BalanceTimeStamp = ChildNode.InnerText;
			}
			ChildNodeList = xmlNode.SelectNodes("*[local-name() = 'BalanceHoldings']");
			if (ChildNodeList != null && ChildNodeList.Count > 0)
			{
				for(int i = 0; i < ChildNodeList.Count; i++)
				{
					XmlNode subNode = ChildNodeList.Item(i);
					this.BalanceHoldings.Add(new BasicAmountType(subNode));
				}
			}
	
		}
	}




	/**
      *
      */
	public partial class SetCustomerBillingAgreementReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private SetCustomerBillingAgreementRequestType setCustomerBillingAgreementRequestField;
		public SetCustomerBillingAgreementRequestType SetCustomerBillingAgreementRequest
		{
			get
			{
				return this.setCustomerBillingAgreementRequestField;
			}
			set
			{
				this.setCustomerBillingAgreementRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SetCustomerBillingAgreementReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(SetCustomerBillingAgreementRequest != null)
			{
				sb.Append(SetCustomerBillingAgreementRequest.ToXMLString(null,"SetCustomerBillingAgreementRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class SetCustomerBillingAgreementRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private SetCustomerBillingAgreementRequestDetailsType setCustomerBillingAgreementRequestDetailsField;
		public SetCustomerBillingAgreementRequestDetailsType SetCustomerBillingAgreementRequestDetails
		{
			get
			{
				return this.setCustomerBillingAgreementRequestDetailsField;
			}
			set
			{
				this.setCustomerBillingAgreementRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public SetCustomerBillingAgreementRequestType(SetCustomerBillingAgreementRequestDetailsType setCustomerBillingAgreementRequestDetails)
	 	{
			this.SetCustomerBillingAgreementRequestDetails = setCustomerBillingAgreementRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public SetCustomerBillingAgreementRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(SetCustomerBillingAgreementRequestDetails != null)
			{
				sb.Append(SetCustomerBillingAgreementRequestDetails.ToXMLString(null,"SetCustomerBillingAgreementRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class SetCustomerBillingAgreementResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SetCustomerBillingAgreementResponseType()
	 	{
		}


		public SetCustomerBillingAgreementResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Token']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Token = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class GetBillingAgreementCustomerDetailsReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetBillingAgreementCustomerDetailsRequestType getBillingAgreementCustomerDetailsRequestField;
		public GetBillingAgreementCustomerDetailsRequestType GetBillingAgreementCustomerDetailsRequest
		{
			get
			{
				return this.getBillingAgreementCustomerDetailsRequestField;
			}
			set
			{
				this.getBillingAgreementCustomerDetailsRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetBillingAgreementCustomerDetailsReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(GetBillingAgreementCustomerDetailsRequest != null)
			{
				sb.Append(GetBillingAgreementCustomerDetailsRequest.ToXMLString(null,"GetBillingAgreementCustomerDetailsRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetBillingAgreementCustomerDetailsRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetBillingAgreementCustomerDetailsRequestType(string token)
	 	{
			this.Token = token;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetBillingAgreementCustomerDetailsRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(Token != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Token>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Token));
				sb.Append("</").Append(PreferredPrefix).Append(":Token>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetBillingAgreementCustomerDetailsResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetBillingAgreementCustomerDetailsResponseDetailsType getBillingAgreementCustomerDetailsResponseDetailsField;
		public GetBillingAgreementCustomerDetailsResponseDetailsType GetBillingAgreementCustomerDetailsResponseDetails
		{
			get
			{
				return this.getBillingAgreementCustomerDetailsResponseDetailsField;
			}
			set
			{
				this.getBillingAgreementCustomerDetailsResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetBillingAgreementCustomerDetailsResponseType()
	 	{
		}


		public GetBillingAgreementCustomerDetailsResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GetBillingAgreementCustomerDetailsResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GetBillingAgreementCustomerDetailsResponseDetails =  new GetBillingAgreementCustomerDetailsResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class CreateBillingAgreementReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private CreateBillingAgreementRequestType createBillingAgreementRequestField;
		public CreateBillingAgreementRequestType CreateBillingAgreementRequest
		{
			get
			{
				return this.createBillingAgreementRequestField;
			}
			set
			{
				this.createBillingAgreementRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CreateBillingAgreementReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(CreateBillingAgreementRequest != null)
			{
				sb.Append(CreateBillingAgreementRequest.ToXMLString(null,"CreateBillingAgreementRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class CreateBillingAgreementRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string tokenField;
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public CreateBillingAgreementRequestType(string token)
	 	{
			this.Token = token;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public CreateBillingAgreementRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(Token != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":Token>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.Token));
				sb.Append("</").Append(PreferredPrefix).Append(":Token>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class CreateBillingAgreementResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string billingAgreementIDField;
		public string BillingAgreementID
		{
			get
			{
				return this.billingAgreementIDField;
			}
			set
			{
				this.billingAgreementIDField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CreateBillingAgreementResponseType()
	 	{
		}


		public CreateBillingAgreementResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillingAgreementID']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillingAgreementID = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class DoReferenceTransactionReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoReferenceTransactionRequestType doReferenceTransactionRequestField;
		public DoReferenceTransactionRequestType DoReferenceTransactionRequest
		{
			get
			{
				return this.doReferenceTransactionRequestField;
			}
			set
			{
				this.doReferenceTransactionRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoReferenceTransactionReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(DoReferenceTransactionRequest != null)
			{
				sb.Append(DoReferenceTransactionRequest.ToXMLString(null,"DoReferenceTransactionRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *This flag indicates that the response should include
      *FMFDetails 
      */
	public partial class DoReferenceTransactionRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoReferenceTransactionRequestDetailsType doReferenceTransactionRequestDetailsField;
		public DoReferenceTransactionRequestDetailsType DoReferenceTransactionRequestDetails
		{
			get
			{
				return this.doReferenceTransactionRequestDetailsField;
			}
			set
			{
				this.doReferenceTransactionRequestDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private int? returnFMFDetailsField;
		public int? ReturnFMFDetails
		{
			get
			{
				return this.returnFMFDetailsField;
			}
			set
			{
				this.returnFMFDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public DoReferenceTransactionRequestType(DoReferenceTransactionRequestDetailsType doReferenceTransactionRequestDetails)
	 	{
			this.DoReferenceTransactionRequestDetails = doReferenceTransactionRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public DoReferenceTransactionRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(DoReferenceTransactionRequestDetails != null)
			{
				sb.Append(DoReferenceTransactionRequestDetails.ToXMLString(null,"DoReferenceTransactionRequestDetails"));
			}
			if(ReturnFMFDetails != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ReturnFMFDetails>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ReturnFMFDetails));
				sb.Append("</").Append(PreferredPrefix).Append(":ReturnFMFDetails>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class DoReferenceTransactionResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoReferenceTransactionResponseDetailsType doReferenceTransactionResponseDetailsField;
		public DoReferenceTransactionResponseDetailsType DoReferenceTransactionResponseDetails
		{
			get
			{
				return this.doReferenceTransactionResponseDetailsField;
			}
			set
			{
				this.doReferenceTransactionResponseDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private FMFDetailsType fMFDetailsField;
		public FMFDetailsType FMFDetails
		{
			get
			{
				return this.fMFDetailsField;
			}
			set
			{
				this.fMFDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoReferenceTransactionResponseType()
	 	{
		}


		public DoReferenceTransactionResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'DoReferenceTransactionResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.DoReferenceTransactionResponseDetails =  new DoReferenceTransactionResponseDetailsType(ChildNode);
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'FMFDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.FMFDetails =  new FMFDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class DoNonReferencedCreditReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoNonReferencedCreditRequestType doNonReferencedCreditRequestField;
		public DoNonReferencedCreditRequestType DoNonReferencedCreditRequest
		{
			get
			{
				return this.doNonReferencedCreditRequestField;
			}
			set
			{
				this.doNonReferencedCreditRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoNonReferencedCreditReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(DoNonReferencedCreditRequest != null)
			{
				sb.Append(DoNonReferencedCreditRequest.ToXMLString(null,"DoNonReferencedCreditRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class DoNonReferencedCreditRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoNonReferencedCreditRequestDetailsType doNonReferencedCreditRequestDetailsField;
		public DoNonReferencedCreditRequestDetailsType DoNonReferencedCreditRequestDetails
		{
			get
			{
				return this.doNonReferencedCreditRequestDetailsField;
			}
			set
			{
				this.doNonReferencedCreditRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public DoNonReferencedCreditRequestType(DoNonReferencedCreditRequestDetailsType doNonReferencedCreditRequestDetails)
	 	{
			this.DoNonReferencedCreditRequestDetails = doNonReferencedCreditRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public DoNonReferencedCreditRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(DoNonReferencedCreditRequestDetails != null)
			{
				sb.Append(DoNonReferencedCreditRequestDetails.ToXMLString(null,"DoNonReferencedCreditRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class DoNonReferencedCreditResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private DoNonReferencedCreditResponseDetailsType doNonReferencedCreditResponseDetailsField;
		public DoNonReferencedCreditResponseDetailsType DoNonReferencedCreditResponseDetails
		{
			get
			{
				return this.doNonReferencedCreditResponseDetailsField;
			}
			set
			{
				this.doNonReferencedCreditResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DoNonReferencedCreditResponseType()
	 	{
		}


		public DoNonReferencedCreditResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'DoNonReferencedCreditResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.DoNonReferencedCreditResponseDetails =  new DoNonReferencedCreditResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class CreateRecurringPaymentsProfileReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private CreateRecurringPaymentsProfileRequestType createRecurringPaymentsProfileRequestField;
		public CreateRecurringPaymentsProfileRequestType CreateRecurringPaymentsProfileRequest
		{
			get
			{
				return this.createRecurringPaymentsProfileRequestField;
			}
			set
			{
				this.createRecurringPaymentsProfileRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CreateRecurringPaymentsProfileReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(CreateRecurringPaymentsProfileRequest != null)
			{
				sb.Append(CreateRecurringPaymentsProfileRequest.ToXMLString(null,"CreateRecurringPaymentsProfileRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class CreateRecurringPaymentsProfileRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private CreateRecurringPaymentsProfileRequestDetailsType createRecurringPaymentsProfileRequestDetailsField;
		public CreateRecurringPaymentsProfileRequestDetailsType CreateRecurringPaymentsProfileRequestDetails
		{
			get
			{
				return this.createRecurringPaymentsProfileRequestDetailsField;
			}
			set
			{
				this.createRecurringPaymentsProfileRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CreateRecurringPaymentsProfileRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(CreateRecurringPaymentsProfileRequestDetails != null)
			{
				sb.Append(CreateRecurringPaymentsProfileRequestDetails.ToXMLString(null,"CreateRecurringPaymentsProfileRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class CreateRecurringPaymentsProfileResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private CreateRecurringPaymentsProfileResponseDetailsType createRecurringPaymentsProfileResponseDetailsField;
		public CreateRecurringPaymentsProfileResponseDetailsType CreateRecurringPaymentsProfileResponseDetails
		{
			get
			{
				return this.createRecurringPaymentsProfileResponseDetailsField;
			}
			set
			{
				this.createRecurringPaymentsProfileResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CreateRecurringPaymentsProfileResponseType()
	 	{
		}


		public CreateRecurringPaymentsProfileResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'CreateRecurringPaymentsProfileResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.CreateRecurringPaymentsProfileResponseDetails =  new CreateRecurringPaymentsProfileResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class GetRecurringPaymentsProfileDetailsReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetRecurringPaymentsProfileDetailsRequestType getRecurringPaymentsProfileDetailsRequestField;
		public GetRecurringPaymentsProfileDetailsRequestType GetRecurringPaymentsProfileDetailsRequest
		{
			get
			{
				return this.getRecurringPaymentsProfileDetailsRequestField;
			}
			set
			{
				this.getRecurringPaymentsProfileDetailsRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetRecurringPaymentsProfileDetailsReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(GetRecurringPaymentsProfileDetailsRequest != null)
			{
				sb.Append(GetRecurringPaymentsProfileDetailsRequest.ToXMLString(null,"GetRecurringPaymentsProfileDetailsRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetRecurringPaymentsProfileDetailsRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string profileIDField;
		public string ProfileID
		{
			get
			{
				return this.profileIDField;
			}
			set
			{
				this.profileIDField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetRecurringPaymentsProfileDetailsRequestType(string profileID)
	 	{
			this.ProfileID = profileID;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetRecurringPaymentsProfileDetailsRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(ProfileID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ProfileID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ProfileID));
				sb.Append("</").Append(PreferredPrefix).Append(":ProfileID>");
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetRecurringPaymentsProfileDetailsResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetRecurringPaymentsProfileDetailsResponseDetailsType getRecurringPaymentsProfileDetailsResponseDetailsField;
		public GetRecurringPaymentsProfileDetailsResponseDetailsType GetRecurringPaymentsProfileDetailsResponseDetails
		{
			get
			{
				return this.getRecurringPaymentsProfileDetailsResponseDetailsField;
			}
			set
			{
				this.getRecurringPaymentsProfileDetailsResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetRecurringPaymentsProfileDetailsResponseType()
	 	{
		}


		public GetRecurringPaymentsProfileDetailsResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'GetRecurringPaymentsProfileDetailsResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.GetRecurringPaymentsProfileDetailsResponseDetails =  new GetRecurringPaymentsProfileDetailsResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class ManageRecurringPaymentsProfileStatusReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private ManageRecurringPaymentsProfileStatusRequestType manageRecurringPaymentsProfileStatusRequestField;
		public ManageRecurringPaymentsProfileStatusRequestType ManageRecurringPaymentsProfileStatusRequest
		{
			get
			{
				return this.manageRecurringPaymentsProfileStatusRequestField;
			}
			set
			{
				this.manageRecurringPaymentsProfileStatusRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ManageRecurringPaymentsProfileStatusReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ManageRecurringPaymentsProfileStatusRequest != null)
			{
				sb.Append(ManageRecurringPaymentsProfileStatusRequest.ToXMLString(null,"ManageRecurringPaymentsProfileStatusRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class ManageRecurringPaymentsProfileStatusRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private ManageRecurringPaymentsProfileStatusRequestDetailsType manageRecurringPaymentsProfileStatusRequestDetailsField;
		public ManageRecurringPaymentsProfileStatusRequestDetailsType ManageRecurringPaymentsProfileStatusRequestDetails
		{
			get
			{
				return this.manageRecurringPaymentsProfileStatusRequestDetailsField;
			}
			set
			{
				this.manageRecurringPaymentsProfileStatusRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ManageRecurringPaymentsProfileStatusRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(ManageRecurringPaymentsProfileStatusRequestDetails != null)
			{
				sb.Append(ManageRecurringPaymentsProfileStatusRequestDetails.ToXMLString(null,"ManageRecurringPaymentsProfileStatusRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class ManageRecurringPaymentsProfileStatusResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private ManageRecurringPaymentsProfileStatusResponseDetailsType manageRecurringPaymentsProfileStatusResponseDetailsField;
		public ManageRecurringPaymentsProfileStatusResponseDetailsType ManageRecurringPaymentsProfileStatusResponseDetails
		{
			get
			{
				return this.manageRecurringPaymentsProfileStatusResponseDetailsField;
			}
			set
			{
				this.manageRecurringPaymentsProfileStatusResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ManageRecurringPaymentsProfileStatusResponseType()
	 	{
		}


		public ManageRecurringPaymentsProfileStatusResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ManageRecurringPaymentsProfileStatusResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ManageRecurringPaymentsProfileStatusResponseDetails =  new ManageRecurringPaymentsProfileStatusResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class BillOutstandingAmountReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BillOutstandingAmountRequestType billOutstandingAmountRequestField;
		public BillOutstandingAmountRequestType BillOutstandingAmountRequest
		{
			get
			{
				return this.billOutstandingAmountRequestField;
			}
			set
			{
				this.billOutstandingAmountRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BillOutstandingAmountReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(BillOutstandingAmountRequest != null)
			{
				sb.Append(BillOutstandingAmountRequest.ToXMLString(null,"BillOutstandingAmountRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class BillOutstandingAmountRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BillOutstandingAmountRequestDetailsType billOutstandingAmountRequestDetailsField;
		public BillOutstandingAmountRequestDetailsType BillOutstandingAmountRequestDetails
		{
			get
			{
				return this.billOutstandingAmountRequestDetailsField;
			}
			set
			{
				this.billOutstandingAmountRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BillOutstandingAmountRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(BillOutstandingAmountRequestDetails != null)
			{
				sb.Append(BillOutstandingAmountRequestDetails.ToXMLString(null,"BillOutstandingAmountRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class BillOutstandingAmountResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private BillOutstandingAmountResponseDetailsType billOutstandingAmountResponseDetailsField;
		public BillOutstandingAmountResponseDetailsType BillOutstandingAmountResponseDetails
		{
			get
			{
				return this.billOutstandingAmountResponseDetailsField;
			}
			set
			{
				this.billOutstandingAmountResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BillOutstandingAmountResponseType()
	 	{
		}


		public BillOutstandingAmountResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'BillOutstandingAmountResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.BillOutstandingAmountResponseDetails =  new BillOutstandingAmountResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class UpdateRecurringPaymentsProfileReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private UpdateRecurringPaymentsProfileRequestType updateRecurringPaymentsProfileRequestField;
		public UpdateRecurringPaymentsProfileRequestType UpdateRecurringPaymentsProfileRequest
		{
			get
			{
				return this.updateRecurringPaymentsProfileRequestField;
			}
			set
			{
				this.updateRecurringPaymentsProfileRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public UpdateRecurringPaymentsProfileReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(UpdateRecurringPaymentsProfileRequest != null)
			{
				sb.Append(UpdateRecurringPaymentsProfileRequest.ToXMLString(null,"UpdateRecurringPaymentsProfileRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class UpdateRecurringPaymentsProfileRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private UpdateRecurringPaymentsProfileRequestDetailsType updateRecurringPaymentsProfileRequestDetailsField;
		public UpdateRecurringPaymentsProfileRequestDetailsType UpdateRecurringPaymentsProfileRequestDetails
		{
			get
			{
				return this.updateRecurringPaymentsProfileRequestDetailsField;
			}
			set
			{
				this.updateRecurringPaymentsProfileRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public UpdateRecurringPaymentsProfileRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(UpdateRecurringPaymentsProfileRequestDetails != null)
			{
				sb.Append(UpdateRecurringPaymentsProfileRequestDetails.ToXMLString(null,"UpdateRecurringPaymentsProfileRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class UpdateRecurringPaymentsProfileResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private UpdateRecurringPaymentsProfileResponseDetailsType updateRecurringPaymentsProfileResponseDetailsField;
		public UpdateRecurringPaymentsProfileResponseDetailsType UpdateRecurringPaymentsProfileResponseDetails
		{
			get
			{
				return this.updateRecurringPaymentsProfileResponseDetailsField;
			}
			set
			{
				this.updateRecurringPaymentsProfileResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public UpdateRecurringPaymentsProfileResponseType()
	 	{
		}


		public UpdateRecurringPaymentsProfileResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'UpdateRecurringPaymentsProfileResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.UpdateRecurringPaymentsProfileResponseDetails =  new UpdateRecurringPaymentsProfileResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class GetPalDetailsReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private GetPalDetailsRequestType getPalDetailsRequestField;
		public GetPalDetailsRequestType GetPalDetailsRequest
		{
			get
			{
				return this.getPalDetailsRequestField;
			}
			set
			{
				this.getPalDetailsRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetPalDetailsReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(GetPalDetailsRequest != null)
			{
				sb.Append(GetPalDetailsRequest.ToXMLString(null,"GetPalDetailsRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetPalDetailsRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public GetPalDetailsRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class GetPalDetailsResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string palField;
		public string Pal
		{
			get
			{
				return this.palField;
			}
			set
			{
				this.palField = value;
			}
		}
		

		/**
          *
		  */
		private string localeField;
		public string Locale
		{
			get
			{
				return this.localeField;
			}
			set
			{
				this.localeField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetPalDetailsResponseType()
	 	{
		}


		public GetPalDetailsResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Pal']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Pal = ChildNode.InnerText;
			}
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'Locale']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.Locale = ChildNode.InnerText;
			}
	
		}
	}




	/**
      *
      */
	public partial class ReverseTransactionReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private ReverseTransactionRequestType reverseTransactionRequestField;
		public ReverseTransactionRequestType ReverseTransactionRequest
		{
			get
			{
				return this.reverseTransactionRequestField;
			}
			set
			{
				this.reverseTransactionRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ReverseTransactionReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ReverseTransactionRequest != null)
			{
				sb.Append(ReverseTransactionRequest.ToXMLString(null,"ReverseTransactionRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class ReverseTransactionRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private ReverseTransactionRequestDetailsType reverseTransactionRequestDetailsField;
		public ReverseTransactionRequestDetailsType ReverseTransactionRequestDetails
		{
			get
			{
				return this.reverseTransactionRequestDetailsField;
			}
			set
			{
				this.reverseTransactionRequestDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public ReverseTransactionRequestType(ReverseTransactionRequestDetailsType reverseTransactionRequestDetails)
	 	{
			this.ReverseTransactionRequestDetails = reverseTransactionRequestDetails;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public ReverseTransactionRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(ReverseTransactionRequestDetails != null)
			{
				sb.Append(ReverseTransactionRequestDetails.ToXMLString(null,"ReverseTransactionRequestDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class ReverseTransactionResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private ReverseTransactionResponseDetailsType reverseTransactionResponseDetailsField;
		public ReverseTransactionResponseDetailsType ReverseTransactionResponseDetails
		{
			get
			{
				return this.reverseTransactionResponseDetailsField;
			}
			set
			{
				this.reverseTransactionResponseDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ReverseTransactionResponseType()
	 	{
		}


		public ReverseTransactionResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
			ChildNode = xmlNode.SelectSingleNode("*[local-name() = 'ReverseTransactionResponseDetails']");
			if(ChildNode != null && !DeserializationUtils.isWhiteSpaceNode(ChildNode))
			{
				this.ReverseTransactionResponseDetails =  new ReverseTransactionResponseDetailsType(ChildNode);
			}
	
		}
	}




	/**
      *
      */
	public partial class ExternalRememberMeOptOutReq	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private ExternalRememberMeOptOutRequestType externalRememberMeOptOutRequestField;
		public ExternalRememberMeOptOutRequestType ExternalRememberMeOptOutRequest
		{
			get
			{
				return this.externalRememberMeOptOutRequestField;
			}
			set
			{
				this.externalRememberMeOptOutRequestField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ExternalRememberMeOptOutReq()
	 	{
		}


		public string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			if(ExternalRememberMeOptOutRequest != null)
			{
				sb.Append(ExternalRememberMeOptOutRequest.ToXMLString(null,"ExternalRememberMeOptOutRequest"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *The merchant passes in the ExternalRememberMeID to identify
      *the user to opt out. This is a 17-character alphanumeric
      *(encrypted) string that identifies the buyer's remembered
      *login with a merchant and has meaning only to the merchant.
      *Required 
      */
	public partial class ExternalRememberMeOptOutRequestType : AbstractRequestType	{
		// Namespace for the type
		private const string NameSpace = "urn:ebay:api:PayPalAPI";

		// Prefix associated with the namespace
		private const string PreferredPrefix = "ns";
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
          *
		  */
		private string externalRememberMeIDField;
		public string ExternalRememberMeID
		{
			get
			{
				return this.externalRememberMeIDField;
			}
			set
			{
				this.externalRememberMeIDField = value;
			}
		}
		

		/**
          *
		  */
		private ExternalRememberMeOwnerDetailsType externalRememberMeOwnerDetailsField;
		public ExternalRememberMeOwnerDetailsType ExternalRememberMeOwnerDetails
		{
			get
			{
				return this.externalRememberMeOwnerDetailsField;
			}
			set
			{
				this.externalRememberMeOwnerDetailsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public ExternalRememberMeOptOutRequestType(string externalRememberMeID)
	 	{
			this.ExternalRememberMeID = externalRememberMeID;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public ExternalRememberMeOptOutRequestType()
	 	{
		}


		public new string ToXMLString(string prefix, string name)
		{
			StringBuilder sb = new StringBuilder();
			if(name != null)
			{
				if(prefix != null)
				{
					sb.Append("<").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("<").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			sb.Append(base.ToXMLString(prefix, null));
			if(ExternalRememberMeID != null)
			{
				sb.Append("<").Append(PreferredPrefix).Append(":ExternalRememberMeID>").Append(DeserializationUtils.escapeInvalidXmlCharsRegex(this.ExternalRememberMeID));
				sb.Append("</").Append(PreferredPrefix).Append(":ExternalRememberMeID>");
			}
			if(ExternalRememberMeOwnerDetails != null)
			{
				sb.Append(ExternalRememberMeOwnerDetails.ToXMLString(PreferredPrefix,"ExternalRememberMeOwnerDetails"));
			}
			if (name != null)
			{
				if (prefix != null)
				{
					sb.Append("</").Append(prefix).Append(":").Append(name).Append(">");
				}
				else
				{
					sb.Append("</").Append(PreferredPrefix).Append(":").Append(name).Append(">");
				}
			}
			return sb.ToString();
		}

	}




	/**
      *
      */
	public partial class ExternalRememberMeOptOutResponseType : AbstractResponseType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/**
	 	  * Default Constructor
	 	  */
	 	public ExternalRememberMeOptOutResponseType()
	 	{
		}


		public ExternalRememberMeOptOutResponseType(XmlNode xmlNode) : base(xmlNode)
		{
			XmlNode ChildNode = null;
			XmlNodeList ChildNodeList = null;
	
		}
	}





}