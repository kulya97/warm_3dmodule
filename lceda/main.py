import requests
import json
import codecs
import os
print("本程序用于下载嘉立创3D模型")
print("作者：kulya97")
print("发布网址：https://github.com/kulya97/warm_3dmodule")
path='0819f05c4eef4c71ace90d822a990e87'
code = input("输入元件ID: ")
#code='C17414'
#---------------------------------------------------------------#
has_url = 'https://pro.lceda.cn/api/eda/product/search' #跟距编号搜索hasDevice
has_formdata = {
    'keyword':code,
'needAggs':'true',
'url':'/api/eda/product/list',
'currPage':'1',
'pageSize':'10'
}
r0 = requests.post(has_url,data = has_formdata)
json_data = json.loads(r0.text)
Data_ls1 = json_data['result']
Data_ls2 = Data_ls1['productList']
Data_ls3 = Data_ls2[0]
hasDevice = Data_ls3['hasDevice']
print('-------------------------------------------------------------------------------------------------------------------------------')
print('---------------------'+'get hasdevice'+'---------------------')
print('---------------------'+'this is json data'+'-----------------')
print(json_data)
print('-------------------------------------------------------------------------------------------------------------------------------')
#---------------------------------------------------------------#
url = 'https://pro.lceda.cn/api/devices/searchByIds'
formdata = {
'uuids[]':hasDevice,
'path':path
}
r1 = requests.post(url,data = formdata)
json_data = json.loads(r1.text)
Data_ls1 = json_data['result']
Data_ls2 = Data_ls1[0]
Data_ls3 = Data_ls2['attributes']
Model_id = Data_ls3['3D Model']
print('-------------------------------------------------------------------------------------------------------------------------------')
print('---------------------'+'get model id'+'---------------------')
print('---------------------'+'this is json data'+'-----------------')
print(json_data)
print('-------------------------------------------------------------------------------------------------------------------------------')
#---------------------------------------------------------------#
url2 = 'https://pro.lceda.cn/api/components/searchByIds?forceOnline=1' #请求3d封装名称
formdata2 = {
'uuids[]':Model_id,
'dataStr':'yes',
'path':path
}
r2 = requests.post(url2,data = formdata2)
json_data = json.loads(r2.text)

Data_ls1 = json_data['result']
Data_ls2 = Data_ls1[0]
Data_ls3 = Data_ls2['dataStr']
Data_ls4=json.loads(Data_ls3)
Model_id0 = Data_ls4['model']
Model_src = Data_ls4['src']
print('-------------------------------------------------------------------------------------------------------------------------------')
print('---------------------'+'get hasdevice'+'---------------------')
print('---------------------'+'this is json data'+'-----------------')
print(json_data)
print('-----------------'+'module_src='+Model_src+'-----------------')
print('-------------------------------------------------------------------------------------------------------------------------------')
#---------------------------------------------------------------#
#获取step封装
download_url="https://modules.lceda.cn/qAxj6KHrDKw4blvCG8QJPs7Y/"+Model_id0
r3 = requests.get(download_url)
demo = r3.text
filename=Model_src+'.step'
print('-------------------------------------------------------------------------------------------------------------------------------')
print(filename)
print('-------------------------------------------------------------------------------------------------------------------------------')
f=codecs.open(filename,'w','utf-8')
f.write(demo)
#os.startfile(f)
f.close()
current_directory=os.getcwd()
os.startfile(str(current_directory))

