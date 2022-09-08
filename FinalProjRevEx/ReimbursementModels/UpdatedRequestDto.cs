using System;
namespace ReimbursementModels
{
    public class UpdatedRequestDto
    {
        public UpdatedRequestDto()
        {
        }

        public UpdatedRequestDto(Guid requestId, string firstname, string lastname, int status)
        {
            RequestId = requestId;
            Firstname = firstname;
            Lastname = lastname;
            Status = status;
        }

        public Guid RequestId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Status { get; set; }
    }
}

