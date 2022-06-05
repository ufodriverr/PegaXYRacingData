TYPO in dates. 04_06 is 03-06-2022, and 05_06 is 04-06-2022.

# PegaXYRacingData

Before using be sure to import Newtonsoft

*.Dat files formates using Newtonsoft.Json.Bson
Example of deserialization:
```
        using (var fs = File.OpenRead( PATH TO 3000RacesCombineOrigStats.dat FILE ))
        {
            using (var reader = new BsonReader(fs))
            {
                reader.ReadRootValueAsArray = true;
                var serializer = new JsonSerializer();
                _races = serializer.Deserialize<List<Race>>(reader);
            }
        }
```
What does 3000RacesCombineOrigStats.dat has:
All races information starting from RaceID 31528961 to 31531965 with 
  * Stadium stat
  * Pega post calculated stats (stat used in race)
  * Pega original stats (ones you see in pega detail)
  * Pega win rate
  etc....
