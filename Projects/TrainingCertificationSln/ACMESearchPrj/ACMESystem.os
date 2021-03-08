<OpenSpanDesignDocument Version="19.1.0.25" Serializer="2.0" Culture="pt-BR">
  <ComponentInfo>
    <Type Value="OpenSpan.Adapters.Web.Universal.UniversalWebAdapter" />
    <Assembly Value="OpenSpan.Adapters.Web" />
    <AssemblyReferences>
      <Assembly Value="mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="OpenSpan, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.Virtual, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.Web.Universal, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.Web.WebBase, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.Windows, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
    </AssemblyReferences>
    <DynamicAssemblyReferences />
    <FileReferences />
    <BuildReferences>
      <File Value="DefaultWindowFactoryConfiguration.xml" />
      <File Value="openspan.ini" />
      <File Value="OpenSpan.x32.sys" />
      <File Value="OpenSpan.x64.sys" />
      <File Value="Pega.GlobalAllocator.x32.dll" />
      <File Value="Pega.GlobalAllocator.x64.dll" />
      <File Value="Pega.Scout.x32.dll" />
      <File Value="Pega.Scout.x64.dll" />
      <File Value="Pega.Security.x32.dll" />
      <File Value="Pega.Security.x64.dll" />
      <File Value="Pega.SharedMemory.x32.dll" />
      <File Value="Pega.SharedMemory.x64.dll" />
      <File Value="Pega.Sinon.x32.dll" />
      <File Value="Pega.Sinon.x64.dll" />
      <File Value="Pega.Utilities.x32.dll" />
      <File Value="Pega.Utilities.x64.dll" />
      <File Value="Pega.WER.x32.dll" />
      <File Value="Pega.WER.x64.dll" />
      <File Value="Pega.Windows.Broker.x32.dll" />
      <File Value="Pega.Windows.Broker.x64.dll" />
      <File Value="Pega.WinQueue.x32.dll" />
      <File Value="Pega.WinQueue.x64.dll" />
    </BuildReferences>
  </ComponentInfo>
  <Component Version="1.0">
    <OpenSpan.Adapters.Web.Universal.UniversalWebAdapter Name="ACMESystem" Id="UniversalWebAdapter-8D8DE50B28552EF">
      <StartOnProjectStart Value="False" />
      <StartPage Value="http://training.openspan.com" />
      <Content Name="AcceptedDomains">
        <Capacity Value="2" />
        <Items>
          <OpenSpan.Adapters.Web.WebBase.AcceptedDomain Value="Contains|True|(User Culture)|training.openspan.com" />
        </Items>
      </Content>
      <Content Name="Controls">
        <Items>
          <OpenSpan.Adapters.Web.WebBase.Controls.WebPage Name="ACMEwpSignIn" Id="WebPage-8D8E248A5F8C9E4">
            <DummyPropertyToDetectReplaceUndo Value="0" />
            <ForwardObjectExplorerEvent Value="True" />
            <IsGlobal Value="True" />
            <MatchingIndex Value="0" />
            <PegaId Value="0" />
            <TargetTypeString Value="OpenSpan.Adapters.Web.WebBase.Targets.VirtualHtmlDocumentTarget, OpenSpan.Adapters.Web.WebBase" />
            <XrayGuid Value="" />
            <Content Name="Controls">
              <Items>
                <OpenSpan.Adapters.Web.WebBase.Controls.Form Name="Insira_um_nome_de_usuário_de_pelo_m" Id="Form-8D8E248A5D9BB34">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <MatchingIndex Value="0" />
                  <PegaId Value="0" />
                  <TagName Value="FORM" />
                  <TargetTypeString Value="OpenSpan.Adapters.Web.WebBase.Targets.VirtualHtmlFormElementTarget, OpenSpan.Adapters.Web.WebBase" />
                  <UseElementId Value="False" />
                  <XrayGuid Value="" />
                  <Content Name="Controls">
                    <Items>
                      <OpenSpan.Adapters.Web.WebBase.Controls.TextBox Name="ACMEtxtUserName" Id="TextBox-8D8E248A5BC358E">
                        <DummyPropertyToDetectReplaceUndo Value="0" />
                        <ElementId Value="user_name" />
                        <ForwardObjectExplorerEvent Value="True" />
                        <MatchingIndex Value="0" />
                        <PegaId Value="0" />
                        <TagName Value="INPUT" />
                        <TargetTypeString Value="OpenSpan.Adapters.Web.WebBase.Targets.VirtualHtmlInputTextElementTarget, OpenSpan.Adapters.Web.WebBase" />
                        <UseElementId Value="True" />
                        <XrayGuid Value="" />
                        <Content Name="MatchRules">
                          <Items>
                            <OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Name="virtualPropertyMatchRule4" Id="VirtualPropertyMatchRule-8D8E248A6762F94">
                              <PropertyName Value="type" />
                              <Text Value="Simple|True|(User Culture)|text" />
                            </OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule>
                            <OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Name="virtualPropertyMatchRule5" Id="VirtualPropertyMatchRule-8D8E248A69FA892">
                              <PropertyName Value="id" />
                              <Text Value="Simple|True|(User Culture)|user_name" />
                            </OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule>
                          </Items>
                        </Content>
                      </OpenSpan.Adapters.Web.WebBase.Controls.TextBox>
                      <OpenSpan.Adapters.Web.WebBase.Controls.TextBox Name="user_pass" Id="TextBox-8D8E248B7E2F760">
                        <DummyPropertyToDetectReplaceUndo Value="0" />
                        <ElementId Value="user_pass" />
                        <ForwardObjectExplorerEvent Value="True" />
                        <MatchingIndex Value="1" />
                        <PegaId Value="0" />
                        <TagName Value="INPUT" />
                        <TargetTypeString Value="OpenSpan.Adapters.Web.WebBase.Targets.VirtualHtmlInputPasswordElementTarget, OpenSpan.Adapters.Web.WebBase" />
                        <UseElementId Value="True" />
                        <XrayGuid Value="" />
                        <Content Name="MatchRules">
                          <Items>
                            <OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Name="virtualPropertyMatchRule6" Id="VirtualPropertyMatchRule-8D8E248B81C381C">
                              <PropertyName Value="type" />
                              <Text Value="Simple|True|(User Culture)|password" />
                            </OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule>
                            <OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Name="virtualPropertyMatchRule7" Id="VirtualPropertyMatchRule-8D8E248B83775B6">
                              <PropertyName Value="id" />
                              <Text Value="Simple|True|(User Culture)|user_pass" />
                            </OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule>
                          </Items>
                        </Content>
                      </OpenSpan.Adapters.Web.WebBase.Controls.TextBox>
                      <OpenSpan.Adapters.Web.WebBase.Controls.Button Name="ACMEfrmCredentials" Id="Button-8D8E248BC54D22E">
                        <DummyPropertyToDetectReplaceUndo Value="0" />
                        <ElementId Value="login_button" />
                        <ForwardObjectExplorerEvent Value="True" />
                        <MatchingIndex Value="2" />
                        <PegaId Value="0" />
                        <TagName Value="INPUT" />
                        <TargetTypeString Value="OpenSpan.Adapters.Web.WebBase.Targets.VirtualHtmlInputSubmitElementTarget, OpenSpan.Adapters.Web.WebBase" />
                        <UseElementId Value="True" />
                        <XrayGuid Value="" />
                        <Content Name="MatchRules">
                          <Items>
                            <OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Name="virtualPropertyMatchRule8" Id="VirtualPropertyMatchRule-8D8E248BC8D49D0">
                              <PropertyName Value="type" />
                              <Text Value="Simple|True|(User Culture)|submit" />
                            </OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule>
                            <OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Name="virtualPropertyMatchRule9" Id="VirtualPropertyMatchRule-8D8E248BCA5B756">
                              <PropertyName Value="id" />
                              <Text Value="Simple|True|(User Culture)|login_button" />
                            </OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule>
                          </Items>
                        </Content>
                      </OpenSpan.Adapters.Web.WebBase.Controls.Button>
                    </Items>
                  </Content>
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Name="virtualPropertyMatchRule3" Id="VirtualPropertyMatchRule-8D8E248A649E6B1">
                        <PropertyName Value="action" />
                        <Text Value="Simple|True|(User Culture)|http://training.openspan.com/home" />
                      </OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Web.WebBase.Controls.Form>
              </Items>
            </Content>
            <Content Name="MatchRules">
              <Items>
                <OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Name="virtualPropertyMatchRule1" Id="VirtualPropertyMatchRule-8D8E248A60C4493">
                  <PropertyName Value="url" />
                  <Text Value="Simple|True|(User Culture)|http://training.openspan.com/login" />
                </OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule>
                <OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Name="virtualPropertyMatchRule2" Id="VirtualPropertyMatchRule-8D8E248A61B077E">
                  <PropertyName Value="title" />
                  <Text Value="Simple|True|(User Culture)|Entrar | Aplicativo da Web de treinamento Pega Studio" />
                </OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule>
              </Items>
            </Content>
          </OpenSpan.Adapters.Web.WebBase.Controls.WebPage>
        </Items>
      </Content>
      <Content Name="Credentials">
        <Items>
          <OpenSpan.ApplicationFramework.AssistedSignOn.Credential>
            <ApplicationKey Value="ACMESystem" />
          </OpenSpan.ApplicationFramework.AssistedSignOn.Credential>
        </Items>
      </Content>
      <Content Name="ElectronConfiguration">
        <OpenSpan.Adapters.Web.Universal.Electron.ElectronConfiguration>
          <Path Value="" />
        </OpenSpan.Adapters.Web.Universal.Electron.ElectronConfiguration>
      </Content>
    </OpenSpan.Adapters.Web.Universal.UniversalWebAdapter>
  </Component>
</OpenSpanDesignDocument>