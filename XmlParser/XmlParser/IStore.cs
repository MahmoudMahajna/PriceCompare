﻿namespace XmlParser
{
    //A very good idea- this way no one really knows about the underlying source of the items- could be anything!
    public interface IStore
    {
        long ChainId { get; set; }
        string SubChainId { get; set; }
        int StoreId { get; set; }
        int BikoretNo { get; set; }
        int StoreType { get; set; }
        string ChainName { get; set; }
        string SubChainName { get; set; }
        string StoreName { get; set; }
        string Address { get; set; }
        string City { get; set; }
    }
}
