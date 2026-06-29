using Academy.Models;
using System.Collections.Generic;
using FormImages = Academy.Forms.Resources;
namespace Academy.Forms.Models.DTOs
{
    public class EnterpriseListDto : List<EnterpriseDto>
    {
        public EnterpriseListDto()
        {

        }
        public EnterpriseListDto(List<Enterprise> data)
        {
            Clear();
            if (data != null)
            {
                foreach (var item in data)
                {
                    Add(new EnterpriseDto
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Active = item.Active ? FormImages.Active16 : FormImages.Inactive16
                    });
                }
            }
        }

        public static EnterpriseListDto Create(List<Enterprise> data)
        {
            return new EnterpriseListDto(data);
        }

        public static implicit operator EnterpriseListDto(List<Enterprise> data)
        {
            if (data != null && data.Count > 0)
            {
                return new EnterpriseListDto(data);
            }
            return new EnterpriseListDto();
        }
    }
}

