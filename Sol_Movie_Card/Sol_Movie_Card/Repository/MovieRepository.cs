﻿using Sol_Movie_Card.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Movie_Card.Repository
{
    public class MovieRepository
    {
        public async Task<IEnumerable<MovieModel>> GetListOfMoviesAsync()
        {
            return await Task.Run(() => {

                var listOfMovie = new List<MovieModel>()
                {
                    new MovieModel()
                    {
                        Title="Bharat",
                        Details="Bharat (transl. India)[a] is a 2019 Indian Hindi-language action drama film[5][6] written and directed by Ali Abbas Zafar. It is jointly produced by Atul Agnihotri, Alvira Khan Agnihotri, Bhushan Kumar, Krishan Kumar, Nikhil Namit and Salman Khan under the banners Reel Life Productions, Salman Khan Films and T-Series. The film stars Salman Khan, Katrina Kaif, Tabu, Sunil Grover, Disha Patani and Jackie Shroff. It traces India's post-independence history from the perspective of a common man, and follows his life from the age of 18 to 70.",
                        Url="https://upload.wikimedia.org/wikipedia/en/c/c9/Bharat_film_poster.jpg"
                    },

                    new MovieModel()
                    {
                        Title="Avengers: Infinity War",
                        Details="The Avengers must stop Thanos and his army from acquiring all the infinity stones. But the mad Titan is prepared to go to any lengths in order to do what he thinks is necessary.",
                        Url="http://t0.gstatic.com/images?q=tbn:ANd9GcRmE2vwxy5KaCu7cRuYYdgNdQKddux5OYgGwsPo0kqP_xzLnsDV"
                    },
                    new MovieModel()
                    {
                        Title="Dark Phoenix",
                        Details="This is the story of one of the X-Men’s most beloved characters, Jean Grey, as she evolves into the iconic DARK PHOENIX. During a life-threatening rescue mission in space, Jean is hit by a cosmic force that transforms her into one of the most powerful mutants of all.",
                        Url="http://t2.gstatic.com/images?q=tbn:ANd9GcSx4JS_U1Xp6AKtrTXtE00H40SejV2VfJtLVd3Vy46BcPYa0PPy"
                    },
                    new MovieModel()
                    {
                        Title="Men in Black",
                        Details="The Men in Black have expanded to cover the globe but so have the villains of the universe. To keep everyone safe, decorated Agent H and determined rookie M join forces -- an unlikely pairing that just might work. When aliens that can take the form of any human arrive on Earth, H and M embark on a globe-trotting adventure to save the agency -- and ultimately the world -- from their mischievous plans.",
                        Url="data:image/jpeg;base64,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"
                    },

                    new MovieModel()
                    {
                        Title="Kabir Singh",
                        Details="A house surgeon goes into a self-destructive spiral after his girlfriend is forced to marry another man.",
                        Url="http://t1.gstatic.com/images?q=tbn:ANd9GcSSBjgn6nmJttwcTh0nmdTxJLyomVapLaColnlJZ9dXLjf-Y1tP"
                    },

                     new MovieModel()
                    {
                        Title="Uri: The Surgical Strike",
                        Details="Major Vihaan Singh Shergill of the Indian Army leads a covert operation against a group of militants who attacked a base in Uri, Kashmir, in 2016 and killed many soldiers.",
                        Url="http://t2.gstatic.com/images?q=tbn:ANd9GcSHvgulsbkwf4qzDU4E_ofYWYBVXuKW16sw70QAp8iITBXB56Ee"
                    },




                };

                return listOfMovie;

            });
        }
    }
}
