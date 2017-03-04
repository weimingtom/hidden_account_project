﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoClient.MapServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://video.pandawork.net/map/", ConfigurationName="MapServiceReference.MapService")]
    public interface MapService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/getMapById", ReplyAction="http://video.pandawork.net/map/MapService/getMapByIdResponse")]
        VideoCommon.com.pandawork.common.entity.Map getMapById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/getMapById", ReplyAction="http://video.pandawork.net/map/MapService/getMapByIdResponse")]
        System.Threading.Tasks.Task<VideoCommon.com.pandawork.common.entity.Map> getMapByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/getMapDTOById", ReplyAction="http://video.pandawork.net/map/MapService/getMapDTOByIdResponse")]
        VideoCommon.com.pandawork.common.dto.MapDTO getMapDTOById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/getMapDTOById", ReplyAction="http://video.pandawork.net/map/MapService/getMapDTOByIdResponse")]
        System.Threading.Tasks.Task<VideoCommon.com.pandawork.common.dto.MapDTO> getMapDTOByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/addMap", ReplyAction="http://video.pandawork.net/map/MapService/addMapResponse")]
        void addMap(VideoCommon.com.pandawork.common.entity.Map map);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/addMap", ReplyAction="http://video.pandawork.net/map/MapService/addMapResponse")]
        System.Threading.Tasks.Task addMapAsync(VideoCommon.com.pandawork.common.entity.Map map);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/updateMap", ReplyAction="http://video.pandawork.net/map/MapService/updateMapResponse")]
        void updateMap(VideoCommon.com.pandawork.common.entity.Map map);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/updateMap", ReplyAction="http://video.pandawork.net/map/MapService/updateMapResponse")]
        System.Threading.Tasks.Task updateMapAsync(VideoCommon.com.pandawork.common.entity.Map map);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/delMap", ReplyAction="http://video.pandawork.net/map/MapService/delMapResponse")]
        void delMap(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/delMap", ReplyAction="http://video.pandawork.net/map/MapService/delMapResponse")]
        System.Threading.Tasks.Task delMapAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/getAllMaps", ReplyAction="http://video.pandawork.net/map/MapService/getAllMapsResponse")]
        VideoCommon.com.pandawork.common.dto.MapDTO[] getAllMaps();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/getAllMaps", ReplyAction="http://video.pandawork.net/map/MapService/getAllMapsResponse")]
        System.Threading.Tasks.Task<VideoCommon.com.pandawork.common.dto.MapDTO[]> getAllMapsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/findChildren", ReplyAction="http://video.pandawork.net/map/MapService/findChildrenResponse")]
        VideoCommon.com.pandawork.common.dto.MapDTO[] findChildren(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/findChildren", ReplyAction="http://video.pandawork.net/map/MapService/findChildrenResponse")]
        System.Threading.Tasks.Task<VideoCommon.com.pandawork.common.dto.MapDTO[]> findChildrenAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/createTreeById", ReplyAction="http://video.pandawork.net/map/MapService/createTreeByIdResponse")]
        VideoCommon.com.pandawork.common.dto.MapDTO createTreeById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/createTreeById", ReplyAction="http://video.pandawork.net/map/MapService/createTreeByIdResponse")]
        System.Threading.Tasks.Task<VideoCommon.com.pandawork.common.dto.MapDTO> createTreeByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/getAllMapImageNames", ReplyAction="http://video.pandawork.net/map/MapService/getAllMapImageNamesResponse")]
        string[] getAllMapImageNames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://video.pandawork.net/map/MapService/getAllMapImageNames", ReplyAction="http://video.pandawork.net/map/MapService/getAllMapImageNamesResponse")]
        System.Threading.Tasks.Task<string[]> getAllMapImageNamesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MapServiceChannel : VideoClient.MapServiceReference.MapService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MapServiceClient : System.ServiceModel.ClientBase<VideoClient.MapServiceReference.MapService>, VideoClient.MapServiceReference.MapService {
        
        public MapServiceClient() {
        }
        
        public MapServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MapServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MapServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MapServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public VideoCommon.com.pandawork.common.entity.Map getMapById(int id) {
            return base.Channel.getMapById(id);
        }
        
        public System.Threading.Tasks.Task<VideoCommon.com.pandawork.common.entity.Map> getMapByIdAsync(int id) {
            return base.Channel.getMapByIdAsync(id);
        }
        
        public VideoCommon.com.pandawork.common.dto.MapDTO getMapDTOById(int id) {
            return base.Channel.getMapDTOById(id);
        }
        
        public System.Threading.Tasks.Task<VideoCommon.com.pandawork.common.dto.MapDTO> getMapDTOByIdAsync(int id) {
            return base.Channel.getMapDTOByIdAsync(id);
        }
        
        public void addMap(VideoCommon.com.pandawork.common.entity.Map map) {
            base.Channel.addMap(map);
        }
        
        public System.Threading.Tasks.Task addMapAsync(VideoCommon.com.pandawork.common.entity.Map map) {
            return base.Channel.addMapAsync(map);
        }
        
        public void updateMap(VideoCommon.com.pandawork.common.entity.Map map) {
            base.Channel.updateMap(map);
        }
        
        public System.Threading.Tasks.Task updateMapAsync(VideoCommon.com.pandawork.common.entity.Map map) {
            return base.Channel.updateMapAsync(map);
        }
        
        public void delMap(int id) {
            base.Channel.delMap(id);
        }
        
        public System.Threading.Tasks.Task delMapAsync(int id) {
            return base.Channel.delMapAsync(id);
        }
        
        public VideoCommon.com.pandawork.common.dto.MapDTO[] getAllMaps() {
            return base.Channel.getAllMaps();
        }
        
        public System.Threading.Tasks.Task<VideoCommon.com.pandawork.common.dto.MapDTO[]> getAllMapsAsync() {
            return base.Channel.getAllMapsAsync();
        }
        
        public VideoCommon.com.pandawork.common.dto.MapDTO[] findChildren(int id) {
            return base.Channel.findChildren(id);
        }
        
        public System.Threading.Tasks.Task<VideoCommon.com.pandawork.common.dto.MapDTO[]> findChildrenAsync(int id) {
            return base.Channel.findChildrenAsync(id);
        }
        
        public VideoCommon.com.pandawork.common.dto.MapDTO createTreeById(int id) {
            return base.Channel.createTreeById(id);
        }
        
        public System.Threading.Tasks.Task<VideoCommon.com.pandawork.common.dto.MapDTO> createTreeByIdAsync(int id) {
            return base.Channel.createTreeByIdAsync(id);
        }
        
        public string[] getAllMapImageNames() {
            return base.Channel.getAllMapImageNames();
        }
        
        public System.Threading.Tasks.Task<string[]> getAllMapImageNamesAsync() {
            return base.Channel.getAllMapImageNamesAsync();
        }
    }
}