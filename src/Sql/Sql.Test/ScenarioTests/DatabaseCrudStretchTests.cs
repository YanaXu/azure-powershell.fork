// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ScenarioTest.SqlTests;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.Sql.Test.ScenarioTests
{
    public class DatabaseCrudStretchTests : SqlTestRunner
    {
        public DatabaseCrudStretchTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact(Skip = "Cannot re-record.")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestStretchDatabaseCreate()
        {
            TestRunner.RunTestScript("Test-CreateStretchDatabase");
        }

        [Fact(Skip = "Cannot re-record.")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestStretchDatabaseUpdate()
        {
            TestRunner.RunTestScript("Test-UpdateStretchDatabase");
        }

        [Fact(Skip = "Cannot re-record.")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestStretchDatabaseGet()
        {
            TestRunner.RunTestScript("Test-GetStretchDatabase");
        }

        [Fact(Skip = "Cannot re-record.")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestStretchDatabaseRemove()
        {
            TestRunner.RunTestScript("Test-RemoveStretchDatabase");
        }
    }
}
