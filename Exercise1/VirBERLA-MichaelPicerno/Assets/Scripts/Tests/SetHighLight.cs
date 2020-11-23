
namespace Tests
{
    using Game;
    using System.Collections;
    using System.Collections.Generic;
    using NUnit.Framework;
    using UnityEngine;
    using UnityEngine.TestTools;
    
    public class SetHighLight
    {
        private HighLight highlight;
        
        // A Test behaves as an ordinary method
        [Test]
        public void SetHighLightSimplePasses()
        {
            highlight = new HighLight();
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator SetHighLightWithEnumeratorPasses()
        {
            
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
