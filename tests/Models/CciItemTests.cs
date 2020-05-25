using Xunit;
using openrmf_msg_compliance.Models.NISTtoCCI;
using System;

namespace tests.Models
{
    public class CciItemTests
    {
        [Fact]
        public void Test_NewCCIItemIsValid()
        {
            CciItem cciItem = new CciItem();

            // Testing
            Assert.False(cciItem == null);
        }
    
        [Fact]
        public void Test_CCIItemWithDataIsValid()
        {
            CciItem cciItem = new CciItem();
            
            cciItem.cciId  = "CCI-2345";
            cciItem.status = "myStatus";
            cciItem.publishDate = DateTime.Now.ToShortDateString();
            cciItem.contributor = "Cingulara";
            cciItem.definition = "This is my definition";
            cciItem.type = "thisType";
            cciItem.parameter = "myParams";
            cciItem.note = "man this is complicated!";

            // Testing
            Assert.True(cciItem.cciId == "CCI-2345");
            Assert.True(cciItem.status == "myStatus");
            Assert.True(cciItem.contributor == "Cingulara");
            Assert.True(cciItem.definition == "This is my definition");
            Assert.True(cciItem.type == "thisType");
            Assert.True(cciItem.parameter == "myParams");
            Assert.True(cciItem.note == "man this is complicated!");
            Assert.False(cciItem.references == null);
            Assert.False(cciItem.publishDate == null);
        }

        [Fact]
        public void Test_CCIItemWithReferenceDataIsValid()
        {
            CciItem cciItem = new CciItem();
            
            cciItem.cciId  = "CCI-2345";
            cciItem.status = "myStatus";
            cciItem.publishDate = DateTime.Now.ToShortDateString();
            cciItem.contributor = "Cingulara";
            cciItem.definition = "This is my definition";
            cciItem.type = "thisType";
            cciItem.parameter = "myParams";
            cciItem.note = "man this is complicated!";

            CciReference cciReference = new CciReference();
            
            cciReference.creator  = "NIST";
            cciReference.title = "This is my title here";
            cciReference.location = "My location";
            cciReference.index = "AU-9 1.a(2)";
            cciItem.references.Add(cciReference);

            // Testing
            Assert.True(cciItem.cciId == "CCI-2345");
            Assert.True(cciItem.status == "myStatus");
            Assert.True(cciItem.contributor == "Cingulara");
            Assert.True(cciItem.definition == "This is my definition");
            Assert.True(cciItem.type == "thisType");
            Assert.True(cciItem.parameter == "myParams");
            Assert.True(cciItem.note == "man this is complicated!");
            Assert.True(cciItem.references.Count == 1);
            Assert.False(cciItem.publishDate == null);
        }


        [Fact]
        public void Test_NewCCIReferenceIsValid()
        {
            CciReference cciReference = new CciReference();

            // Testing
            Assert.False(cciReference == null);
        }
    
        [Fact]
        public void Test_CCIReferenceWithDataIsValid()
        {
            CciReference cciReference = new CciReference();
            
            cciReference.creator = "NIST";
            cciReference.title = "This is my title here";
            cciReference.location = "My location";
            cciReference.index = "AU-9 1.a(2)";
            cciReference.majorControl = "AU-9";

            // Testing
            Assert.True(cciReference.creator == "NIST");
            Assert.True(cciReference.title == "This is my title here");
            Assert.True(cciReference.location == "My location");
            Assert.True(cciReference.index == "AU-9 1.a(2)");
            Assert.True(cciReference.majorControl == "AU-9");
        }
    }
}
