<Window x:Class="CalculatorApp.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Calculator" Height="400" Width="300">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <StackPanel Grid.Row="0" Orientation="Horizontal" Margin="5">
            <TextBox x:Name="tbDisplay" HorizontalAlignment="Right" VerticalAlignment="Center" FontSize="20" Width="250" Margin="0,0,5,0"/>
        </StackPanel>

        <Grid Grid.Row="1" Margin="5">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>

            <Button Content="7" Click="Number_Click" Grid.Column="0"/>
            <Button Content="8" Click="Number_Click" Grid.Column="1"/>
            <Button Content="9" Click="Number_Click" Grid.Column="2"/>
            <Button Content="/" Click="Operation_Click" Grid.Column="3"/>

            <Button Content="4" Click="Number_Click" Grid.Column="0" Grid.Row="1"/>
            <Button Content="5" Click="Number_Click" Grid.Column="1" Grid.Row="1"/>
            <Button Content="6" Click="Number_Click" Grid.Column="2" Grid.Row="1"/>
            <Button Content="*" Click="Operation_Click" Grid.Column="3" Grid.Row="1"/>

            <Button Content="1" Click="Number_Click" Grid.Column="0" Grid.Row="2"/>
            <Button Content="2" Click="Number_Click" Grid.Column="1" Grid.Row="2"/>
            <Button Content="3" Click="Number_Click" Grid.Column="2" Grid.Row="2"/>
            <Button Content="-" Click="Operation_Click" Grid.Column="3" Grid.Row="2"/>

            <Button Content="0" Click="Number_Click" Grid.Column="0" Grid.Row="3"/>
            <Button Content="." Click="Number_Click" Grid.Column="1" Grid.Row="3"/>
            <Button Content="=" Click="Equals_Click" Grid.Column="2" Grid.Row="3"/>
            <Button Content="+" Click="Operation_Click" Grid.Column="3" Grid.Row="3"/>

            <Button Content="C" Click="Clear_Click" Grid.Column="0" Grid.Row="4"/>
            <Button Content="√" Click="Operation_Click" Grid.Column="1" Grid.Row="4"/>
            <Button Content="1/x" Click="Operation_Click" Grid.Column="2" Grid.Row="4"/>
            <Button Content="%" Click="Operation_Click" Grid.Column="3" Grid.Row="4"/>
        </Grid>

        <StackPanel Grid.Row="2" Orientation="Horizontal" Margin="5">
            <TextBox x:Name="tbOperation" HorizontalAlignment="Right" VerticalAlignment="Center" FontSize="14" Width="250" IsReadOnly="True"/>
        </StackPanel>
    </Grid>
</Window>
