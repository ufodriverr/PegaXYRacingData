# PegaXYRacingData

Before using be sure to import Newtonsoft

*.Dat files formates using Newtonsoft.Json.Bson
Example of deserialization:
'
        using (var fs = File.OpenRead( PATH TO 3000RacesCombine.dat FILE ))
        {
            using (var reader = new BsonReader(fs))
            {
                reader.ReadRootValueAsArray = true;
                var serializer = new JsonSerializer();
                _races = serializer.Deserialize<List<Race>>(reader);
            }
        }
 ' 
What dies 3000RacesCombine.dat has:
All races information starting from RaceID 31528961 to 31531965 with 
  * Stadium stat
  * Pega post calculated stats (stat used in race)
  * Pega original stats (ones you see in pega detail)
  * Pega win rate
  etc....
