﻿using System;

namespace DevFreela.Application.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public ProjectDetailsViewModel(int id, string title, string description, decimal totalCost, DateTime? startedAt, DateTime finishedAt)
        {
            Id = id;
            Title = title;
            Description = description;
            StartedAt = startedAt;
            FinishedAt = finishedAt;
            TotalCost = totalCost;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime? StartedAt { get; set; }

        public DateTime FinishedAt { get; set; }

        public decimal TotalCost { get; set; }
    }
}