﻿using MauiPlanets.Models;

namespace MauiPlanets.Services
{
	internal class PlanetsService
	{
		private static List<Planet> planets = new()
		{
			new()
			{
				Name = "Mercury",
				Subtitle = "The smallest planet",
				HeroImage = "mercury.png",
				Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and communication, and the messenger of the gods.",
				AccentColorStart = Color.FromArgb("#353535"),
				AccentColorEnd = Color.FromArgb("#8d9098"),
				Images = new()
				{
					"https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
				}
			},
			new()
			{
				Name = "Venus",
				Subtitle = "The pressure cooker",
				HeroImage = "venus.png",
				Description = "Of all the planets, Venus is the one most similar to Earth. In fact, Venus is often called Earth's “sister” planet. As similar as it is in some ways, however, it is also very different in others.",
				AccentColorStart = Color.FromArgb("#a6393b"),
				AccentColorEnd = Color.FromArgb("#d17f21"),
				Images = new()
				{
					"https://science.nasa.gov/wp-content/uploads/2023/06/Venus-jpeg.webp?w=4096&format=png&crop=1"
				}
			},
			new()
			{
				Name = "Earth",
				Subtitle = "The cradle of life",
				HeroImage = "earth.png",
				Description = "The Earth is the only planet known where life exists. Almost 1.5 million species of animals and plants have been discovered so far, and many more have yet to be found. While other planets may have small amounts of ice or steam, the Earth is 2/3 water. Earth has perfect conditions for a breathable atmosphere.",
				AccentColorStart = Color.FromArgb("#0e3d68"),
				AccentColorEnd = Color.FromArgb("#2e97c7"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
					"https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
					"https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
				}
			},
			new()
			{
				Name = "Mars",
				Subtitle = "The red beauty",
				HeroImage = "mars.png",
				Description = "No planet has sparked the imaginations of humans as much as Mars. It may be the reddish color of Mars, or the fact that it can often be easily seen in the night sky, that has caused people to wonder about this close neighbor of ours. Tales of “Martians” invading Earth have been around for well over fifty years. But is it likely that any kind of life really does exist on Mars?",
				AccentColorStart = Color.FromArgb("#a23036"),
				AccentColorEnd = Color.FromArgb("#eb3333"),
				Images = new()
				{
					"https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
					"https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
					"https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
				}
			},
			new()
			{
				Name = "Jupiter",
				Subtitle = "The gas giant",
				HeroImage = "jupiter.png",
				Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. It is a gas giant with a mass more than 2.5 times that of all the other planets in the Solar System combined, and slightly less than one-thousandth the mass of the Sun. Its diameter is eleven times that of Earth, and a tenth that of the Sun.",
				AccentColorStart = Color.FromArgb("#9d4a40"),
				AccentColorEnd = Color.FromArgb("#cd8026"),
				Images = new()
				{
					"https://science.nasa.gov/wp-content/uploads/2023/04/stsci-h-p1936a-m-1999x2000-1.png?w=1024"
				}
			},
			new()
			{
				Name = "Saturn",
				Subtitle = "The ring planet",
				HeroImage = "saturn.png",
				Description = "Saturn is the sixth planet from the Sun and the second-largest in the Solar System, after Jupiter. It is a gas giant with an average radius of about nine and a half times that of Earth. It has only one-eighth the average density of Earth, but is over 95 times more massive.",
				AccentColorStart = Color.FromArgb("#996237"),
				AccentColorEnd = Color.FromArgb("#c6502f"),
				Images = new()
				{
					"https://images-assets.nasa.gov/image/PIA11141/PIA11141~large.jpg?w=1920&h=929&fit=clip&crop=faces%2Cfocalpoint"
				}
			},
			new()
			{
				Name = "Uranus",
				Subtitle = "The Herschel planet",
				HeroImage = "uranus.png",
				Description = "Uranus is the seventh planet from the Sun. It is named after Greek sky deity Uranus (Caelus), who in Greek mythology is the father of Cronus (Saturn), a grandfather of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus has the third-largest planetary radius and fourth-largest planetary mass in the Solar System.",
				AccentColorStart = Color.FromArgb("#9d4a40"),
				AccentColorEnd = Color.FromArgb("#996237"),
				Images = new()
				{
					"https://images-assets.nasa.gov/image/PIA18182/PIA18182~orig.jpg?w=1720&h=1720&fit=clip&crop=faces%2Cfocalpoint"
				}
			},
			new()
			{
				Name = "Neptune",
				Subtitle = "The god of the sea",
				HeroImage = "neptune.png",
				Description = "Neptune is the eighth planet from the Sun and the farthest known planet in the Solar System. It is the fourth-largest planet in the Solar System by diameter, the third-most-massive planet, and the densest giant planet. It is 17 times the mass of Earth, and slightly more massive than its near-twin Uranus.",
				AccentColorStart = Color.FromArgb("#0c293d"),
				AccentColorEnd = Color.FromArgb("#26abe0"),
				Images = new()
				{
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRRhTZLAttLzaM2nxi36MjChP_R7dw7Sv-jew&s"
				}
			},
			new()
			{
				Name = "Pluto",
				Subtitle = "The dwarf planet",
				HeroImage = "pluto.png",
				Description = "Pluto is known for its icy composition and is classified as a dwarf planet. It is the largest known dwarf planet in the Solar System and has a complex atmosphere.",
				AccentColorStart = Color.FromArgb("#5C3A3A"),
				AccentColorEnd = Color.FromArgb("#A69A9A"),
				Images = new()
				{
					"https://www.nasa.gov/wp-content/uploads/2023/03/crop_p_color2_enhanced_release_small.png?w=1041"
				}
			},
			new()
			{
				Name = "Ceres",
				Subtitle = "The largest asteroid",
				HeroImage = "ceres.png",
				Description = "Ceres is the largest object in the asteroid belt between Mars and Jupiter and is classified as a dwarf planet.",
				AccentColorStart = Color.FromArgb("#BF3B3B"),
				AccentColorEnd = Color.FromArgb("#FF7F7F"),
				Images = new()
				{
					"https://cdn.mos.cms.futurecdn.net/qnft8kRfeGWWLgaygo4fb9.jpg"
				}
			},
			new()
			{
				Name = "Haumea",
				Subtitle = "The elongated planet",
				HeroImage = "haumea.png",
				Description = "Haumea is known for its elongated shape and fast rotation, and it has two known moons.",
				AccentColorStart = Color.FromArgb("#A36E3D"),
				AccentColorEnd = Color.FromArgb("#FFE5B0"),
				Images = new()
				{
					"https://science.nasa.gov/wp-content/uploads/2023/09/haumea_th.jpg?w=320"
				}
			},
			new()
			{
				Name = "MakeMake",
				Subtitle = "The little-known dwarf planet",
				HeroImage = "makemake.png",
				Description = "MakeMake is one of the largest known dwarf planets in the Solar System and is found in the Kuiper belt.",
				AccentColorStart = Color.FromArgb("#7C5C5C"),
				AccentColorEnd = Color.FromArgb("#B9A09E"),
				Images = new()
				{
					"https://science.nasa.gov/wp-content/uploads/2023/09/makemake_th.jpg?w=320"
				}
			},
			new()
			{
				Name = "Eris",
				Subtitle = "The most massive dwarf planet",
				HeroImage = "eris.png",
				Description = "Eris is the most massive known dwarf planet and is located in the scattered disc region of the Solar System.",
				AccentColorStart = Color.FromArgb("#4B4C5F"),
				AccentColorEnd = Color.FromArgb("#8A8B9C"),
				Images = new()
				{
					"https://science.nasa.gov/wp-content/uploads/2023/06/Artists_c_oncept_of_Eris_and_Dysnomia_far_from_the_Sun-jpeg.webp?w=1536&format=webp"
				}
			}
		};

		public static List<Planet> GetFeaturedPlanets()
		{
			var random = new Random();
			var randomizePlanets = planets
				.OrderBy(item => random.Next());

			return randomizePlanets
				.Take(2)
				.ToList();
		}

		public static List<Planet> GetAllPlanets()
			=> planets;

	}
}