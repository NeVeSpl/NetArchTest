﻿namespace NetArchTest.TestStructure.Dependencies.Search.DependencyType
{
    using System.Threading.Tasks;
    using NetArchTest.TestStructure.Dependencies.Examples;

    /// <summary>
    /// Example class that includes an array dependency    
    /// </summary>
    public class ArrayOfGenerics
    { 
        public void ExampleMethod()
        {
            ExampleDependency<double>[] test1 = null;
            ExampleDependency<int>[] test2 = null;          
        }
    }
}
