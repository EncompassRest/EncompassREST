using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LockCancellationLog : IClean
    {
        private Value<bool?> _alertIndicator;
        public bool? AlertIndicator { get { return _alertIndicator; } set { _alertIndicator = value; } }
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        private Value<string> _cancelledBy;
        public string CancelledBy { get { return _cancelledBy; } set { _cancelledBy = value; } }
        private Value<string> _cancelledById;
        public string CancelledById { get { return _cancelledById; } set { _cancelledById = value; } }
        private Value<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<string> _requestGuid;
        public string RequestGuid { get { return _requestGuid; } set { _requestGuid = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private Value<string> _timeCancelled;
        public string TimeCancelled { get { return _timeCancelled; } set { _timeCancelled = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _alertIndicator.Clean
                    && _alertsXml.Clean
                    && _cancelledBy.Clean
                    && _cancelledById.Clean
                    && _commentListXml.Clean
                    && _comments.Clean
                    && _dateUtc.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _logRecordIndex.Clean
                    && _requestGuid.Clean
                    && _systemId.Clean
                    && _timeCancelled.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _alertIndicator; v0.Clean = value; _alertIndicator = v0;
                var v1 = _alertsXml; v1.Clean = value; _alertsXml = v1;
                var v2 = _cancelledBy; v2.Clean = value; _cancelledBy = v2;
                var v3 = _cancelledById; v3.Clean = value; _cancelledById = v3;
                var v4 = _commentListXml; v4.Clean = value; _commentListXml = v4;
                var v5 = _comments; v5.Clean = value; _comments = v5;
                var v6 = _dateUtc; v6.Clean = value; _dateUtc = v6;
                var v7 = _fileAttachmentsMigrated; v7.Clean = value; _fileAttachmentsMigrated = v7;
                var v8 = _guid; v8.Clean = value; _guid = v8;
                var v9 = _id; v9.Clean = value; _id = v9;
                var v10 = _isSystemSpecificIndicator; v10.Clean = value; _isSystemSpecificIndicator = v10;
                var v11 = _logRecordIndex; v11.Clean = value; _logRecordIndex = v11;
                var v12 = _requestGuid; v12.Clean = value; _requestGuid = v12;
                var v13 = _systemId; v13.Clean = value; _systemId = v13;
                var v14 = _timeCancelled; v14.Clean = value; _timeCancelled = v14;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public LockCancellationLog()
        {
            Clean = true;
        }
    }
}