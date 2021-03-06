﻿using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.Danliris.Service.Finishing.Printing.Lib.Models.FabricQualityControl
{
    public class FabricQualityControlModel : StandardEntity, IValidatableObject
    {
        [MaxLength(255)]
        public string UId { get; set; }
        public string Buyer { get; set; }
        public string CartNo { get; set; }
        public string Code { get; set; }
        public string Color { get; set; }
        public string Construction { get; set; }
        public DateTimeOffset DateIm { get; set; }
        public ICollection<FabricGradeTestModel> FabricGradeTests { get; set; }
        public string Group { get; set; }
        public bool IsUsed { get; set; }
        public string KanbanCode { get; set; }
        public int KanbanId { get; set; }
        public string MachineNoIm { get; set; }
        public string OperatorIm { get; set; }
        public double OrderQuantity { get; set; }
        public string PackingInstruction { get; set; }
        public double PointLimit { get; set; }
        public double PointSystem { get; set; }
        public string ProductionOrderNo { get; set; }
        public string ProductionOrderType { get; set; }
        public string ShiftIm { get; set; }
        public string Uom { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
