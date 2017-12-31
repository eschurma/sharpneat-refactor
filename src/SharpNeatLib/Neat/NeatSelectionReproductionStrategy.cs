﻿using SharpNeat.EA;
using SharpNeat.Neat.Genome;
using SharpNeat.Neat.Speciation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpNeat.Neat
{
    // TODO: Implement.

    public class NeatSelectionReproductionStrategy<T> : ISelectionReproductionStrategy<NeatGenome<T>>
        where T : struct
    {
        #region Instance Fields

        readonly ISpeciationStrategy<NeatGenome<T>,T> _speciationStrategy;
        readonly int _speciesCount;
        Species<T>[] _speciesArr;

        #endregion

        #region Constructor

        public NeatSelectionReproductionStrategy(
            ISpeciationStrategy<NeatGenome<T>,T> speciationStrategy,
            int speciesCount)
        {
            _speciationStrategy = speciationStrategy;
            _speciesCount = speciesCount;


        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Initialise the strategy.
        /// </summary>
        public void Initialise(Population<NeatGenome<T>> population)
        {
            _speciesArr = _speciationStrategy.SpeciateAll(population.GenomeList, _speciesCount);
            if(null == _speciesArr || _speciesArr.Length != _speciesCount) {
                throw new Exception("Species array is null or has incorrect length.");
            }
        }

        /// <summary>
        /// Invoke the strategy.
        /// Accepts a population of genomes, and updates it into a new population.
        /// </summary>
        /// <param name="population">The population to operate upon.</param>
        public void Invoke(Population<NeatGenome<T>> population)
        {
            var neatPop = population as NeatPopulation<double>;
            
            





            throw new NotImplementedException();
        }

        #endregion
    }
}