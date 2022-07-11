﻿namespace OpenDSM.Core.Models;

public class ProductModel
{
    public int Id { get; private set; }
    public int UserID { get; private set; }
    public string Name { get; private set; }
    public string About { get; private set; }
    public int TotalDownloads { get; private set; }
    public string VideoURL { get; private set; }
    public uint Price { get; private set; }
    public UserModel User { get; private set; }

    protected ProductModel(int id, int userID, string name, string about, int totalDownloads, string videoURL, UserModel user, uint price)
    {
        Id = id;
        UserID = userID;
        Name = name;
        About = about;
        TotalDownloads = totalDownloads;
        VideoURL = videoURL;
        User = user;
        Price = price;
    }

    public static ProductModel? GetByID(int id)
    {
        return null;
    }
}