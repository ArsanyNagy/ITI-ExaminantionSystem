﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccessLayer.Models;
using BusineesLayer.Map;

namespace BusineesLayer
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<program, programMap>();
                cfg.CreateMap<programMap, program>();

                cfg.CreateMap<Intake, IntakeMap>();
                cfg.CreateMap<IntakeMap, Intake>();

                cfg.CreateMap<ProgramIntake, ProgramIntakeMap>();
                cfg.CreateMap<ProgramIntakeMap, ProgramIntake>();

                cfg.CreateMap<Branch, BranchMap>();
                cfg.CreateMap<BranchMap, Branch>();

                cfg.CreateMap<subTrack, subTrackMap>();
                cfg.CreateMap<subTrackMap, subTrack>();

                cfg.CreateMap<PlatfromIntake, PlatfromIntakeMap>();
                cfg.CreateMap<PlatfromIntakeMap, PlatfromIntake>();

                cfg.CreateMap<StudentBasicData, StudentBasicDataMap>();
                cfg.CreateMap<StudentBasicDataMap, StudentBasicData>();

                cfg.CreateMap<Course, CourseMap>();
                cfg.CreateMap<CourseMap, Course>();

                cfg.CreateMap<TrackManual, TrackManualMap>();
                cfg.CreateMap<TrackManualMap, TrackManual>();

                cfg.CreateMap<CourseManual, CourseManualMap>();
                cfg.CreateMap<CourseManualMap, CourseManual>();

                cfg.CreateMap<Exam, ExamMap>()
                .ForMember(dto => dto.Ins_Id, conf => conf.MapFrom(ol => ol.Employee.EmployeeID));

                cfg.CreateMap<DepartmentsExam, DepartmentsExamMap>()
                .ForMember(dto => dto.Exam_Id, conf => conf.MapFrom(ol => ol.Exam.Exam_Id));

                cfg.CreateMap<ExternalInstructorAuthorization, ExternalInstructorAuthorizationMap>()
                .ForMember(dto => dto.Ins_Id, conf => conf.MapFrom(ol => ol.Employee.EmployeeID));

                cfg.CreateMap<InstructorsConnectionId, InstructorsConnectionIdMap>()
                .ForMember(dto => dto.Ins_Id, conf => conf.MapFrom(ol => ol.Employee.EmployeeID));

                cfg.CreateMap<NewDateExamForPermittedStudent, NewDateExamForPermittedStudentMap>()
                .ForMember(dto => dto.Std_Id, conf => conf.MapFrom(ol => ol.StudentBasicData.StudentID));

                cfg.CreateMap<Notification, NotificationMap>();
                cfg.CreateMap<NotificationMap, Notification>();

                cfg.CreateMap<Question, QuestionMap>()
                .ForMember(dto => dto.Ins_Id, conf => conf.MapFrom(ol => ol.Employee.EmployeeID))
                .ForMember(dto=>dto.Topic_Id,conf=>conf.MapFrom(ol=>ol.TopicsInCourse.Topic_Id));

                cfg.CreateMap<QuestionAnswer, QuestionAnswerMap>();
                cfg.CreateMap<QuestionAnswerMap, QuestionAnswer>();

                cfg.CreateMap<QuestionsInExam, QuestionsInExamMap>();
                cfg.CreateMap<QuestionsInExamMap, QuestionsInExam>();

                cfg.CreateMap<StudentPermissionInExam, StudentPermissionInExamMap>();
                cfg.CreateMap<StudentPermissionInExamMap, StudentPermissionInExam>();

                cfg.CreateMap<DepartmentsExam, DepartmentsExamMap>();
                cfg.CreateMap<DepartmentsExamMap, DepartmentsExam>();
            });

        }
    }
}

