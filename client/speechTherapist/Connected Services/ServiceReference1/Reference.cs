﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 16.0.30623.0
// 
namespace speechTherapist.ServiceReference1 {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="documents", Namespace="http://schemas.datacontract.org/2004/07/model")]
    public partial class documents : speechTherapist.ServiceReference1.baseEntity {
        
        private int code_documentField;
        
        private string location_documentField;
        
        private speechTherapist.ServiceReference1.metupal metupalField;
        
        private string name_documentField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int code_document {
            get {
                return this.code_documentField;
            }
            set {
                if ((this.code_documentField.Equals(value) != true)) {
                    this.code_documentField = value;
                    this.RaisePropertyChanged("code_document");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string location_document {
            get {
                return this.location_documentField;
            }
            set {
                if ((object.ReferenceEquals(this.location_documentField, value) != true)) {
                    this.location_documentField = value;
                    this.RaisePropertyChanged("location_document");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public speechTherapist.ServiceReference1.metupal metupal {
            get {
                return this.metupalField;
            }
            set {
                if ((object.ReferenceEquals(this.metupalField, value) != true)) {
                    this.metupalField = value;
                    this.RaisePropertyChanged("metupal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name_document {
            get {
                return this.name_documentField;
            }
            set {
                if ((object.ReferenceEquals(this.name_documentField, value) != true)) {
                    this.name_documentField = value;
                    this.RaisePropertyChanged("name_document");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="baseEntity", Namespace="http://schemas.datacontract.org/2004/07/model")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(speechTherapist.ServiceReference1.metupal))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(speechTherapist.ServiceReference1.problem))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(speechTherapist.ServiceReference1.problemForMetupal))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(speechTherapist.ServiceReference1.single_treatment))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(speechTherapist.ServiceReference1.summingOfSeries))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(speechTherapist.ServiceReference1.treatment))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(speechTherapist.ServiceReference1.documents))]
    public partial class baseEntity : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="metupal", Namespace="http://schemas.datacontract.org/2004/07/model")]
    public partial class metupal : speechTherapist.ServiceReference1.baseEntity {
        
        private System.DateTime communication_dateField;
        
        private System.DateTime date_birthField;
        
        private string family_nameField;
        
        private string id_metupalField;
        
        private string kupat_cholimField;
        
        private long notesField;
        
        private string phone_numberField;
        
        private string private_nameField;
        
        private string reason_turningField;
        
        private string statusField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime communication_date {
            get {
                return this.communication_dateField;
            }
            set {
                if ((this.communication_dateField.Equals(value) != true)) {
                    this.communication_dateField = value;
                    this.RaisePropertyChanged("communication_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date_birth {
            get {
                return this.date_birthField;
            }
            set {
                if ((this.date_birthField.Equals(value) != true)) {
                    this.date_birthField = value;
                    this.RaisePropertyChanged("date_birth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string family_name {
            get {
                return this.family_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.family_nameField, value) != true)) {
                    this.family_nameField = value;
                    this.RaisePropertyChanged("family_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id_metupal {
            get {
                return this.id_metupalField;
            }
            set {
                if ((object.ReferenceEquals(this.id_metupalField, value) != true)) {
                    this.id_metupalField = value;
                    this.RaisePropertyChanged("id_metupal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string kupat_cholim {
            get {
                return this.kupat_cholimField;
            }
            set {
                if ((object.ReferenceEquals(this.kupat_cholimField, value) != true)) {
                    this.kupat_cholimField = value;
                    this.RaisePropertyChanged("kupat_cholim");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long notes {
            get {
                return this.notesField;
            }
            set {
                if ((this.notesField.Equals(value) != true)) {
                    this.notesField = value;
                    this.RaisePropertyChanged("notes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string phone_number {
            get {
                return this.phone_numberField;
            }
            set {
                if ((object.ReferenceEquals(this.phone_numberField, value) != true)) {
                    this.phone_numberField = value;
                    this.RaisePropertyChanged("phone_number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string private_name {
            get {
                return this.private_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.private_nameField, value) != true)) {
                    this.private_nameField = value;
                    this.RaisePropertyChanged("private_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string reason_turning {
            get {
                return this.reason_turningField;
            }
            set {
                if ((object.ReferenceEquals(this.reason_turningField, value) != true)) {
                    this.reason_turningField = value;
                    this.RaisePropertyChanged("reason_turning");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string status {
            get {
                return this.statusField;
            }
            set {
                if ((object.ReferenceEquals(this.statusField, value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="problem", Namespace="http://schemas.datacontract.org/2004/07/model")]
    public partial class problem : speechTherapist.ServiceReference1.baseEntity {
        
        private int code_problemField;
        
        private string name_problemField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int code_problem {
            get {
                return this.code_problemField;
            }
            set {
                if ((this.code_problemField.Equals(value) != true)) {
                    this.code_problemField = value;
                    this.RaisePropertyChanged("code_problem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name_problem {
            get {
                return this.name_problemField;
            }
            set {
                if ((object.ReferenceEquals(this.name_problemField, value) != true)) {
                    this.name_problemField = value;
                    this.RaisePropertyChanged("name_problem");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="problemForMetupal", Namespace="http://schemas.datacontract.org/2004/07/model")]
    public partial class problemForMetupal : speechTherapist.ServiceReference1.baseEntity {
        
        private speechTherapist.ServiceReference1.metupal metupalField;
        
        private long notesField;
        
        private speechTherapist.ServiceReference1.problem problemField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public speechTherapist.ServiceReference1.metupal metupal {
            get {
                return this.metupalField;
            }
            set {
                if ((object.ReferenceEquals(this.metupalField, value) != true)) {
                    this.metupalField = value;
                    this.RaisePropertyChanged("metupal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long notes {
            get {
                return this.notesField;
            }
            set {
                if ((this.notesField.Equals(value) != true)) {
                    this.notesField = value;
                    this.RaisePropertyChanged("notes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public speechTherapist.ServiceReference1.problem problem {
            get {
                return this.problemField;
            }
            set {
                if ((object.ReferenceEquals(this.problemField, value) != true)) {
                    this.problemField = value;
                    this.RaisePropertyChanged("problem");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="single_treatment", Namespace="http://schemas.datacontract.org/2004/07/model")]
    public partial class single_treatment : speechTherapist.ServiceReference1.baseEntity {
        
        private int code_single_treatmentField;
        
        private System.DateTime date_single_treatmentField;
        
        private System.DateTime hourField;
        
        private string how_paidField;
        
        private bool is_paidField;
        
        private speechTherapist.ServiceReference1.metupal metupalField;
        
        private int num_minutesField;
        
        private string statusField;
        
        private int sum_of_paymentField;
        
        private long the_treatmentField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int code_single_treatment {
            get {
                return this.code_single_treatmentField;
            }
            set {
                if ((this.code_single_treatmentField.Equals(value) != true)) {
                    this.code_single_treatmentField = value;
                    this.RaisePropertyChanged("code_single_treatment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date_single_treatment {
            get {
                return this.date_single_treatmentField;
            }
            set {
                if ((this.date_single_treatmentField.Equals(value) != true)) {
                    this.date_single_treatmentField = value;
                    this.RaisePropertyChanged("date_single_treatment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime hour {
            get {
                return this.hourField;
            }
            set {
                if ((this.hourField.Equals(value) != true)) {
                    this.hourField = value;
                    this.RaisePropertyChanged("hour");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string how_paid {
            get {
                return this.how_paidField;
            }
            set {
                if ((object.ReferenceEquals(this.how_paidField, value) != true)) {
                    this.how_paidField = value;
                    this.RaisePropertyChanged("how_paid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool is_paid {
            get {
                return this.is_paidField;
            }
            set {
                if ((this.is_paidField.Equals(value) != true)) {
                    this.is_paidField = value;
                    this.RaisePropertyChanged("is_paid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public speechTherapist.ServiceReference1.metupal metupal {
            get {
                return this.metupalField;
            }
            set {
                if ((object.ReferenceEquals(this.metupalField, value) != true)) {
                    this.metupalField = value;
                    this.RaisePropertyChanged("metupal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int num_minutes {
            get {
                return this.num_minutesField;
            }
            set {
                if ((this.num_minutesField.Equals(value) != true)) {
                    this.num_minutesField = value;
                    this.RaisePropertyChanged("num_minutes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string status {
            get {
                return this.statusField;
            }
            set {
                if ((object.ReferenceEquals(this.statusField, value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int sum_of_payment {
            get {
                return this.sum_of_paymentField;
            }
            set {
                if ((this.sum_of_paymentField.Equals(value) != true)) {
                    this.sum_of_paymentField = value;
                    this.RaisePropertyChanged("sum_of_payment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long the_treatment {
            get {
                return this.the_treatmentField;
            }
            set {
                if ((this.the_treatmentField.Equals(value) != true)) {
                    this.the_treatmentField = value;
                    this.RaisePropertyChanged("the_treatment");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="summingOfSeries", Namespace="http://schemas.datacontract.org/2004/07/model")]
    public partial class summingOfSeries : speechTherapist.ServiceReference1.baseEntity {
        
        private int code_seriesField;
        
        private System.DateTime date_testField;
        
        private long discrabtion_first_stateField;
        
        private bool is_formField;
        
        private bool is_testingField;
        
        private speechTherapist.ServiceReference1.metupal metupalField;
        
        private int num_minutesField;
        
        private int number_meatingField;
        
        private int number_meating_certifiedField;
        
        private int priceForMeatingField;
        
        private long the_goalsField;
        
        private long tretmentField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int code_series {
            get {
                return this.code_seriesField;
            }
            set {
                if ((this.code_seriesField.Equals(value) != true)) {
                    this.code_seriesField = value;
                    this.RaisePropertyChanged("code_series");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date_test {
            get {
                return this.date_testField;
            }
            set {
                if ((this.date_testField.Equals(value) != true)) {
                    this.date_testField = value;
                    this.RaisePropertyChanged("date_test");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long discrabtion_first_state {
            get {
                return this.discrabtion_first_stateField;
            }
            set {
                if ((this.discrabtion_first_stateField.Equals(value) != true)) {
                    this.discrabtion_first_stateField = value;
                    this.RaisePropertyChanged("discrabtion_first_state");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool is_form {
            get {
                return this.is_formField;
            }
            set {
                if ((this.is_formField.Equals(value) != true)) {
                    this.is_formField = value;
                    this.RaisePropertyChanged("is_form");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool is_testing {
            get {
                return this.is_testingField;
            }
            set {
                if ((this.is_testingField.Equals(value) != true)) {
                    this.is_testingField = value;
                    this.RaisePropertyChanged("is_testing");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public speechTherapist.ServiceReference1.metupal metupal {
            get {
                return this.metupalField;
            }
            set {
                if ((object.ReferenceEquals(this.metupalField, value) != true)) {
                    this.metupalField = value;
                    this.RaisePropertyChanged("metupal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int num_minutes {
            get {
                return this.num_minutesField;
            }
            set {
                if ((this.num_minutesField.Equals(value) != true)) {
                    this.num_minutesField = value;
                    this.RaisePropertyChanged("num_minutes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int number_meating {
            get {
                return this.number_meatingField;
            }
            set {
                if ((this.number_meatingField.Equals(value) != true)) {
                    this.number_meatingField = value;
                    this.RaisePropertyChanged("number_meating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int number_meating_certified {
            get {
                return this.number_meating_certifiedField;
            }
            set {
                if ((this.number_meating_certifiedField.Equals(value) != true)) {
                    this.number_meating_certifiedField = value;
                    this.RaisePropertyChanged("number_meating_certified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int priceForMeating {
            get {
                return this.priceForMeatingField;
            }
            set {
                if ((this.priceForMeatingField.Equals(value) != true)) {
                    this.priceForMeatingField = value;
                    this.RaisePropertyChanged("priceForMeating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long the_goals {
            get {
                return this.the_goalsField;
            }
            set {
                if ((this.the_goalsField.Equals(value) != true)) {
                    this.the_goalsField = value;
                    this.RaisePropertyChanged("the_goals");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long tretment {
            get {
                return this.tretmentField;
            }
            set {
                if ((this.tretmentField.Equals(value) != true)) {
                    this.tretmentField = value;
                    this.RaisePropertyChanged("tretment");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="treatment", Namespace="http://schemas.datacontract.org/2004/07/model")]
    public partial class treatment : speechTherapist.ServiceReference1.baseEntity {
        
        private int code_meatingField;
        
        private System.DateTime date_treatmentField;
        
        private System.DateTime hour_treatmentField;
        
        private string how_paidField;
        
        private bool is_paidField;
        
        private speechTherapist.ServiceReference1.metupal metupalField;
        
        private int num_treatmentField;
        
        private speechTherapist.ServiceReference1.summingOfSeries seriesField;
        
        private string status_treatmentField;
        
        private long the_treatmentField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int code_meating {
            get {
                return this.code_meatingField;
            }
            set {
                if ((this.code_meatingField.Equals(value) != true)) {
                    this.code_meatingField = value;
                    this.RaisePropertyChanged("code_meating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date_treatment {
            get {
                return this.date_treatmentField;
            }
            set {
                if ((this.date_treatmentField.Equals(value) != true)) {
                    this.date_treatmentField = value;
                    this.RaisePropertyChanged("date_treatment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime hour_treatment {
            get {
                return this.hour_treatmentField;
            }
            set {
                if ((this.hour_treatmentField.Equals(value) != true)) {
                    this.hour_treatmentField = value;
                    this.RaisePropertyChanged("hour_treatment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string how_paid {
            get {
                return this.how_paidField;
            }
            set {
                if ((object.ReferenceEquals(this.how_paidField, value) != true)) {
                    this.how_paidField = value;
                    this.RaisePropertyChanged("how_paid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool is_paid {
            get {
                return this.is_paidField;
            }
            set {
                if ((this.is_paidField.Equals(value) != true)) {
                    this.is_paidField = value;
                    this.RaisePropertyChanged("is_paid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public speechTherapist.ServiceReference1.metupal metupal {
            get {
                return this.metupalField;
            }
            set {
                if ((object.ReferenceEquals(this.metupalField, value) != true)) {
                    this.metupalField = value;
                    this.RaisePropertyChanged("metupal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int num_treatment {
            get {
                return this.num_treatmentField;
            }
            set {
                if ((this.num_treatmentField.Equals(value) != true)) {
                    this.num_treatmentField = value;
                    this.RaisePropertyChanged("num_treatment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public speechTherapist.ServiceReference1.summingOfSeries series {
            get {
                return this.seriesField;
            }
            set {
                if ((object.ReferenceEquals(this.seriesField, value) != true)) {
                    this.seriesField = value;
                    this.RaisePropertyChanged("series");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string status_treatment {
            get {
                return this.status_treatmentField;
            }
            set {
                if ((object.ReferenceEquals(this.status_treatmentField, value) != true)) {
                    this.status_treatmentField = value;
                    this.RaisePropertyChanged("status_treatment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long the_treatment {
            get {
                return this.the_treatmentField;
            }
            set {
                if ((this.the_treatmentField.Equals(value) != true)) {
                    this.the_treatmentField = value;
                    this.RaisePropertyChanged("the_treatment");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllDocuments", ReplyAction="http://tempuri.org/IService1/GetAllDocumentsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<speechTherapist.ServiceReference1.documents>> GetAllDocumentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllMetupal", ReplyAction="http://tempuri.org/IService1/GetAllMetupalResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<speechTherapist.ServiceReference1.metupal>> GetAllMetupalAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllProblem", ReplyAction="http://tempuri.org/IService1/GetAllProblemResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<speechTherapist.ServiceReference1.problem>> GetAllProblemAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllProblemForMetupal", ReplyAction="http://tempuri.org/IService1/GetAllProblemForMetupalResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<speechTherapist.ServiceReference1.problemForMetupal>> GetAllProblemForMetupalAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllSingle_treatment", ReplyAction="http://tempuri.org/IService1/GetAllSingle_treatmentResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<speechTherapist.ServiceReference1.single_treatment>> GetAllSingle_treatmentAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllSummingOfSeries", ReplyAction="http://tempuri.org/IService1/GetAllSummingOfSeriesResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<speechTherapist.ServiceReference1.summingOfSeries>> GetAllSummingOfSeriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllTreatment", ReplyAction="http://tempuri.org/IService1/GetAllTreatmentResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<speechTherapist.ServiceReference1.treatment>> GetAllTreatmentAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : speechTherapist.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<speechTherapist.ServiceReference1.IService1>, speechTherapist.ServiceReference1.IService1 {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1Client() : 
                base(Service1Client.GetDefaultBinding(), Service1Client.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService1.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<speechTherapist.ServiceReference1.documents>> GetAllDocumentsAsync() {
            return base.Channel.GetAllDocumentsAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<speechTherapist.ServiceReference1.metupal>> GetAllMetupalAsync() {
            return base.Channel.GetAllMetupalAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<speechTherapist.ServiceReference1.problem>> GetAllProblemAsync() {
            return base.Channel.GetAllProblemAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<speechTherapist.ServiceReference1.problemForMetupal>> GetAllProblemForMetupalAsync() {
            return base.Channel.GetAllProblemForMetupalAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<speechTherapist.ServiceReference1.single_treatment>> GetAllSingle_treatmentAsync() {
            return base.Channel.GetAllSingle_treatmentAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<speechTherapist.ServiceReference1.summingOfSeries>> GetAllSummingOfSeriesAsync() {
            return base.Channel.GetAllSummingOfSeriesAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<speechTherapist.ServiceReference1.treatment>> GetAllTreatmentAsync() {
            return base.Channel.GetAllTreatmentAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/sharat_speech_therapist/Service1/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return Service1Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return Service1Client.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IService1,
        }
    }
}
