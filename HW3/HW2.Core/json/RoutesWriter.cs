using System;
using System.Collections.Generic;
using HW2.Core.transport;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using static HW2.Core.transport.Route;

namespace HW2.Core.json
{
    public class RoutesWriter : Writer
    {
        public static void Write()
        {
            var school = new Station()
            {
                Id = 1,
                Name = "School"
            };
            var otradnoye = new Station()
            {
                Id = 2,
                Name = "Otradnoye"
            };
            var polyclinic = new Station()
            {
                Id = 3,
                Name = "Polyclinic"
            };
            var polarnaya = new Station()
            {
                Id = 4,
                Name = "Polarnaya"
            };
            var goncharova = new Station()
            {
                Id = 5,
                Name = "Goncharova"
            };
            var sovetskaya = new Station()
            {
                Id = 6,
                Name = "Sovetskaya"
            };
            var mira = new Station()
            {
                Id = 7,
                Name = "Mira"
            };
            var babushkinskaya = new Station()
            {
                Id = 8,
                Name = "Babushkinskaya"
            };
            var hospital = new Station()
            {
                Id = 9,
                Name = "Hospital"
            };
            var nauchnaya = new Station()
            {
                Id = 10,
                Name = "Nauchnaya"
            };
            var yasnaya = new Station()
            {
                Id = 11,
                Name = "Yasnaya"
            };
            var severnaya = new Station()
            {
                Id = 12,
                Name = "Severnaya"
            };
            var tverskaya = new Station()
            {
                Id = 13,
                Name = "Tverskaya"
            };
            var dekabristov = new Station()
            {
                Id = 14,
                Name = "Dekabristov"
            };
            var sviblovo = new Station()
            {
                Id = 15,
                Name = "Sviblovo"
            };
            var sadovaya = new Station()
            {
                Id = 16,
                Name = "Sadovaya"
            };
            var pervomayskaya = new Station()
            {
                Id = 17,
                Name = "Pervomayskaya"
            };
            var institutskaya = new Station()
            {
                Id = 18,
                Name = "Institutskaya"
            };
            var kirpichnaya = new Station()
            {
                Id = 19,
                Name = "Kirpichnaya"
            };


            var json = JsonConvert.SerializeObject(
                new Content(
                    new List<Station>
                    {
                        school,
                        otradnoye,
                        polyclinic,
                        polarnaya,
                        goncharova,
                        sovetskaya,
                        mira,
                        babushkinskaya,
                        hospital,
                        nauchnaya,
                        yasnaya,
                        severnaya,
                        tverskaya,
                        dekabristov,
                        sviblovo,
                        sadovaya,
                        pervomayskaya,
                        institutskaya,
                        kirpichnaya
                    },
                new List<Route>
                {
                    new Route()
                    {
                        Number = 696,
                        Path = new List<PathElement>
                        {
                            new PathElement()
                            {
                            Id = 1,
                            StationId = school.Id,
                            Distance = 0
                            },
                            new PathElement()
                            {
                            Id = 2,
                            StationId = otradnoye.Id,
                            Distance = 5
                            },
                            new PathElement()
                            {
                            Id = 3,
                            StationId = polyclinic.Id,
                            Distance = 6
                            },
                            new PathElement()
                            {
                            Id = 4,
                            StationId = polarnaya.Id,
                            Distance = 4
                            },
                            new PathElement()
                            {
                            Id = 5,
                            StationId = goncharova.Id,
                            Distance = 5
                            }
                        },
                        FirstDeparture = new DateTime().AddHours(5).AddMinutes(30),
                        LastDeparture = new DateTime().AddHours(23).AddMinutes(30),
                        Interval = 20
                    },
                    new Route()
                    {
                        Number = 605,
                        Path = new List<PathElement>
                        {
                            new PathElement()
                            {
                            Id = 6,
                            StationId = otradnoye.Id,
                            Distance = 0
                            },
                            new PathElement()
                            {
                            Id = 7,
                            StationId = yasnaya.Id,
                            Distance = 8
                            },
                            new PathElement()
                            {
                            Id = 8,
                            StationId = severnaya.Id,
                            Distance = 3
                            },
                            new PathElement()
                            {
                            Id = 9,
                            StationId = babushkinskaya.Id,
                            Distance = 6
                            },
                            new PathElement()
                            {
                            Id = 10,
                            StationId = tverskaya.Id,
                            Distance = 5
                            },
                            new PathElement()
                            {
                            Id = 11,
                            StationId = dekabristov.Id,
                            Distance = 7
                            }
                        },
                        FirstDeparture = new DateTime().AddHours(6).AddMinutes(30),
                        LastDeparture = new DateTime().AddHours(01).AddMinutes(10),
                        Interval = 10
                    },
                    new Route()
                    {
                        Number = 71,
                        Path = new List<PathElement>
                        {
                            new PathElement()
                            {
                            Id = 12,
                            StationId = sovetskaya.Id,
                            Distance = 0
                            },
                            new PathElement()
                            {
                            Id = 13,
                            StationId = polarnaya.Id,
                            Distance = 6
                            },
                            new PathElement()
                            {
                            Id = 14,
                            StationId = mira.Id,
                            Distance = 3
                            },
                            new PathElement()
                            {
                            Id = 15,
                            StationId = babushkinskaya.Id,
                            Distance = 5
                            },
                            new PathElement()
                            {
                            Id = 16,
                            StationId = hospital.Id,
                            Distance = 4
                            },
                            new PathElement()
                            {
                            Id = 17,
                            StationId = nauchnaya.Id,
                            Distance = 5
                            }
                        },
                        FirstDeparture = new DateTime().AddHours(7).AddMinutes(5),
                        LastDeparture = new DateTime().AddHours(23).AddMinutes(55),
                        Interval = 5
                    },
                    new Route()
                    {
                        Number = 124,
                        Path = new List<PathElement>
                        {
                            new PathElement()
                            {
                            Id = 18,
                            StationId = sviblovo.Id,
                            Distance = 0
                            },
                            new PathElement()
                            {
                            Id = 19,
                            StationId = babushkinskaya.Id,
                            Distance = 3
                            },
                            new PathElement()
                            {
                            Id = 20,
                            StationId = sadovaya.Id,
                            Distance = 2
                            },
                            new PathElement()
                            {
                            Id = 21,
                            StationId = pervomayskaya.Id,
                            Distance = 5
                            },
                            new PathElement()
                            {
                            Id = 22,
                            StationId = institutskaya.Id,
                            Distance = 3
                            },
                            new PathElement()
                            {
                            Id = 23,
                            StationId = nauchnaya.Id,
                            Distance = 4
                            },
                            new PathElement()
                            {
                            Id = 24,
                            StationId = kirpichnaya.Id,
                            Distance = 6
                            }
                        },
                        FirstDeparture = new DateTime().AddHours(12).AddMinutes(0),
                        LastDeparture = new DateTime().AddHours(3).AddMinutes(0),
                        Interval = 30
                    }
                }),
                new IsoDateTimeConverter { DateTimeFormat = "HH:mm" }
            );

            WriteToFile("hw1.json", json);
        }
    }
}