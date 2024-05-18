﻿using AssemblyService.Domain.Entities.Models;
using AssemblyService.Domain.Interfaces.Repositories;
using AssemblyService.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.Infrastructure.Repositories
{
    public class ClassroomRepository(TimetableContext context) : RepositoryBase<Classroom>(context), IClassroomRepository
    {
    }
}
