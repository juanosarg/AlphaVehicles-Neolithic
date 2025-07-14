
using System.Collections.Generic;
using UnityEngine;
using Verse;
using Verse.Sound;
namespace AlphaVehicles
{
    public class AudioGrain_SeveralFolders : AudioGrain
    {
      
        [NoTranslate]
        public List<string> clipFolderPaths;

        public override IEnumerable<ResolvedGrain> GetResolvedGrains()
        {

            foreach(string folder in clipFolderPaths)
            {
                foreach (AudioClip item in ContentFinder<AudioClip>.GetAllInFolder(folder))
                {
                    yield return new ResolvedGrain_Clip(item);
                }
            }
            
        }
    }
}