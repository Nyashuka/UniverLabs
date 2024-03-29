﻿namespace MyLibrary.Adapters.Abstract
{
    public interface IAdapter<T1, T2>
    {
        T1 ConvertToModel(T2 dto);
        T2 ConvertToDTO(T1 model);
    }
}
