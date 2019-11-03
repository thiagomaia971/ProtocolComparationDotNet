﻿using System.Threading.Tasks;
using System.Xml.Linq;
using ProtocolComparationDotNet.Domain;
using ProtocolComparationDotNet.Domain.InputModel;

namespace ProtocolComparationDotNet.Soap
{
    public class SampleService : ISampleService
    {
        public string Ping(string s)
        {
            //Console.WriteLine("Exec ping method");
            return s;
        }

        public ComplexModelResponse PingComplexModel(ComplexInputModel inputModel)
        {
            //Console.WriteLine("Input data. IntProperty: {0}, StringProperty: {1}", inputModel.IntProperty, inputModel.StringProperty);

            return new ComplexModelResponse
            {
                //FloatProperty = float.MaxValue / 2,
                StringProperty = inputModel.StringProperty,
                ListProperty = inputModel.ListProperty,
                DateTimeOffsetProperty = inputModel.DateTimeOffsetProperty
            };
        }

        public void VoidMethod(out string s)
        {
            s = "Value from server";
        }

        public Task<int> AsyncMethod()
        {
            return Task.Run(() => 42);
        }

        public int? NullableMethod(bool? arg)
        {
            return null;
        }

        public void XmlMethod(XElement xml)
        {
            //Console.WriteLine(xml.ToString());
        }
    }
}