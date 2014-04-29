﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeFluentEntities.Bencher
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Tuesday, 18 March 2014 16:33.
    // Build:1.0.61214.0764
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0764")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DataObjectAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, UserName={UserName}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.NameTypeConverter))]
    public partial class ErrorLog : System.ICloneable, System.IComparable, System.IComparable<CodeFluentEntities.Bencher.ErrorLog>, CodeFluent.Runtime.ICodeFluentEntity, System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable<CodeFluentEntities.Bencher.ErrorLog>
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private CodeFluent.Runtime.CodeFluentEntityState _entityState;
        
        private int _errorLogID = -1;
        
        private System.DateTime _errorTime = CodeFluentPersistence.DefaultDateTimeValue;
        
        private string _userName = default(string);
        
        private int _errorNumber = CodeFluentPersistence.DefaultInt32Value;
        
        private System.Nullable<int> _errorSeverity = null;
        
        private System.Nullable<int> _errorState = null;
        
        private string _errorProcedure = default(string);
        
        private System.Nullable<int> _errorLine = null;
        
        private string _errorMessage = default(string);
        
        public ErrorLog()
        {
            this._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
        }
        
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RaisePropertyChangedEvents
        {
            get
            {
                return this._raisePropertyChangedEvents;
            }
            set
            {
                this._raisePropertyChangedEvents = value;
            }
        }
        
        public virtual string EntityKey
        {
            get
            {
                return this.ErrorLogID.ToString();
            }
            set
            {
                this.ErrorLogID = ((int)(ConvertUtilities.ChangeType(value, typeof(int), -1)));
            }
        }
        
        public virtual string EntityDisplayName
        {
            get
            {
                return this.UserName;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(((int)(-1)))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(int))]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public int ErrorLogID
        {
            get
            {
                return this._errorLogID;
            }
            set
            {
                this._errorLogID = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ErrorLogID"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.DateTime))]
        public System.DateTime ErrorTime
        {
            get
            {
                return this._errorTime;
            }
            set
            {
                this._errorTime = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ErrorTime"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string UserName
        {
            get
            {
                return this._userName;
            }
            set
            {
                this._userName = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("UserName"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultInt32Value)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(int))]
        public int ErrorNumber
        {
            get
            {
                return this._errorNumber;
            }
            set
            {
                this._errorNumber = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ErrorNumber"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> ErrorSeverity
        {
            get
            {
                return this._errorSeverity;
            }
            set
            {
                this._errorSeverity = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ErrorSeverity"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> ErrorState
        {
            get
            {
                return this._errorState;
            }
            set
            {
                this._errorState = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ErrorState"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string ErrorProcedure
        {
            get
            {
                return this._errorProcedure;
            }
            set
            {
                this._errorProcedure = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ErrorProcedure"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> ErrorLine
        {
            get
            {
                return this._errorLine;
            }
            set
            {
                this._errorLine = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ErrorLine"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string ErrorMessage
        {
            get
            {
                return this._errorMessage;
            }
            set
            {
                this._errorMessage = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ErrorMessage"));
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.Error
        {
            get
            {
                return this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.this[string columnName]
        {
            get
            {
                return CodeFluentPersistence.ValidateMember(System.Globalization.CultureInfo.CurrentCulture, this, columnName, null);
            }
        }
        
        public virtual CodeFluent.Runtime.CodeFluentEntityState EntityState
        {
            get
            {
                return this._entityState;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<CodeFluent.Runtime.CodeFluentEntityState>.Default.Equals(value, this.EntityState) == true))
                {
                    return;
                }
                this._entityState = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("EntityState"));
            }
        }
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        [field:System.NonSerializedAttribute()]
        public event CodeFluent.Runtime.CodeFluentEntityActionEventHandler EntityAction;
        
        protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((this.RaisePropertyChangedEvents == false))
            {
                return;
            }
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, e);
            }
        }
        
        protected virtual void OnEntityAction(CodeFluent.Runtime.CodeFluentEntityActionEventArgs e)
        {
            if ((this.EntityAction != null))
            {
                this.EntityAction(this, e);
            }
        }
        
        public virtual bool Equals(CodeFluentEntities.Bencher.ErrorLog errorLog)
        {
            if ((errorLog == null))
            {
                return false;
            }
            if ((this.ErrorLogID == -1))
            {
                return base.Equals(errorLog);
            }
            return (this.ErrorLogID.Equals(errorLog.ErrorLogID) == true);
        }
        
        public override int GetHashCode()
        {
            return this._errorLogID;
        }
        
        public override bool Equals(object obj)
        {
            CodeFluentEntities.Bencher.ErrorLog errorLog = null;
			errorLog = obj as CodeFluentEntities.Bencher.ErrorLog;
            return this.Equals(errorLog);
        }
        
        int System.IComparable.CompareTo(object value)
        {
            CodeFluentEntities.Bencher.ErrorLog errorLog = null;
errorLog = value as CodeFluentEntities.Bencher.ErrorLog;
            if ((errorLog == null))
            {
                throw new System.ArgumentException("value");
            }
            int localCompareTo = this.CompareTo(errorLog);
            return localCompareTo;
        }
        
        public virtual int CompareTo(CodeFluentEntities.Bencher.ErrorLog errorLog)
        {
            if ((errorLog == null))
            {
                throw new System.ArgumentNullException("errorLog");
            }
            int localCompareTo = this.ErrorLogID.CompareTo(errorLog.ErrorLogID);
            return localCompareTo;
        }
        
        public virtual string Validate(System.Globalization.CultureInfo culture)
        {
            return CodeFluentPersistence.Validate(culture, this, null);
        }
        
        public virtual void Validate(System.Globalization.CultureInfo culture, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validating, true, results);
            evt.Culture = culture;
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                string externalValidate;
                if ((evt.Argument != null))
                {
                    externalValidate = evt.Argument.ToString();
                }
                else
                {
                    externalValidate = CodeFluentEntities.Bencher.Resources.Manager.GetStringWithDefault(culture, "CodeFluentEntities.Bencher.ErrorLog.ExternalValidate", "Type \'CodeFluentEntities.Bencher.ErrorLog\' cannot be validated.", null);
                }
                CodeFluentPersistence.AddValidationError(results, externalValidate);
            }
            CodeFluentPersistence.ValidateMember(culture, results, this, null);
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validated, false, results));
        }
        
        public void Validate()
        {
            string var = this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            if ((var != null))
            {
                throw new CodeFluent.Runtime.CodeFluentValidationException(var);
            }
        }
        
        string CodeFluent.Runtime.ICodeFluentValidator.Validate(System.Globalization.CultureInfo culture)
        {
            string localValidate = this.Validate(culture);
            return localValidate;
        }
        
        void CodeFluent.Runtime.ICodeFluentMemberValidator.Validate(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            this.ValidateMember(culture, memberName, results);
        }
        
        public virtual bool Delete()
        {
            bool ret = false;
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleting, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return ret;
            }
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Deleted))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "ErrorLog", "Delete");
            persistence.AddRawParameter("@ErrorLogID", this.ErrorLogID);
            persistence.ExecuteNonQuery();
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleted, false, false));
            ret = true;
            return ret;
        }
        
        protected virtual void ReadRecord(System.Data.IDataReader reader, CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.Properties) 
                        == 0) 
                        == false))
            {
                this._errorLogID = CodeFluentPersistence.GetReaderValue(reader, "ErrorLogID", ((int)(-1)));
                this._errorTime = CodeFluentPersistence.GetReaderValue(reader, "ErrorTime", ((System.DateTime)(CodeFluentPersistence.DefaultDateTimeValue)));
                this._userName = CodeFluentPersistence.GetReaderValue(reader, "UserName", ((string)(default(string))));
                this._errorNumber = CodeFluentPersistence.GetReaderValue(reader, "ErrorNumber", ((int)(CodeFluentPersistence.DefaultInt32Value)));
                this._errorSeverity = CodeFluentPersistence.GetReaderValue<int>(reader, "ErrorSeverity");
                this._errorState = CodeFluentPersistence.GetReaderValue<int>(reader, "ErrorState");
                this._errorProcedure = CodeFluentPersistence.GetReaderValue(reader, "ErrorProcedure", ((string)(default(string))));
                this._errorLine = CodeFluentPersistence.GetReaderValue<int>(reader, "ErrorLine");
                this._errorMessage = CodeFluentPersistence.GetReaderValue(reader, "ErrorMessage", ((string)(default(string))));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecord, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecord(System.Data.IDataReader reader)
        {
            this.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
        }
        
        protected virtual void ReadRecordOnSave(System.Data.IDataReader reader)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            this._errorLogID = CodeFluentPersistence.GetReaderValue(reader, "ErrorLogID", ((int)(-1)));
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave(System.Data.IDataReader reader)
        {
            this.ReadRecordOnSave(reader);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.ErrorLog Load(int errorLogID)
        {
            if ((errorLogID == -1))
            {
                return null;
            }
            CodeFluentEntities.Bencher.ErrorLog errorLog = new CodeFluentEntities.Bencher.ErrorLog();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "ErrorLog", "Load");
            persistence.AddRawParameter("@ErrorLogID", errorLogID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    errorLog.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    errorLog.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return errorLog;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return null;
        }
        
        public virtual bool Reload(CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            bool ret = false;
            if ((this.ErrorLogID == -1))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "ErrorLog", "Load");
            persistence.AddRawParameter("@ErrorLogID", this.ErrorLogID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecord(reader, options);
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    ret = true;
                }
                else
                {
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return ret;
        }
        
        protected virtual bool BaseSave(bool force)
        {
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted))
            {
                this.Delete();
                return false;
            }
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saving, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return false;
            }
            CodeFluentPersistence.ThrowIfDeleted(this);
            this.Validate();
            if (((force == false) 
                        && (this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Unchanged)))
            {
                return false;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "ErrorLog", "Save");
            persistence.AddRawParameter("@ErrorLogID", this.ErrorLogID);
            persistence.AddRawParameter("@ErrorTime", this.ErrorTime);
            persistence.AddRawParameter("@UserName", this.UserName);
            persistence.AddRawParameter("@ErrorNumber", this.ErrorNumber);
            persistence.AddParameter("@ErrorSeverity", this.ErrorSeverity);
            persistence.AddParameter("@ErrorState", this.ErrorState);
            persistence.AddRawParameter("@ErrorProcedure", this.ErrorProcedure);
            persistence.AddParameter("@ErrorLine", this.ErrorLine);
            persistence.AddRawParameter("@ErrorMessage", this.ErrorMessage);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecordOnSave(reader);
                }
                CodeFluentPersistence.NextResults(reader);
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saved, false, false));
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
            return true;
        }
        
        public virtual bool Save()
        {
            bool localSave = this.BaseSave(false);
            return localSave;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(CodeFluentEntities.Bencher.ErrorLog errorLog)
        {
            if ((errorLog == null))
            {
                return false;
            }
            bool ret = errorLog.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(CodeFluentEntities.Bencher.ErrorLog errorLog)
        {
            bool ret = CodeFluentEntities.Bencher.ErrorLog.Save(errorLog);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(CodeFluentEntities.Bencher.ErrorLog errorLog)
        {
            if ((errorLog == null))
            {
                return false;
            }
            bool ret = errorLog.Delete();
            return ret;
        }
        
        public string Trace()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture);
            System.CodeDom.Compiler.IndentedTextWriter writer = new System.CodeDom.Compiler.IndentedTextWriter(stringWriter);
            this.BaseTrace(writer);
            writer.Flush();
            ((System.IDisposable)(writer)).Dispose();
            ((System.IDisposable)(stringWriter)).Dispose();
            string sr = stringBuilder.ToString();
            return sr;
        }
        
        void CodeFluent.Runtime.ICodeFluentObject.Trace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            this.BaseTrace(writer);
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write("ErrorLogID=");
            writer.Write(this.ErrorLogID);
            writer.Write(",");
            writer.Write("ErrorTime=");
            writer.Write(this.ErrorTime);
            writer.Write(",");
            writer.Write("UserName=");
            writer.Write(this.UserName);
            writer.Write(",");
            writer.Write("ErrorNumber=");
            writer.Write(this.ErrorNumber);
            writer.Write(",");
            writer.Write("ErrorSeverity=");
            writer.Write(this.ErrorSeverity);
            writer.Write(",");
            writer.Write("ErrorState=");
            writer.Write(this.ErrorState);
            writer.Write(",");
            writer.Write("ErrorProcedure=");
            writer.Write(this.ErrorProcedure);
            writer.Write(",");
            writer.Write("ErrorLine=");
            writer.Write(this.ErrorLine);
            writer.Write(",");
            writer.Write("ErrorMessage=");
            writer.Write(this.ErrorMessage);
            writer.Write(", EntityState=");
            writer.Write(this.EntityState);
            writer.Write("]");
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.ErrorLog LoadByEntityKey(string key)
        {
            if ((key == string.Empty))
            {
                return null;
            }
            CodeFluentEntities.Bencher.ErrorLog errorLog;
            int var = ((int)(ConvertUtilities.ChangeType(key, typeof(int), -1)));
            errorLog = CodeFluentEntities.Bencher.ErrorLog.Load(var);
            return errorLog;
        }
        
        protected virtual void ValidateMember(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
        }
        
        public CodeFluentEntities.Bencher.ErrorLog Clone(bool deep)
        {
            CodeFluentEntities.Bencher.ErrorLog errorLog = new CodeFluentEntities.Bencher.ErrorLog();
            this.CopyTo(errorLog, deep);
            return errorLog;
        }
        
        public CodeFluentEntities.Bencher.ErrorLog Clone()
        {
            CodeFluentEntities.Bencher.ErrorLog localClone = this.Clone(true);
            return localClone;
        }
        
        object System.ICloneable.Clone()
        {
            object localClone = this.Clone();
            return localClone;
        }
        
        public virtual void CopyFrom(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            if ((dict.Contains("ErrorLogID") == true))
            {
                this.ErrorLogID = ((int)(ConvertUtilities.ChangeType(dict["ErrorLogID"], typeof(int), -1)));
            }
            if ((dict.Contains("ErrorProcedure") == true))
            {
                this.ErrorProcedure = ((string)(ConvertUtilities.ChangeType(dict["ErrorProcedure"], typeof(string), default(string))));
            }
            if ((dict.Contains("ErrorState") == true))
            {
                this.ErrorState = ((System.Nullable<System.Int32>)(ConvertUtilities.ChangeType(dict["ErrorState"], typeof(System.Nullable<System.Int32>), null)));
            }
            if ((dict.Contains("ErrorMessage") == true))
            {
                this.ErrorMessage = ((string)(ConvertUtilities.ChangeType(dict["ErrorMessage"], typeof(string), default(string))));
            }
            if ((dict.Contains("ErrorLine") == true))
            {
                this.ErrorLine = ((System.Nullable<System.Int32>)(ConvertUtilities.ChangeType(dict["ErrorLine"], typeof(System.Nullable<System.Int32>), null)));
            }
            if ((dict.Contains("UserName") == true))
            {
                this.UserName = ((string)(ConvertUtilities.ChangeType(dict["UserName"], typeof(string), default(string))));
            }
            if ((dict.Contains("ErrorTime") == true))
            {
                this.ErrorTime = ((System.DateTime)(ConvertUtilities.ChangeType(dict["ErrorTime"], typeof(System.DateTime), CodeFluentPersistence.DefaultDateTimeValue)));
            }
            if ((dict.Contains("ErrorSeverity") == true))
            {
                this.ErrorSeverity = ((System.Nullable<System.Int32>)(ConvertUtilities.ChangeType(dict["ErrorSeverity"], typeof(System.Nullable<System.Int32>), null)));
            }
            if ((dict.Contains("ErrorNumber") == true))
            {
                this.ErrorNumber = ((int)(ConvertUtilities.ChangeType(dict["ErrorNumber"], typeof(int), CodeFluentPersistence.DefaultInt32Value)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict));
        }
        
        public virtual void CopyTo(CodeFluentEntities.Bencher.ErrorLog errorLog, bool deep)
        {
            if ((errorLog == null))
            {
                throw new System.ArgumentNullException("errorLog");
            }
            errorLog.ErrorLogID = this.ErrorLogID;
            errorLog.ErrorProcedure = this.ErrorProcedure;
            errorLog.ErrorState = this.ErrorState;
            errorLog.ErrorMessage = this.ErrorMessage;
            errorLog.ErrorLine = this.ErrorLine;
            errorLog.UserName = this.UserName;
            errorLog.ErrorTime = this.ErrorTime;
            errorLog.ErrorSeverity = this.ErrorSeverity;
            errorLog.ErrorNumber = this.ErrorNumber;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, errorLog));
        }
        
        public virtual void CopyTo(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            dict["ErrorLogID"] = this.ErrorLogID;
            dict["ErrorProcedure"] = this.ErrorProcedure;
            dict["ErrorState"] = this.ErrorState;
            dict["ErrorMessage"] = this.ErrorMessage;
            dict["ErrorLine"] = this.ErrorLine;
            dict["UserName"] = this.UserName;
            dict["ErrorTime"] = this.ErrorTime;
            dict["ErrorSeverity"] = this.ErrorSeverity;
            dict["ErrorNumber"] = this.ErrorNumber;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict));
        }
    }
}