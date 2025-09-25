namespace Finyx.Shared.Constants
{
    public static class TemplateConstants
    {
        public const string TEMPLATES_FOLDER = "Templates/PDF";
        public const string REPORTS_FOLDER = "Templates/PDF/Reports";
        public const string DOCUMENTS_FOLDER = "Templates/PDF/Documents";
        public const string FORMS_FOLDER = "Templates/PDF/Forms";
        public const string CERTIFICATES_FOLDER = "Templates/PDF/Certificates";

        public static class TemplateNames
        {
            public const string INVOICE_TEMPLATE = "InvoiceTemplate";
            public const string USER_REPORT_TEMPLATE = "UserReportTemplate";
            public const string CONTRACT_TEMPLATE = "ContractTemplate";
            public const string APPLICATION_FORM_TEMPLATE = "ApplicationFormTemplate";
        }

        public static class Placeholders
        {
            public const string DATE = "[DATE]";
            public const string AMOUNT = "[AMOUNT]";
            public const string USER_NAME = "[USER_NAME]";
            public const string REPORT_DATE = "[REPORT_DATE]";
            public const string TOTAL_USERS = "[TOTAL_USERS]";
            public const string ACTIVE_USERS = "[ACTIVE_USERS]";
            public const string INACTIVE_USERS = "[INACTIVE_USERS]";
            public const string CONTRACT_DATE = "[CONTRACT_DATE]";
            public const string PARTY_1_NAME = "[PARTY_1_NAME]";
            public const string PARTY_2_NAME = "[PARTY_2_NAME]";
            public const string TERM_1 = "[TERM_1]";
            public const string TERM_2 = "[TERM_2]";
            public const string TERM_3 = "[TERM_3]";
            public const string SIGNATURE = "[SIGNATURE]";
            public const string APPLICANT_NAME = "[APPLICANT_NAME]";
            public const string EMAIL = "[EMAIL]";
            public const string PHONE = "[PHONE]";
            public const string ADDRESS = "[ADDRESS]";
            public const string APPLICATION_TYPE = "[APPLICATION_TYPE]";
            public const string REASON = "[REASON]";
            public const string APPLICATION_DATE = "[APPLICATION_DATE]";
        }
    }
}
