﻿using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace $rootnamespace$
{
	partial class $safeitemrootname$
	{
		#region 设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode]
		[System.CodeDom.Compiler.GeneratedCode("","")]
		private void InitializeComponent()
		{
			this.CanModifyActivities = true;
			System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
			System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding1 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
			System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
			System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding2 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
			System.Workflow.Activities.TypedOperationInfo typedoperationinfo1 = new System.Workflow.Activities.TypedOperationInfo();
			System.Workflow.Activities.WorkflowServiceAttributes workflowserviceattributes1 = new System.Workflow.Activities.WorkflowServiceAttributes();
			this.receiveActivity1 = new System.Workflow.Activities.ReceiveActivity();
			// 
			// receiveActivity1
			//
			this.receiveActivity1.CanCreateInstance = true; 
			this.receiveActivity1.Name = "receiveActivity1";
			activitybind1.Name = "$safeitemrootname$";
			activitybind1.Path = "ReturnValue";
			workflowparameterbinding1.ParameterName = "(ReturnValue)";
			workflowparameterbinding1.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
			activitybind2.Name = "$safeitemrootname$";
			activitybind2.Path = "InputValue";
			workflowparameterbinding2.ParameterName = "value";
			workflowparameterbinding2.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
			this.receiveActivity1.ParameterBindings.Add(workflowparameterbinding1);
			this.receiveActivity1.ParameterBindings.Add(workflowparameterbinding2);
			typedoperationinfo1.ContractType = typeof($rootnamespace$.$contractName$);
			typedoperationinfo1.Name = "GetData";
			this.receiveActivity1.ServiceOperationInfo = typedoperationinfo1;
			workflowserviceattributes1.ConfigurationName = "$safeitemrootname$";
			workflowserviceattributes1.Name = "$safeitemrootname$";
			// 
			// $safeitemrootname$
			// 
			this.Activities.Add(this.receiveActivity1);
			this.Name = "$safeitemrootname$";
			this.SetValue(System.Workflow.Activities.ReceiveActivity.WorkflowServiceAttributesProperty, workflowserviceattributes1);
			this.CanModifyActivities = false;

		}

		#endregion

		private ReceiveActivity receiveActivity1;

	}
}
