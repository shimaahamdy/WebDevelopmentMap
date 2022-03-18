

namespace company
{
    [Flags]
    public enum securityLevel:Byte
    { guest = 0,secretary = 8, dveloper = 12, DBA =14, officer=15 }

    /*
     *  RWXD
     *  0000 no privaliges
     *  1000 R 
     *  0100 W 
     *  0110  WX
     *  1100 RW
     *  1110 RWX
     *  
     */

}
