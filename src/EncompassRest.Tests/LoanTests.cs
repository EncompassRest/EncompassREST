﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Loans.Enums;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EncompassRest.Tests
{
    [TestClass]
    public class LoanTests : TestBaseClass
    {
        [TestMethod]
        public async Task Loan_PublicSerialization()
        {
            var loan = new Loan();
            var serializerSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.Indented };
            Assert.AreEqual("{}", JsonConvert.SerializeObject(loan, serializerSettings));
            loan.ExtensionData.Add("dog", true);
            Assert.AreEqual(@"{""dog"":true}", loan.ToJson());
            Assert.AreEqual(@"{
  ""dog"": true
}", JsonConvert.SerializeObject(loan, serializerSettings));
            loan.Dirty = false;
            Assert.AreEqual("{}", loan.ToJson());
            Assert.AreEqual(@"{
  ""dog"": true
}", JsonConvert.SerializeObject(loan, serializerSettings));
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanAsync(loan, true);
            Assert.IsNotNull(loanId);
            Assert.AreEqual(loanId, loan.EncompassId);
            var json = JsonConvert.SerializeObject(loan, serializerSettings);
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId));
        }

        [TestMethod]
        public void Loan_PublicDeserialization()
        {
            var loan = JsonConvert.DeserializeObject<Loan>(@"{""tltv"":85.00}");
            Assert.AreEqual(85.00M, loan.Tltv.Value);
            loan = JsonConvert.DeserializeObject<Loan>(@"{""dog"":true}");
            Assert.AreEqual(1, loan.ExtensionData.Count);
            Assert.AreEqual(true, loan.ExtensionData["dog"]);
            loan = JsonConvert.DeserializeObject<Loan>(@"{""applicationTakenMethodType"":""Telephone""}");
            Assert.AreEqual(ApplicationTakenMethodType.Telephone, loan.ApplicationTakenMethodType.EnumValue.Value);
        }

        [TestMethod]
        public void Loan_Empty_Serialization()
        {
            var loan = new Loan();
            Assert.AreEqual("{}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_NonNullProperty_Serialization()
        {
            var loan = new Loan
            {
                Tltv = 85.00M
            };
            Assert.AreEqual(@"{""tltv"":85.00}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_NullProperty_Serialization()
        {
            var loan = new Loan
            {
                Tltv = null
            };
            Assert.AreEqual(@"{""tltv"":null}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_CustomFields_Serialization()
        {
            var loan = new Loan();
            var customField = new CustomField { FieldName = "CUST91FV", StringValue = "Initial Value" };
            loan.CustomFields.Add(customField);
            loan.CustomFields.Add(new CustomField { FieldName = "CUST92FV", NumericValue = 10.0M });
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CUST91FV"",""stringValue"":""Initial Value""},{""fieldName"":""CUST92FV"",""numericValue"":10.0}]}", loan.ToJson());
            loan.Dirty = false;
            Assert.AreEqual("{}", loan.ToJson());
            customField.StringValue = "New Value";
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CUST91FV"",""stringValue"":""New Value""}]}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_ExtensionData_Serialization()
        {
            var loan = new Loan();
            Assert.AreEqual("{}", loan.ToJson());
            const string boolPropertyName = "boolProperty";
            loan.ExtensionData[boolPropertyName] = true;
            Assert.AreEqual(1, loan.ExtensionData.Count);
            Assert.IsTrue(loan.ExtensionData.ContainsKey(boolPropertyName));
            Assert.AreEqual(true, (bool)loan.ExtensionData[boolPropertyName]);
            Assert.AreEqual($@"{{""{boolPropertyName}"":true}}", loan.ToJson());
            loan.Dirty = false;
            Assert.AreEqual("{}", loan.ToJson());
            const string decimalPropertyName = "decimalProperty";
            loan.ExtensionData[decimalPropertyName] = 10.5M;
            Assert.AreEqual(2, loan.ExtensionData.Count);
            Assert.IsTrue(loan.ExtensionData.ContainsKey(boolPropertyName));
            Assert.IsTrue(loan.ExtensionData.ContainsKey(decimalPropertyName));
            Assert.AreEqual(true, (bool)loan.ExtensionData[boolPropertyName]);
            Assert.AreEqual(10.5M, (decimal)loan.ExtensionData[decimalPropertyName]);
            Assert.AreEqual($@"{{""{decimalPropertyName}"":10.5}}", loan.ToJson());
            const string stringPropertyName = "stringProperty";
            const string stringPropertyValue = "Hello";
            loan.ExtensionData[stringPropertyName] = stringPropertyValue;
            Assert.AreEqual(3, loan.ExtensionData.Count);
            Assert.IsTrue(loan.ExtensionData.ContainsKey(boolPropertyName));
            Assert.IsTrue(loan.ExtensionData.ContainsKey(decimalPropertyName));
            Assert.IsTrue(loan.ExtensionData.ContainsKey(stringPropertyName));
            Assert.AreEqual(true, (bool)loan.ExtensionData[boolPropertyName]);
            Assert.AreEqual(10.5M, (decimal)loan.ExtensionData[decimalPropertyName]);
            Assert.AreEqual(stringPropertyValue, (string)loan.ExtensionData[stringPropertyName]);
            CollectionAssert.AreEqual(new[] { boolPropertyName, decimalPropertyName, stringPropertyName }, loan.ExtensionData.Keys.ToList());
            CollectionAssert.AreEqual(new object[] { true, 10.5M, stringPropertyValue }, loan.ExtensionData.Values.ToList());
            CollectionAssert.AreEqual(new[] { new KeyValuePair<string, object>(boolPropertyName, true), new KeyValuePair<string, object>(decimalPropertyName, 10.5M), new KeyValuePair<string, object>(stringPropertyName, stringPropertyValue) }, loan.ExtensionData.ToList());
            Assert.AreEqual($@"{{""{decimalPropertyName}"":10.5,""{stringPropertyName}"":""{stringPropertyValue}""}}", loan.ToJson());
        }

        [TestMethod]
        public async Task Loan_CreateAndDelete()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan();
            var loanId = await client.Loans.CreateLoanAsync(loan, true).ConfigureAwait(false);
            Assert.IsNotNull(loanId);
            Assert.AreEqual(loanId, loan.EncompassId);
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId).ConfigureAwait(false));
        }

        [TestMethod]
        public async Task Loan_CreateRawAndDelete()
        {
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanRawAsync("{}").ConfigureAwait(false);
            Assert.IsNotNull(loanId);
            Assert.IsFalse(loanId.StartsWith("{"));
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId).ConfigureAwait(false));

            var json = await client.Loans.CreateLoanRawAsync("{}", "?view=entity").ConfigureAwait(false);
            Assert.IsNotNull(json);
            Assert.IsTrue(json.StartsWith("{"));
            var loan = JToken.Parse(json);
            loanId = loan["encompassId"].ToString();
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId).ConfigureAwait(false));
        }

        [TestMethod]
        public async Task Loan_BadUpdateException()
        {
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanRawAsync("{}");
            Assert.IsNotNull(loanId);
            var ex = await Assert.ThrowsExceptionAsync<EncompassRestException>(() => client.Loans.UpdateLoanRawAsync(loanId, "{invalidJson}"));
            Assert.AreEqual(HttpStatusCode.BadRequest, ex.StatusCode);
            Assert.AreEqual("{invalidJson}", ex.RequestContent);
            var loan = new Loan(client, Guid.NewGuid().ToString("D"))
            {
                Tltv = 85.00M
            };
            ex = await Assert.ThrowsExceptionAsync<EncompassRestException>(() => client.Loans.UpdateLoanAsync(loan));
            Assert.AreEqual(HttpStatusCode.NotFound, ex.StatusCode);
            Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}"",""tltv"":85.00}}", ex.RequestContent);
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId));
        }
    }
}
 