﻿namespace NetArchTest.TestStructure.Dependencies.Search
{
    using System.Collections.Generic;
    using NetArchTest.TestStructure.Dependencies.Examples;

    /// <summary>
    /// Example class that includes a dependency in a public field definition.    
    /// </summary>
    public class PublicFieldNestedGeneric
    {
        public List<List<ExampleDependency>> Example;
    }
}