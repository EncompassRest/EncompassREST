using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PreliminaryConditionLog
    /// </summary>
    public sealed partial class PreliminaryConditionLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _addedBy;
        /// <summary>
        /// PreliminaryConditionLog AddedBy
        /// </summary>
        public string AddedBy { get => _addedBy; set => _addedBy = value; }
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// PreliminaryConditionLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyValue<string> _alertsXml;
        /// <summary>
        /// PreliminaryConditionLog AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => _alertsXml = value; }
        private DirtyValue<string> _category;
        /// <summary>
        /// PreliminaryConditionLog Category
        /// </summary>
        public string Category { get => _category; set => _category = value; }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// PreliminaryConditionLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _commentListXml;
        /// <summary>
        /// PreliminaryConditionLog CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => _commentListXml = value; }
        private DirtyValue<string> _comments;
        /// <summary>
        /// PreliminaryConditionLog Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _dateAddedUtc;
        /// <summary>
        /// PreliminaryConditionLog DateAddedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateAddedUtc { get => _dateAddedUtc; set => _dateAddedUtc = value; }
        private DirtyValue<DateTime?> _dateExpected;
        /// <summary>
        /// PreliminaryConditionLog DateExpected
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateExpected { get => _dateExpected; set => _dateExpected = value; }
        private DirtyValue<DateTime?> _dateFulfilled;
        /// <summary>
        /// PreliminaryConditionLog DateFulfilled
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateFulfilled { get => _dateFulfilled; set => _dateFulfilled = value; }
        private DirtyValue<DateTime?> _dateReceived;
        /// <summary>
        /// PreliminaryConditionLog DateReceived
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateReceived { get => _dateReceived; set => _dateReceived = value; }
        private DirtyValue<DateTime?> _dateRequestedUtc;
        /// <summary>
        /// PreliminaryConditionLog DateRequestedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateRequestedUtc { get => _dateRequestedUtc; set => _dateRequestedUtc = value; }
        private DirtyValue<DateTime?> _dateRerequestedUtc;
        /// <summary>
        /// PreliminaryConditionLog DateRerequestedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateRerequestedUtc { get => _dateRerequestedUtc; set => _dateRerequestedUtc = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// PreliminaryConditionLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// PreliminaryConditionLog Description
        /// </summary>
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _details;
        /// <summary>
        /// PreliminaryConditionLog Details
        /// </summary>
        public string Details { get => _details; set => _details = value; }
        private DirtyValue<bool?> _expected;
        /// <summary>
        /// PreliminaryConditionLog Expected
        /// </summary>
        public bool? Expected { get => _expected; set => _expected = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// PreliminaryConditionLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<bool?> _fulfilled;
        /// <summary>
        /// PreliminaryConditionLog Fulfilled
        /// </summary>
        public bool? Fulfilled { get => _fulfilled; set => _fulfilled = value; }
        private DirtyValue<string> _fulfilledBy;
        /// <summary>
        /// PreliminaryConditionLog FulfilledBy
        /// </summary>
        public string FulfilledBy { get => _fulfilledBy; set => _fulfilledBy = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// PreliminaryConditionLog Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// PreliminaryConditionLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isPastDue;
        /// <summary>
        /// PreliminaryConditionLog IsPastDue
        /// </summary>
        public bool? IsPastDue { get => _isPastDue; set => _isPastDue = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// PreliminaryConditionLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// PreliminaryConditionLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _pairId;
        /// <summary>
        /// PreliminaryConditionLog PairId
        /// </summary>
        public string PairId { get => _pairId; set => _pairId = value; }
        private DirtyValue<string> _priorTo;
        /// <summary>
        /// PreliminaryConditionLog PriorTo
        /// </summary>
        public string PriorTo { get => _priorTo; set => _priorTo = value; }
        private DirtyValue<bool?> _received;
        /// <summary>
        /// PreliminaryConditionLog Received
        /// </summary>
        public bool? Received { get => _received; set => _received = value; }
        private DirtyValue<string> _receivedBy;
        /// <summary>
        /// PreliminaryConditionLog ReceivedBy
        /// </summary>
        public string ReceivedBy { get => _receivedBy; set => _receivedBy = value; }
        private DirtyValue<bool?> _requested;
        /// <summary>
        /// PreliminaryConditionLog Requested
        /// </summary>
        public bool? Requested { get => _requested; set => _requested = value; }
        private DirtyValue<string> _requestedBy;
        /// <summary>
        /// PreliminaryConditionLog RequestedBy
        /// </summary>
        public string RequestedBy { get => _requestedBy; set => _requestedBy = value; }
        private DirtyValue<bool?> _rerequested;
        /// <summary>
        /// PreliminaryConditionLog Rerequested
        /// </summary>
        public bool? Rerequested { get => _rerequested; set => _rerequested = value; }
        private DirtyValue<string> _rerequestedBy;
        /// <summary>
        /// PreliminaryConditionLog RerequestedBy
        /// </summary>
        public string RerequestedBy { get => _rerequestedBy; set => _rerequestedBy = value; }
        private DirtyValue<string> _source;
        /// <summary>
        /// PreliminaryConditionLog Source
        /// </summary>
        public string Source { get => _source; set => _source = value; }
        private DirtyValue<string> _status;
        /// <summary>
        /// PreliminaryConditionLog Status
        /// </summary>
        public string Status { get => _status; set => _status = value; }
        private DirtyValue<string> _statusDescription;
        /// <summary>
        /// PreliminaryConditionLog StatusDescription
        /// </summary>
        public string StatusDescription { get => _statusDescription; set => _statusDescription = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// PreliminaryConditionLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
        private DirtyValue<string> _title;
        /// <summary>
        /// PreliminaryConditionLog Title
        /// </summary>
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<bool?> _underwriterAccessIndicator;
        /// <summary>
        /// PreliminaryConditionLog UnderwriterAccessIndicator
        /// </summary>
        public bool? UnderwriterAccessIndicator { get => _underwriterAccessIndicator; set => _underwriterAccessIndicator = value; }
        internal override bool DirtyInternal
        {
            get => _addedBy.Dirty
                || _alertsXml.Dirty
                || _category.Dirty
                || _commentListXml.Dirty
                || _comments.Dirty
                || _dateAddedUtc.Dirty
                || _dateExpected.Dirty
                || _dateFulfilled.Dirty
                || _dateReceived.Dirty
                || _dateRequestedUtc.Dirty
                || _dateRerequestedUtc.Dirty
                || _dateUtc.Dirty
                || _description.Dirty
                || _details.Dirty
                || _expected.Dirty
                || _fileAttachmentsMigrated.Dirty
                || _fulfilled.Dirty
                || _fulfilledBy.Dirty
                || _guid.Dirty
                || _id.Dirty
                || _isPastDue.Dirty
                || _isSystemSpecificIndicator.Dirty
                || _logRecordIndex.Dirty
                || _pairId.Dirty
                || _priorTo.Dirty
                || _received.Dirty
                || _receivedBy.Dirty
                || _requested.Dirty
                || _requestedBy.Dirty
                || _rerequested.Dirty
                || _rerequestedBy.Dirty
                || _source.Dirty
                || _status.Dirty
                || _statusDescription.Dirty
                || _systemId.Dirty
                || _title.Dirty
                || _underwriterAccessIndicator.Dirty
                || _alerts?.Dirty == true
                || _commentList?.Dirty == true;
            set
            {
                _addedBy.Dirty = value;
                _alertsXml.Dirty = value;
                _category.Dirty = value;
                _commentListXml.Dirty = value;
                _comments.Dirty = value;
                _dateAddedUtc.Dirty = value;
                _dateExpected.Dirty = value;
                _dateFulfilled.Dirty = value;
                _dateReceived.Dirty = value;
                _dateRequestedUtc.Dirty = value;
                _dateRerequestedUtc.Dirty = value;
                _dateUtc.Dirty = value;
                _description.Dirty = value;
                _details.Dirty = value;
                _expected.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _fulfilled.Dirty = value;
                _fulfilledBy.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isPastDue.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _pairId.Dirty = value;
                _priorTo.Dirty = value;
                _received.Dirty = value;
                _receivedBy.Dirty = value;
                _requested.Dirty = value;
                _requestedBy.Dirty = value;
                _rerequested.Dirty = value;
                _rerequestedBy.Dirty = value;
                _source.Dirty = value;
                _status.Dirty = value;
                _statusDescription.Dirty = value;
                _systemId.Dirty = value;
                _title.Dirty = value;
                _underwriterAccessIndicator.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
            }
        }
    }
}