﻿namespace workshop.wwwapi.DTOs
{
    public class CreateMedicinePrescriptionDTO
    {
        public int medicineId { get; set; }
        public int quantity { get; set; }
        public string notes { get; set; }
    }
}
