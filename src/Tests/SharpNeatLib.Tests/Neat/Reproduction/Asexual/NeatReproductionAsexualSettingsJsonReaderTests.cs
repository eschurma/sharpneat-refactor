﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using SharpNeat.Neat.Reproduction.Asexual;

namespace SharpNeatLib.Tests.Neat.Reproduction.Asexual
{
    [TestClass]
    public class NeatReproductionAsexualSettingsJsonReaderTests
    {
        [TestMethod]
        public void Read()
        {
            JObject jobj = JObject.Parse(
@"{
    'connectionWeightMutationProbability':0.11,
    'addNodeMutationProbability':0.22,
    'addConnectionMutationProbability':0.33,
    'deleteConnectionMutationProbability':0.44,
}");
            // Init a default settings object.
            var settings = new NeatReproductionAsexualSettings();

            // Read json properties into the settings object.
            NeatReproductionAsexualSettingsJsonReader.Read(settings, jobj);

            // Assert the expected values.
            Assert.AreEqual(0.11, settings.ConnectionWeightMutationProbability);
            Assert.AreEqual(0.22, settings.AddNodeMutationProbability);
            Assert.AreEqual(0.33, settings.AddConnectionMutationProbability);
            Assert.AreEqual(0.44, settings.DeleteConnectionMutationProbability);
        }
    }
}
