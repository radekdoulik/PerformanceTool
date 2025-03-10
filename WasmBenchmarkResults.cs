﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WasmBenchmarkResults
{
    public class GraphPointData
    {
        public string commitTime;
        public string taskMeasurementName;
        public double minTime;
        public string flavor;
        public string gitLogUrl;
        public string commitHash;
        public double percentage;
        public string unit;

        public GraphPointData(string commitTime, string flavor, KeyValuePair<string, double> pair, string gitLogUrl, string hash, string unit = "ms", double percentage = 0)
        {
            this.commitTime = commitTime;
            taskMeasurementName = pair.Key;
            minTime = pair.Value;
            this.flavor = flavor;
            this.gitLogUrl = gitLogUrl;
            commitHash = hash;
            this.unit = unit;
            this.percentage = percentage;
        }

        public override string ToString()
        {
            return this.commitTime + " " + this.flavor + " " + this.taskMeasurementName;
        }

    }

    public class RequiredData
    {
        public List<GraphPointData> graphPoints;
        public List<string> flavors;
        public List<string> taskNames;

        public RequiredData(List<GraphPointData> graphPoints, List<string> flavors, List<string> taskNames)
        {
            this.graphPoints = graphPoints;
            this.flavors = flavors;
            this.taskNames = taskNames;
        }

    }
}
