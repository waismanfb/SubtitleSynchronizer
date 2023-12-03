using Application.Service.Path;
using Application.Service.Subtitle;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        //ISubtitleService subtitleService = new SubtitleService();
        //IPathService pathService = new PathService();

        //// Assuming the infrastructure folder is in the root directory of the project
        //string subtitleFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Infrastructure", "Data", "The.Matrix.1999.BluRay.720p.Malay.srt");
        //List<SubtitleEntity> subtitles = subtitleService.LoadSubtitles(subtitleFilePath);


        //// Load subtitles
        ////List<SubtitleEntity> subtitles = subtitleService.LoadSubtitles(subtitleFilePath);


        //// Task 1: Shift .srt file
        //TimeSpan shiftAmount = TimeSpan.FromSeconds(5);
        //List<SubtitleEntity> shiftedSubtitles = subtitleService.ShiftSubtitles(subtitles, shiftAmount);

        //// Task 2: Calculate possible paths between points
        //List<PathEntity> predefinedLinks = new List<PathEntity>
        //{
        //    new PathEntity("PointA", "PointB"),
        //    new PathEntity("PointB", "PointC"),
        //    new PathEntity("PointC", "PointD"),
        //    // Add more links as needed
        //};

        //string startPoint = "PointA";
        //string endPoint = "PointD";

        //List<string> possiblePaths = pathService.CalculatePaths(predefinedLinks, startPoint, endPoint);

        //// Display the result
        //Console.WriteLine("Shifted .srt file and calculated paths:");
        //DisplaySubtitles(shiftedSubtitles);
        //Console.WriteLine($"\nPossible Paths from {startPoint} to {endPoint}:\n{string.Join("\n", possiblePaths)}");

        //Console.ReadLine();
    }



    static void DisplaySubtitles(List<SubtitleEntity> subtitles)
    {
        foreach (var subtitle in subtitles)
        {
            Console.WriteLine($"{subtitle.StartTime} --> {subtitle.EndTime}");
            Console.WriteLine(subtitle.Text);
            Console.WriteLine();
        }
    }


}
