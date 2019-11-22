using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    public class MockTestContext : TestContext
    {
        private readonly IDictionary props;

        public MockTestContext()
        {
            props = new Dictionary<object, object>
            {
                { "DeploymentDirectory", Path.GetFullPath(@"..") },
                { "TestName", Path.GetFullPath(@"Standalone-Debug-Harness") }
            };
        }

        #region TestContext methods
        public override void WriteLine(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

        public override void WriteLine(string msg)
        {
            Console.WriteLine(msg);
        }

        public override void AddResultFile(string fileName)
        {
            throw new NotImplementedException("AddResultFile");
        }

        public override void BeginTimer(string timerName)
        {
            throw new NotImplementedException("BeginTimer");
        }

        public override void EndTimer(string timerName)
        {
            throw new NotImplementedException("EndTimer");
        }

        public override IDictionary Properties
        {
            get { return props; }
        }

        public override DataRow DataRow
        {
            get { throw new NotImplementedException("DataRow"); }
        }

        public override DbConnection DataConnection
        {
            get { throw new NotImplementedException("DataConnection"); }
        }

        #pragma warning disable 809
        [Obsolete(@"Deprecated. Use TestContext.TestRunDirectory instead.")]
        public override string TestDir { 
            get { throw new InvalidOperationException(@"Deprecated. Use TestContext.TestRunDirectory instead."); } 
        }
        [Obsolete(@"Deprecated. Use TestContext.DeploymentDirectory instead.")]
        public override string TestDeploymentDir { 
            get { throw new InvalidOperationException(@"Deprecated. Use TestContext.DeploymentDirectory instead."); } 
        }
        [Obsolete(@"Deprecated. Use TestContext.TestRunResultsDirectory instead.")]
        public override string TestLogsDir { 
            get { throw new InvalidOperationException(@"Deprecated. Use TestContext.TestRunResultsDirectory instead."); } 
        }
        #pragma warning restore 809

        #endregion
    }
}
